using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Pago
    {
        public IList<Venta> listaPagosVentas { get; set; }
        public float montoTotal { get; set; }
        public TipoPago Type { get; set; }

        public float MontoTotal()
        {
            return this.montoTotal;
        }


     }

    public enum TipoPago
    {

        DEBITO,

        EFECTIVO,

        FIADO

    }


}

