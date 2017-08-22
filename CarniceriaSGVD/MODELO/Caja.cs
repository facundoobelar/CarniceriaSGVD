using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class Caja
    {
        public int CajaId { get; set; }
        public int CamaraID { get; set; }
        public Camara Camara { get; set; }
        public IList<AperturaCaja> listaAperturaCaja { get; set; }

        public void IniciarAperturaCaja ()
        {
            
        }

        



    }
}
