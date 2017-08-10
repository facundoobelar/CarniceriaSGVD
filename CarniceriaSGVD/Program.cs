using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarniceriaSGVD.ENTITY;
using CarniceriaSGVD.MODELO;

namespace CarniceriaSGVD
{
    class Program
    {
        static void Main(string[] args)
        {
            SGVD bContexto = new SGVD();
            Console.ReadKey();
            Persona pa = new Persona()
            {
                dniId = 1,
                nombre = "facu",
                direccion = "fa",
                telefono = "12",
            };

            bContexto.Personas.Add(pa);
        }
    }
}
