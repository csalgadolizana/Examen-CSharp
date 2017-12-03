using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSQL;

namespace BibliotecaSQL
{
    public class ClienteDAO
    {
        //AGREGAR  CLIENTE
        public bool ingresarCliente(cliente clien)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    context.cliente.Add(clien);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al grabar el Cliente " + ex.Message);
                }
            }
        }

        //EDITAR CLIENTE
        public bool editarCliente(cliente clien)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    cliente clienTemp = buscarCliente(clien.id_cliente);
                    clienTemp.id_cliente = clien.id_cliente;
                    clienTemp.nombre = clien.nombre;
                    clienTemp.rut = clien.rut;

                    context.Entry(clienTemp).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al editar el cliente" + ex.Message);
                }
            }

        }


        public cliente buscarCliente(int codigo)
        {
            using (var context = new RestauranteEntities())
            {
                cliente clien = new cliente();
                try
                {
                    clien = context.cliente.First(c => c.id_cliente.Equals(codigo));
                    return clien;
                }
                catch (Exception ex)
                {
                    return null;
                    throw new ArgumentException("Error al buscar el cliente" + ex.Message);
                }
            }
        }

        public List<cliente> listaCliente()
        {
            using (var context = new RestauranteEntities())
            {
                List<cliente> lis = context.cliente.ToList();
                return lis;
            }
        }


    }
}
