using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class LineaVenta
    {
        public float cantidadProd { get; set; }
        public float valorLinea { get; set; }


        public float CalcularLinea()
        {
            float totallinea;
            totallinea = this.valorLinea * this.cantidadProd;
            return totallinea;
        }

    }
}
