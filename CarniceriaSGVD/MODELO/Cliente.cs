using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class Cliente:Persona
    {
        public int codigoId { get; set; }
        public CtaCteCliente  CtaCte { get; set; }
        public virtual IList<Cliente> listaPedidosCliente { get; set; }

       

    }
}
