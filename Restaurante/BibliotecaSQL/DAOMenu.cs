using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL
{
    public class DAOMenu
    {
        public bool ingresoMenu(menu mod)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    context.menu.Add(mod);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al grabar el Menu! \ndebido a " + ex.Message);
                }
            }
        }

        public bool editarMenu(menu mod)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    menu modTemp = buscarMenu(mod.id_menu);
                    modTemp.precio = mod.precio;
                    modTemp.descripcion = mod.descripcion;
                    context.Entry(modTemp).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al editar el Menu! debido a " + ex.Message);
                }
            }
        }

        public menu buscarMenu(int codigo)
        {
            using (var context = new RestauranteEntities())
            {
                menu mod = new menu();
                try
                {
                    mod = context.menu.First(m => m.id_menu.Equals(codigo));
                    return mod;
                }
                catch (Exception ex)
                {
                    return null;
                    throw new ArgumentException("Error al buscar el Menu! \ndebido a " + ex.Message);
                }
            }
        }

        public List<menu> listaMenus()
        {
            using (var context = new RestauranteEntities())
            {
                List<menu> lis = context.menu.ToList();
                return lis;
            }
        }

    }
}
