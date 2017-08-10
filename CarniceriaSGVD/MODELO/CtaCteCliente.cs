using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class CtaCteCliente
    {
        public int idCuentaId { get; set; }
        public float saldo { get; set; }
        public IList<Pago> listaPagosClientes { get; set; }
        public Cliente iCliente { get; set; }

        public void pagarCuenta(float pMonto)
        {
             this.saldo = this.saldo - pMonto;
        }
    }
}
