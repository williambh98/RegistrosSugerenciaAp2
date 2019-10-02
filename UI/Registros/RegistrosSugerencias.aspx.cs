﻿using BLL;
using Entidades;
using RegistroSugerenciaAp2.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroSugerenciaAp2.UI.Registros
{
    public partial class RegistrosSugerencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Utils.ToInt(Request.QueryString["id"]);
                if (id > 0)
                {
                    RepositorioBase<Sugerencia> repositorio = new RepositorioBase<Sugerencia>();
                    Sugerencia user = repositorio.Buscar(id);
                    if (user == null)
                        Utils.ShowToastr(this, "Id no existe", "Error", "error");
                    else
                        LlenaCampo(user);

                }
                else
                {
                    NuevoButton_Click(null, null);
                }
            }

        }
        private void Limpiar()
        {
            IdTextBox.Text = 0.ToString();
            fechaTextBox.Text = DateTime.Now.ToString();
            DescripcionTextBox.Text = string.Empty;
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Sugerencia LlenaClase()
        {
            Sugerencia sugerencia = new Sugerencia();
            sugerencia.SugerenciaId = Utils.ToInt(IdTextBox.Text);
            sugerencia.Fecha = DateTime.Now;
            sugerencia.Descripcion = DescripcionTextBox.Text;
            return sugerencia;
        }
        private void LlenaCampo(Sugerencia sugerencia)
        {
            IdTextBox.Text = sugerencia.SugerenciaId.ToString();
            fechaTextBox.Text = sugerencia.Fecha.ToString();
            DescripcionTextBox.Text = sugerencia.Descripcion;
        }
        private bool Validar()
        {
            bool paso = true;
      
            if (string.IsNullOrWhiteSpace(fechaTextBox.Text))
                paso = false;
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
                paso = false;
            return paso;
        }
      
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Sugerencia> repositorio = new RepositorioBase<Sugerencia>();
            Sugerencia sugerecia = repositorio.Buscar(Utils.ToInt(IdTextBox.Text));

            if (sugerecia == null)
            {
                if (repositorio.Guardar(LlenaClase()))
                {

                    Utils.ShowToastr(this, "Guardado", "Exito", "success");
                    Limpiar();
                }
                else
                {
                    Utils.ShowToastr(this, "No existe", "Error", "error");
                    Limpiar();
                }

            }
            else
            {
                if (repositorio.Modificar(LlenaClase()))
                {
                    Utils.ShowToastr(this.Page, "Modificado con exito!!", "Guardado", "success");
                    Limpiar();
                }
                else
                {
                    Utils.ShowToastr(this.Page, "No se puede modificar", "Error", "error");
                    Limpiar();
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Sugerencia> repositorio = new RepositorioBase<Sugerencia>();
            int id = Utils.ToInt(IdTextBox.Text);
            var sugerencia = repositorio.Buscar(id);

            if (sugerencia != null)
            {
                if (repositorio.Eliminar(id))
                {
                    Utils.ShowToastr(this.Page, "Exito Eliminado", "success");
                    Limpiar();
                }
                else
                    Utils.ShowToastr(this.Page, "No Eliminado", "error");
            }
            else
                EliminarRequiredFieldValidator.IsValid = false;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Sugerencia> rep = new RepositorioBase<Sugerencia>();
            Sugerencia a = rep.Buscar(Utils.ToInt(IdTextBox.Text));
            if (a != null)
                LlenaCampo(a);
            else
            {
                Limpiar();
                Utils.ShowToastr(this.Page, "Id no exite", "Error", "error");
            }
        }
    }

}

