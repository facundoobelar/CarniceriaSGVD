using CarniceriaSGVD.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarniceriaSGVD.ENTITY
{
    public class SGVD:DbContext
    {
        public DbSet<Producto_Camara> Productos_Camaras { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

    }
}
