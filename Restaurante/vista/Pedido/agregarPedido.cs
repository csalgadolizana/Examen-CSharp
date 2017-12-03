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
    public partial class agregarPedido : Form
    {
        int[] listaPedido = new int[99];
        public agregarPedido()
        {
            InitializeComponent();
            ClienteDAO pediDao = new ClienteDAO();
            int i = 0;
            List<cliente> list = pediDao.listaCliente();
            cboCliente.Items.Clear();
            foreach (cliente item in list)
            {
                cboCliente.Items.Insert(i, item.nombre);
                listaPedido[i] = item.id_cliente;
                i++;
            }
            cboCliente.SelectedIndex = 0;


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            cboCliente.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text != "")
            {
                pedido pedido = new pedido();

                pedido.descripcion = txtDescripcion.Text;
                pedido.cliente_id = listaPedido[cboCliente.SelectedIndex];
                pedidoDAO pediDAO = new pedidoDAO();
                if (pediDAO.agregarPedido(pedido))
                {
                    MessageBox.Show("Guardo :)", "Guardo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No guardo", "No Guardo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }

            }

            else
            {
                MessageBox.Show("Debe ingresar descripcion", "Ingrese Descripcion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }

        }
    }
}
