using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Proveedor:Persona
    {
        public int codigoId { get; set; }
        public IList<PedidoAProveedor> listaPedido { get; set; }
        public IList<Producto> listaProductos { get; set; }




    }
}
