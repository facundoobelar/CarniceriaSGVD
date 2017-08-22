using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    public class Producto
    {
        public int codigoProductoId { get; set; }
        public string nombre { get; set; }
        public float unidadMedida { get; set; }
        public TipoProducto iTipoProducto { get; set; }
        public IList<Ingreso_Egreso> listaIngEgreProd { get; set; }
        public IList<LineaPedido> listaLineaPedidoProducto { get; set; }
        public IList<Proveedor> listaProveedoresProd { get; set; }
        public IList<LineaVenta> listaLineaVentaProd { get; set; }
    }
}
