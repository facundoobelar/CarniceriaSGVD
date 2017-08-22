using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class AperturaCaja
    {
        public int AperturaCajaID { get; set; }
        public float MontoFinal { get; set; }
        public float MontoInicial { get; set; }
        public DateTime Fecha { get; set; }
        public IList<GastoCarniceria> ListaGastos { get; set; }
        public IList<Venta> ListaVentas { get; set; }
        public IList<Pago> ListaPagos { get; set; }
    }
}
