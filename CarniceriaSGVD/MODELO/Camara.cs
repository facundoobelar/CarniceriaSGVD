using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Camara
    {
        public int idCamaraId { get; set; }
        public string nombre { get; set; }
        public IList<Ingreso_Egreso> listaIngreso { get; set; }
        public IList<Ingreso_Egreso> listaEgreso { get; set; }
        public IList<Producto> listaProductoCamara { get; set; }
        public IList<Caja> listaCajas { get; set; }

        public Camara BuscarCamara(int pIdCam)
        {
            Camara iCamara;
            //falta algo aca para el get
            iCamara = this.Get(pIdCam);
                return iCamara;
        }


    }



}
