using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class PrecioVenta
    {
        public PrecioCompra iPrecioCompra { get; set; }
        public DateTime fInicio { get; set; }
        public DateTime fFin { get; set; }
        public float montoventa { get; set; }
    }
}
