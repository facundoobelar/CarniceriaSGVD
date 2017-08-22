using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarniceriaSGVD.MODELO
{
    public class Pedido
    {
        public int codigoPedidoId { get; set; }
        public DateTime fecha { get; set; }
        public float saldo { get; set; }
        public float total { get; set; }
        private IList<LineaPedido> listaLineaPedido { get; set; }



        //public bool estado { get; set; }
        
        public float pagarMonto(float pMonto)
        {
           return this.saldo = this.total - pMonto;
        }
    }
}