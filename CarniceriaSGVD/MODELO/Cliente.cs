using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Cliente:Persona
    {
        public int codigoId { get; set; }
        public IList<Cliente> listaPedidosCliente { get; set; }

       

    }
}
