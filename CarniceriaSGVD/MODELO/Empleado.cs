    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class Empleado:Persona
    {
        public Empleado() : base() { }
        public int codigoId { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }
        public virtual IList<Asistencia> ListaAsistencia { get; set; }
        public virtual IList<Ingreso_Egreso> ListaIngresoEgreso { get; set; }
        public virtual IList<PedidoAProveedor> ListaPedidoProveedor { get; set; }
        public IList<AperturaCaja> ListaApertura { get; set; }
    }
}
