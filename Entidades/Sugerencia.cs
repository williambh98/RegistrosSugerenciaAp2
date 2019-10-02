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
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Sugerencia()
        {
            this.SugerenciaId = 0;
            this.Descripcion = string.Empty;
            this.Fecha = DateTime.Now;
        }

        public Sugerencia(int sugerenciaId, string descripcion, DateTime fecha)
        {
            SugerenciaId = sugerenciaId;
            Descripcion = descripcion;
            Fecha = fecha;
        }
    }
}
