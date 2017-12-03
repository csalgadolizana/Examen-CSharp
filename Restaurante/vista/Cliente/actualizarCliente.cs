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
    public partial class actualizarCliente : Form
    {
        public actualizarCliente()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtRut.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cliente cliente = new cliente();
            ClienteDAO clienteDAO = new ClienteDAO();
            if(txtCodigo.Text!="")
              {

                cliente = clienteDAO.buscarCliente(int.Parse(txtCodigo.Text));
                if (cliente != null)
                {
                    txtCodigo.Text = cliente.id_cliente.ToString();
                    txtNombre.Text = cliente.nombre;
                    txtRut.Text = cliente.rut;
                    MessageBox.Show("Encontró :)", "Encontrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    txtCodigo.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No Encontró", "No Encontrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }

            }

            else {
                MessageBox.Show("Debe ingresar Codigo", "Ingrese Codigo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text!="" && txtNombre.Text!="" && txtRut.Text!="")
            {
                cliente cliente = new cliente();
                cliente.id_cliente = int.Parse(txtCodigo.Text);
                cliente.nombre = txtNombre.Text;
                cliente.rut = txtRut.Text;
                ClienteDAO clienteDao = new ClienteDAO();
                if (clienteDao.editarCliente(cliente))
                {
                    MessageBox.Show("Modificó :)", "Modifico", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    txtCodigo.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("No modifico", "No modifico", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }

            }

            else
            {

                MessageBox.Show("Debe ingresar Codigo", "Ingrese Codigo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            
        }
    }
}
