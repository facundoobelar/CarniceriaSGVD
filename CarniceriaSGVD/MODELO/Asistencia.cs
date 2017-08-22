using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class Asistencia
    {
        public int AsistenciaID { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }
        public int EmpleadoID { get; set; }
        public Empleado Empleado { get; set; }


    }
}
