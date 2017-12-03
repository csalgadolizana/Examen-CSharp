using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL
{
   public class pedidoDAO
    {
        public List<pedido> listaPedido()
        {
            using (var context = new RestauranteEntities())
            {
                List<pedido> lis = context.pedido.ToList();
                return lis;
            }
        }

        public bool agregarPedido(pedido pe)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                        context.pedido.Add(pe);
                        context.SaveChanges();
                        return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al agregar pedido " + ex.Message);
                }
            }
        }

        public bool actualizarPedido(pedido pe)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    pedido pedidoTem = buscarPedido(pe.id_pedido);
                    pedidoTem.id_pedido = pe.id_pedido;
                    pedidoTem.descripcion = pe.descripcion;
                    pedidoTem.cliente_id = pe.cliente_id;

                    context.Entry(pedidoTem).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al actualizar el pedido" + ex.Message);
                }
            }
        }

        public pedido buscarPedido(int numero)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    pedido pedidoTemp = context.pedido.First(x => x.id_pedido.Equals(numero));
                    return pedidoTemp;
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

     /*   public bool eliminarPedido(int codigo)
        {
            using (var context = new RestauranteEntities())
            {
                try
                {
                    pedido peditem = buscarPedido(codigo);
                    context.Entry(peditem).State = System.Data.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al eliminar pedido" + ex.Message);
                }
            }
        }*/


    }
}
