using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class Ingreso_Egreso
    {   public int ingresoID { get; set; }
        public DateTime fecha { get; set; }
        public string unidadMedida { get; set; }
        public float cantidadPeso { get; set; }
        public string descripcion { get; set; }
    }
}
