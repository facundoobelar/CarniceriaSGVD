using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    class GastoCarniceria
    {
        public int idGastoId { get; set; }
        public float montoTotal { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public TipoGasto iGasto { get; set; }
    }
}
