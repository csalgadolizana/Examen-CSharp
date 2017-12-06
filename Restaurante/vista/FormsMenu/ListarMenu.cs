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
    public partial class ListarMenu : Form
    {
        public ListarMenu()
        {
            InitializeComponent();
            initLis();
        }

        private void initLis()
        {
            dtgMenus.Columns.Clear();
            dtgMenus.DefaultCellStyle.ForeColor = Color.Black;
            dtgMenus.ColumnCount = 3;
            dtgMenus.Columns[0].Name = "ID Menu";
            dtgMenus.Columns[1].Name = "Descripcion";
            dtgMenus.Columns[2].Name = "Precios";
            string[] row = new string[] { "id", "descripcion", "precio" };
            menu men = new menu();
            DAOMenu dAOMenu = new DAOMenu();
            List<menu> listadoMenus = dAOMenu.listaMenus().ToList();
            foreach (var item in listadoMenus)
            {
                row = new string[] {
                    item.id_menu.ToString(),
                    item.descripcion,
                    item.precio.ToString()
                };
                dtgMenus.Rows.Add(row);
            }
            Commons.anchoColumna(dtgMenus);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu mainMenu = new FormMenu();
            mainMenu.Show();
            this.Dispose();
        }

        private void dtgMenus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
