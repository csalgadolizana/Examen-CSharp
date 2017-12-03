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

namespace vista.Menu
{
    public partial class ModificarMenu : Form
    {
        public ModificarMenu()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                menu men = new menu();
                int id_men = int.Parse(txtId.Text.Trim());
                try
                {
                    DAOMenu dAOMenu = new DAOMenu();
                    men = dAOMenu.buscarMenu(id_men);
                    txtId.Enabled = false;
                    btnBuscar.Enabled = false;
                    txtDesc.Text = men.descripcion;
                    txtPrecio.Text = men.precio.ToString();
                    msj = "Aviso\nSe ha encontrado el menu";
                }
                catch (Exception ex)
                {
                    msj = "Error\n" + ex.Message;
                }
            }
            catch (Exception exx)
            {
                msj = "Error\n" + exx.Message;
                msj = "Error\nEn el id solo puede ingresar numeros";
            }
            MessageBox.Show(msj);
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu mainMenu = new FormMenu();
            mainMenu.Show();
            this.Dispose();
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            txtDesc.Text = "";
            txtPrecio.Text = "";
            txtId.Text = "";
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                menu men = new menu();
                txtId.Enabled = true;
                int id_men = int.Parse(txtId.Text.Trim());
                try
                {
                    DAOMenu dAOMenu = new DAOMenu();
                    men = dAOMenu.buscarMenu(id_men);
                    btnBuscar.Enabled = true;
                    men.descripcion = txtDesc.Text;
                    men.precio = int.Parse(txtPrecio.Text);
                    dAOMenu.editarMenu(men);
                    msj = "Aviso\nSe ha modificado el menu";
                }
                catch (Exception ex)
                {
                    msj = "Error\n" + ex.Message;
                }
            }
            catch (Exception exx)
            {
                msj = "Error\n" + exx.Message;
                msj = "Error\nEn el id y precio solo puede ingresar numeros";
            }
            MessageBox.Show(msj);
        }
    }
}
