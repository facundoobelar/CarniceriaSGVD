using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarniceriaSGVD.MODELO;


namespace CarniceriaSGVD.MODELO
{
   public class Venta
    {
        
        public DateTime fecha { get; set; }
        public float valorVenta { get; set; }
        public IList<LineaVenta> listaLineaVenta { get; set; }
        LineaVenta iLinea = new LineaVenta();
        public float CalcularTotal()
        {
            while (listaLineaVenta != null)
            {
                this.valorVenta = this.valorVenta + iLinea.CalcularLinea();
            }
            return valorVenta;
        }

      
    }
}
