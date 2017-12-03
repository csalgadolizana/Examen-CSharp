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
    public partial class agregarCliente : Form
    {
        public agregarCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtRut.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliente cliente = new cliente();
            cliente.nombre =txtNombre.Text;
            cliente.rut = txtRut.Text;
            ClienteDAO ClienteDAO = new ClienteDAO();

            if (txtNombre.Text != "" && txtRut.Text != "")
            {
                if (ClienteDAO.ingresarCliente(cliente))
                {
                    MessageBox.Show("Guardo :)", "Agrego", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("No guardo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }

            else {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

    }
}
