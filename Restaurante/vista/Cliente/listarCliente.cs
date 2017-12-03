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
    public partial class listarCliente : Form
    {
        public listarCliente()
        {
            InitializeComponent();
            initLis();
        }

        private void initLis()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "ID Cliente";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Rut";
            string[] row = new string[] { "id", "nombre", "rut" };
            cliente cliente = new cliente();
            ClienteDAO daoCliente = new ClienteDAO();
            List<cliente> listadoClientes = daoCliente.listaCliente().ToList();
            foreach (var item in listadoClientes)
            {
                    row = new string[] {
                    item.id_cliente.ToString(),
                    item.nombre,
                    item.rut.ToString()
                };
                dataGridView1.Rows.Add(row);
            }
            Commons.anchoColumna(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
