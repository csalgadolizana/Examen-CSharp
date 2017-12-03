using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL
{
   public class DaoVenta
    {
        public bool ingresoVenta(venta mod)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    context.venta.Add(mod);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al grabar la venta!" + ex.Message);
                }
            }
        }

        public List<venta> listaVentas()
        {
            using (var context = new RestauranteEntities())
            {
                List<venta> lis = context.venta.ToList();
                return lis;
            }
        }
    }
}
