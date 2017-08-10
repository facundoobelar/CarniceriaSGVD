using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Caja
    {
        public int idCajaId { get; set; }
        public int idCamara { get; set; }
        public IList<AperturaCaja> listaAperturaCaja { get; set; }

        public AperturaCaja IniciarAperturaCaja (Caja pidCaja)
        {
             AperturaCaja iAperturaCaja = new AperturaCaja();
            return iAperturaCaja;
        }

        



    }
}
