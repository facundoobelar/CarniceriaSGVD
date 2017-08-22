using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    public class CtaCteCliente
    {
        public int CuentaID { get; set; }
        public float Saldo { get; set; }
        public virtual IList<Pago>  ListaPagosClientes { get; set; }
        public Cliente Cliente { get; set; }

        public void pagarCuenta(float pMonto)
        {
             this.Saldo = this.Saldo - pMonto;
        }
    }
}
