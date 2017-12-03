using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL
{
    public class DAOUsuario
    {
        public usuario login(string usname, string pass)
        {
            try
            {
                using (var context = new RestauranteEntities())
                {
                    usuario us = new usuario();
                    us = context.usuario.First(x => x.username.Equals(usname.Trim()) && x.password.Equals(pass.Trim()));
                    return us;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
