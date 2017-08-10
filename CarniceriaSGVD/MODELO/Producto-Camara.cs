using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Producto_Camara
    {
        public float stock { get; set; }
        public float precioArt { get; set; }
        public int idCamaraId { get; set; }
        public int codigoProductoId { get; set; }
        public IList<PrecioCompra> listaPrecioCompra { get; set; }
        public IList<PrecioVenta> listaPrecioVenta { get; set; }


        public float AumentarStock(float pStock)
        {
           return this.stock = this.stock + pStock;
        }

        public float DescontarStock(float pStock)
        {
            return this.stock = this.stock - pStock;
        }

    }
}
