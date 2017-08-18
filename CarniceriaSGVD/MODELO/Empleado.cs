using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Empleado:Persona
    {
         public int codigoId { get; set; }
        public TipoEmpleado iTipoEmpleado { get; set; }
        public IList<Asistencia> listaAsistencia { get; set; }
        public IList<Ingreso_Egreso> listaIngresoEgreso { get; set; }
        public IList<PedidoAProveedor> listaPedidoProveedor { get; set; }
        public IList<AperturaCaja> listaApertura { get; set; }
    }
}
