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
    public partial class listarPedido : Form
    {
        public listarPedido()
        {
            InitializeComponent();
            initLis();
        }


        private void initLis()
        {
            dtgvPedido.Columns.Clear();
            dtgvPedido.DefaultCellStyle.ForeColor = Color.Black;
            dtgvPedido.ColumnCount = 5;
            dtgvPedido.Columns[0].Name = "ID Pedido";
            dtgvPedido.Columns[1].Name = "Descripcion";
            dtgvPedido.Columns[2].Name = "ID Cliente";
            dtgvPedido.Columns[3].Name = "Nombre Cliente";
            dtgvPedido.Columns[4].Name = "Rut Cliente";
            string[] row = new string[] { "idpedido", "descripcion", "idcliente", "nombrecliente","rut" };
            pedido cliente = new pedido();
            pedidoDAO daoPedido = new pedidoDAO();
            List<pedido> listadoPedido = daoPedido.listaPedido().ToList();
            ClienteDAO clienteDAO = new ClienteDAO();
            foreach (var item in listadoPedido)
            {
                cliente cli = clienteDAO.buscarCliente(int.Parse(item.cliente_id.ToString()));
                row = new string[] {
                    item.id_pedido.ToString(),
                    item.descripcion,
                    item.cliente_id.ToString(),
                    cli.nombre,
                    cli.rut
                };
                dtgvPedido.Rows.Add(row);
            }
            Commons.anchoColumna(dtgvPedido);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu mainMenu = new FormMenu();
            mainMenu.Show();
            this.Dispose();
        }

        private void dtgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
