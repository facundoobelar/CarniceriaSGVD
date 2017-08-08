using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class Persona
    {
        public int dniId { get; set;}
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public string getNombreApellido()
        {

            return (this.nombre + " " + this.apellido);
        }

    }


}
