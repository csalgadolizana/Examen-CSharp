using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vista.Menu;
using BibliotecaSQL;

namespace vista
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            btnBackup.Hide();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            //this.Hide();
            //AgregarMenu agregarMenu = new AgregarMenu();
            //agregarMenu.Show();
            //this.Dispose();
            AgregarMenu agregarMenu = new AgregarMenu();
            panel.Controls.Clear();
            agregarMenu.TopLevel = false;
            agregarMenu.Parent = panel;
            agregarMenu.FormBorderStyle = FormBorderStyle.None;
            agregarMenu.Dock = DockStyle.Fill;
            agregarMenu.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblSesion.Text = LoginInfo.username;
            switch (LoginInfo.Tipo)
            {
                case 1:
                    pedidoToolStripMenuItem.Visible = false;
                    ventaToolStripMenuItem.Visible = false;
                    menuToolStripMenuItem.Visible = true;
                    //btnBackup.Show();
                    imgBackup.Show();
                    break;
                case 2:
                    pedidoToolStripMenuItem.Visible = true;
                    ventaToolStripMenuItem.Visible = true;
                    menuToolStripMenuItem.Visible = false;
                    //btnBackup.Hide();
                    imgBackup.Hide();
                    break;
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
            this.Dispose();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ModificarMenu lo = new ModificarMenu();
            //lo.Show();
            //this.Dispose();
            ModificarMenu lo = new ModificarMenu();
            panel.Controls.Clear();
            lo.TopLevel = false;
            lo.Parent = panel;
            lo.FormBorderStyle = FormBorderStyle.None;
            lo.Dock = DockStyle.Fill;
            lo.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ListarMenu lo = new ListarMenu();
            //lo.Show();
            //this.Dispose();
            ListarMenu listarMenu = new ListarMenu();
            panel.Controls.Clear();
            listarMenu.TopLevel = false;
            listarMenu.Parent = panel;
            listarMenu.FormBorderStyle = FormBorderStyle.None;
            listarMenu.Dock = DockStyle.Fill;
            listarMenu.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //agregarCliente agregarcliente = new agregarCliente();
            //agregarcliente.Show();
            //this.Dispose();
            agregarCliente agregarcliente = new agregarCliente();
            panel.Controls.Clear();
            agregarcliente.TopLevel = false;
            agregarcliente.Parent = panel;
            agregarcliente.FormBorderStyle = FormBorderStyle.None;
            agregarcliente.Dock = DockStyle.Fill;
            agregarcliente.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listarCliente lista = new listarCliente();
            //lista.Show();
            //this.Dispose();
            listarCliente lista = new listarCliente();
            panel.Controls.Clear();
            lista.TopLevel = false;
            lista.Parent = panel;
            lista.FormBorderStyle = FormBorderStyle.None;
            lista.Dock = DockStyle.Fill;
            lista.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //actualizarCliente actua = new actualizarCliente();
            //actua.Show();
            //this.Dispose();
            actualizarCliente actua = new actualizarCliente();
            panel.Controls.Clear();
            actua.TopLevel = false;
            actua.Parent = panel;
            actua.FormBorderStyle = FormBorderStyle.None;
            actua.Dock = DockStyle.Fill;
            actua.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //agregarPedido pe = new agregarPedido();
            //pe.Show();
            //this.Dispose();
            agregarPedido agregarPedido = new agregarPedido();
            panel.Controls.Clear();
            agregarPedido.TopLevel = false;
            agregarPedido.Parent = panel;
            agregarPedido.FormBorderStyle = FormBorderStyle.None;
            agregarPedido.Dock = DockStyle.Fill;
            agregarPedido.Show();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //actualizarPedido pe = new actualizarPedido();
            //pe.Show();
            //this.Dispose();
            actualizarPedido actualizarPedido = new actualizarPedido();
            panel.Controls.Clear();
            actualizarPedido.TopLevel = false;
            actualizarPedido.Parent = panel;
            actualizarPedido.FormBorderStyle = FormBorderStyle.None;
            actualizarPedido.Dock = DockStyle.Fill;
            actualizarPedido.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //listarPedido pe = new listarPedido();
            //pe.Show();
            //this.Dispose();
            listarPedido listarPedido = new listarPedido();
            panel.Controls.Clear();
            listarPedido.TopLevel = false;
            listarPedido.Parent = panel;
            listarPedido.FormBorderStyle = FormBorderStyle.None;
            listarPedido.Dock = DockStyle.Fill;
            listarPedido.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //agregarVenta pe = new agregarVenta();
            //pe.Show();
            //this.Dispose();
            agregarVenta agregarVenta = new agregarVenta();
            panel.Controls.Clear();
            agregarVenta.TopLevel = false;
            agregarVenta.Parent = panel;
            agregarVenta.FormBorderStyle = FormBorderStyle.None;
            agregarVenta.Dock = DockStyle.Fill;
            agregarVenta.Show();
        }

        private void imgBackup_Click(object sender, EventArgs e)
        {
            Service_Venta_BackUp.NewWebServiceClient ws = new Service_Venta_BackUp.NewWebServiceClient();
            DaoVenta dv = new DaoVenta();
            List<Service_Venta_BackUp.ventasBackup> listVentasRespadadas = ws.listarVentas().ToList();
            List<venta> listVen = dv.listaVentas();
            foreach (venta item in listVen)
            {
                //int val = ws.buscarVenta(item.id_venta);
                int val = listVentasRespadadas.Find(x => x.idRes.ToString() == item.id_venta.ToString()) != null ? 1 : 0;
                if (val == 0)
                {
                    ws.crearVenta(item.id_venta, item.subtotal.Value, item.propina, item.total.Value, item.pedido_id.Value);
                    //MessageBox.Show("la venta no existe " + val);
                }
                else
                {
                    //MessageBox.Show("la venta existe " + val);
                }
            }
            MessageBox.Show("Fin del respado");
        }
    }
}
