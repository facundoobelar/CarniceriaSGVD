using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class LineaPedido
    {
        public float total { get; set; }
        public int cantProductos { get; set; }
        public Producto iProducto { get; set; }
    }
}
