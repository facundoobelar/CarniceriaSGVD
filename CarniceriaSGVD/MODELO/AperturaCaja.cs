using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class AperturaCaja
    {
        public float montoFinal { get; set; }
        public float montoInicial { get; set; }
        public DateTime fecha { get; set; }
        public IList<GastoCarniceria> listaGastos { get; set; }
        public IList<Venta> listaVentas { get; set; }
        public IList<Pago> listaPagos { get; set; }
    }
}
