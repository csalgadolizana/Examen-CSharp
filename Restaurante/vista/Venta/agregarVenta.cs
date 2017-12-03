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
    public partial class agregarVenta : Form
    {
        int[] listaPedido = new int[99];
        public agregarVenta()
        {
            InitializeComponent();

            pedidoDAO pedidoDao = new pedidoDAO();
            int i = 0;
            List<pedido> list = pedidoDao.listaPedido();
            cboIdPedido.Items.Clear();
            foreach (pedido item in list)
            {
                cboIdPedido.Items.Insert(i, item.id_pedido);
                listaPedido[i] = item.id_pedido;
                i++;
            }
            cboIdPedido.SelectedIndex = 0;

            txtTotal.ReadOnly = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu mainMenu = new FormMenu();
            mainMenu.Show();
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                mensaje = "Solo debe ingresar numeros en el total";
                int.Parse(txtSubtotal.Text);
                mensaje = "Solo debe ingresar numeros en la propina";
                int.Parse(txtPropina.Text);
                if (txtPropina.Text.Trim() != "" && txtSubtotal.Text.Trim() != "")
                {
                    venta venta = new venta();
                    venta.subtotal = int.Parse(txtSubtotal.Text);
                    venta.propina = int.Parse(txtPropina.Text);
                    venta.total = int.Parse(txtSubtotal.Text) + int.Parse(txtPropina.Text);
                    txtTotal.Text = venta.total.ToString();
                    venta.pedido_id = listaPedido[cboIdPedido.SelectedIndex];
                    venta.fecha_venta = DateTime.Now;
                    DaoVenta daoVenta = new DaoVenta();
                    if (daoVenta.ingresoVenta(venta))
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
                    //MessageBox.Show("Llene todo", "No Guardo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    mensaje = "Debe llenar los datos solicitados";
                    MessageBox.Show("Error\n" + mensaje);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error\n" + mensaje);
            }

        }

    }
}
