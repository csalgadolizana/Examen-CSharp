using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaSQL;

namespace vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUser = txtUser.Text;
                string contra = txtPass.Text;
                DAOUsuario usuarioDAO = new DAOUsuario();
                usuario user = usuarioDAO.login(nombreUser, contra);
                if (user != null)
                {
                    LoginInfo.username = nombreUser;
                    LoginInfo.pass = contra;
                    LoginInfo.Tipo = user.tipo.Value;
                    MessageBox.Show("Bienvenido " + nombreUser);
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o clave incorrecta", "Uupps!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("err -> " + ex.Message);
                throw;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
