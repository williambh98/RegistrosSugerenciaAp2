using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Sugerencia
    {
        [Key]
        public int SugerenciaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public Sugerencia()
        {
            this.SugerenciaId = 0;
            this.Fecha = DateTime.Now;
            this.Descripcion = string.Empty;
        }

        public Sugerencia(int sugerenciaId, DateTime fecha, string descripcion)
        {
            SugerenciaId = sugerenciaId;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}
