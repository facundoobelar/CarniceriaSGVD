﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaSGVD.MODELO
{
    public class PedidoAProveedor:Pedido
    {
      private IList<GastoCarniceria> listaGastoCarniceria { get; set; }
    }


}