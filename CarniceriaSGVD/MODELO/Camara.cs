using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
   public class Camara
    {
        public int CamaraID { get; set; }
        public string Nombre { get; set; }
        public IList<Ingreso_Egreso> ListaIngreso { get; set; }
        public IList<Ingreso_Egreso> ListaEgreso { get; set; }
        public IList<Producto> ListaProductoCamara { get; set; }
        //public IList<Caja> ListaCajas { get; set; }

     /*   public Camara BuscarCamara(int pIdCam)
        {
            Camara iCamara;
            //falta algo aca para el get
            iCamara = this.Get(pIdCam);
                return iCamara;
        }*/


    }



}
