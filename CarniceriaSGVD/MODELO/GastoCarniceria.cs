using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class GastoCarniceria
    {
        public int GastoCarniceriaId { get; set; }
        public float MontoTotal { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TipoGasto Gasto { get; set; }
        public int AperturaCajaID { get; set; }
        public AperturaCaja AperturaCaja { get; set; }
        public int PedidoAProveedorID { get; set; }
        public PedidoAProveedor PedidoAProveedor { get; set; }
        public int TipoGastoID { get; set; }
        public TipoGasto TipoGasto { get; set; }

    }
}
