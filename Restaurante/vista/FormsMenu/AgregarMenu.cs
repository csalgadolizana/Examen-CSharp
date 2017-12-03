using BibliotecaSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class AgregarMenu : Form
    {
        public AgregarMenu()
        {
            InitializeComponent();
        }

        private void bntCrear_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                menu men = new menu();
                men.descripcion = txtDesc.Text.Trim();
                men.precio = int.Parse(txtPrecio.Text.Trim());
                try
                {
                    DAOMenu dAOMenu = new DAOMenu();
                    dAOMenu.ingresoMenu(men);
                    msj = "Aviso\nCorrecta creacion de menu";
                }
                catch (Exception ex)
                {
                    msj = "Error\n" + ex.Message;
                }
            }
            catch (Exception exx)
            {
                msj = "Error\n" + exx.Message;
                msj = "Error\nEn el precio solo puede ingresar numeros";
            }
            MessageBox.Show(msj);
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            txtPrecio.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu mainMenu = new FormMenu();
            mainMenu.Show();
            this.Dispose();
        }
    }
}
