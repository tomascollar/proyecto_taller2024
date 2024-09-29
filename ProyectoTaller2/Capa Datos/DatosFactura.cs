using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.Capa_Datos
{
    internal class DatosFactura
    {
        public void InsertarVenta(factura nuevaFactura)
        {
            using(var context = new proyecto_taller2Entities())
            {
                context.factura.Add(nuevaFactura);
                context.SaveChanges();
            }
        }

        public List<factura> ObtenerVentas()
        {
            using(var context = new proyecto_taller2Entities())
            {
                return context.factura.ToList();
            }
        }
    }
}
