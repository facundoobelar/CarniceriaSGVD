using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Ingreso_Egreso
    {   public int idIngresoId { get; set; }
        public DateTime fecha { get; set; }
        public string unidadMedida { get; set; }
        public float cantidadPeso { get; set; }
        public string descripcion { get; set; }
    }
}
