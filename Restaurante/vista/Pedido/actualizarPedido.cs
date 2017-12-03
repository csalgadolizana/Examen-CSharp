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

    public partial class actualizarPedido : Form
    {
        int[] idlistaPedido = new int[99];
        public actualizarPedido()
        {
            InitializeComponent();
            ClienteDAO pediDao = new ClienteDAO();
            int i = 0;
            List<cliente> list = pediDao.listaCliente();
            cboCliente.Items.Clear();
            foreach (cliente item in list)
            {
                cboCliente.Items.Insert(i, item.nombre);
                idlistaPedido[i] = item.id_cliente;
                i++;
            }
            cboCliente.SelectedIndex = 0;
            btnEliminar.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedidoDAO pedidoDAO = new pedidoDAO();

            if (txtId.Text != "")
            {
                pedido = pedidoDAO.buscarPedido(int.Parse(txtId.Text));
                if (pedido != null)
                {
                    txtId.Text = pedido.cliente_id.ToString();
                    txtDescripcion.Text = pedido.descripcion;
                    cboCliente.SelectedIndex = pedido.id_pedido - 1;

                    MessageBox.Show("Encontró :)", "Encontro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("No Encontró", "No Encontro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }

            else
            {

                MessageBox.Show("Debe ingresar Codigo", "Ingrese Codigo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Dispose();
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            cboCliente.SelectedIndex = 0;
            txtId.Text = "";
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtDescripcion.Text != "")
            {
                pedido pedi = new pedido();
                pedi.id_pedido = int.Parse(txtId.Text);
                pedi.descripcion = txtDescripcion.Text;
                pedi.cliente_id = idlistaPedido[cboCliente.SelectedIndex];

                pedidoDAO pediDAO = new pedidoDAO();
                if (pediDAO.actualizarPedido(pedi))
                {
                    MessageBox.Show("Modificó :)", "Modifico", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No Modifico", "No Modifico", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }

            else
            {
                MessageBox.Show("Debe ID y Descripcion", "Ingrese ID y Descripcion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedidoDAO pedidoDAO = new pedidoDAO();
            /* if (pedidoDAO.eliminarPedido(int.Parse(txtId.Text)))
             {
                 //btnEliminar.Hide();
                 MessageBox.Show("Elimino:)", "Elimino", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
             }
             else
             {
                 MessageBox.Show("No Elimino", "No Elimino", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
             }*/
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
