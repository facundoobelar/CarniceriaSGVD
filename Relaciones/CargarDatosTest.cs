using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarniceriaSGVD.MODELO;


namespace Relaciones
{
    [TestClass]
    public class CargarDatosTest
    {
        [TestMethod]
        public void TestCargarEmpleado()
        {
            using (resource)
            {

            }
            //------------------------------------------------------------------------
            Empleado unEmpleado = new Empleado
            {
                apellido = "Duarte",
                nombre = "Alfredo",
                dniId = 28059482,
                direccion = "14 de Julio 610",
                telefono = "3777578530",
                //TipoEmpleado: Es un tipo numerado
                iTipoEmpleado = TipoEmpleado.Cajero,
                listaAsistencia = new List<Asistencia>
                {
                    new Asistencia
                    {
                        fecha=DateTime.Today.Date,
                        horaIngreso= DateTime.Today,
                        horaSalida=DateTime.Today
                    }
                },
                listaIngresoEgreso = new List<Ingreso_Egreso>
                {
                    new Ingreso_Egreso
                    {
                        cantidadPeso=33,
                        fecha=DateTime.Today,
                        ingresoID=1111,
                        unidadMedida="KG",
                        descripcion=""
                    }
                },

                listaPedidoProveedor = new List<PedidoAProveedor>
                {
                    //definir que es saldo, total y fecha.
                    new PedidoAProveedor
                    {
                        codigoPedidoId=2222,
                        fecha= DateTime.Today,
                        saldo=776,
                        total=987
                    }
                },
                listaApertura = new List<AperturaCaja>
                {
                    new AperturaCaja
                    {                        
                        fecha=DateTime.Today,
                        montoInicial=300,
                        montoFinal=1000
                    }
                },
            };
            //------------------------------------------------------------------------
        }
    }
}
