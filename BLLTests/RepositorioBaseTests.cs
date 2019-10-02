using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Sugerencia sugerencia = new Sugerencia();
            sugerencia.Descripcion = "william";

            RepositorioBase<Sugerencia> repositorioBase = new RepositorioBase<Sugerencia>();
            Assert.IsTrue(repositorioBase.Guardar(sugerencia));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Sugerencia sugerencia = new Sugerencia();
            sugerencia.SugerenciaId = 1;
            sugerencia.Descripcion = "williamb";

            RepositorioBase<Sugerencia> repositorioBase = new RepositorioBase<Sugerencia>();
            Assert.IsTrue(repositorioBase.Modificar(sugerencia));
        }

        [TestMethod()]
        public void ModificarTest1()
        {
            int id = 1;
            Sugerencia sugerencia = new Sugerencia();
            RepositorioBase<Sugerencia> repositorioBase = new RepositorioBase<Sugerencia>();
            sugerencia = repositorioBase.Buscar(id);
            Assert.AreEqual(true, sugerencia != null);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Sugerencia sugerencia = new Sugerencia();
            RepositorioBase<Sugerencia> repositorioBase = new RepositorioBase<Sugerencia>();
            sugerencia.SugerenciaId = 1;
            Assert.AreEqual(true, repositorioBase.Eliminar(sugerencia.SugerenciaId));
        }
    }
}