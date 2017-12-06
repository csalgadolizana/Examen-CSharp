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

namespace vista.Venta
{
    public partial class listarVenta : Form
    {
        public listarVenta()
        {
            InitializeComponent();
            initLis();
        }

        private void initLis()
        {
            Service_Venta_BackUp.NewWebServiceClient ws = new Service_Venta_BackUp.NewWebServiceClient();
            DaoVenta dv = new DaoVenta();
            List<Service_Venta_BackUp.ventasBackup> listVentasRespadadas = ws.listarVentas().ToList();
            List<venta> listVen = dv.listaVentas();

            dtgvVenta.Columns.Clear();
            dtgvVenta.DefaultCellStyle.ForeColor = Color.Black;
            dtgvVenta.ColumnCount = 5;
            dtgvVenta.Columns[0].Name = "ID venta";
            dtgvVenta.Columns[1].Name = "ID pedido";
            dtgvVenta.Columns[2].Name = "Total";
            dtgvVenta.Columns[3].Name = "ID pedido";
            dtgvVenta.Columns[4].Name = "Esta respaldado";
            string[] row = new string[] { "idventa", "idpedido", "total", "idpedido", "estado" };
            DaoVenta DaoVent = new DaoVenta();
            List<venta> listadoVent = DaoVent.listaVentas().ToList();
            foreach (var item in listadoVent)
            {
                string esRespaldado = listVentasRespadadas.Find(x => x.idRes.ToString() == item.id_venta.ToString()) != null ? "Respaldada" : "Pendiente";
                //cliente cli = DaoVent.buscarCliente(int.Parse(item.cliente_id.ToString()));
                row = new string[] {
                    item.id_venta.ToString(),
                    item.pedido_id.ToString(),
                    "$ "+item.total.ToString(),
                    item.pedido_id.ToString(),
                    esRespaldado
                };
                dtgvVenta.Rows.Add(row);
            }
            Commons.anchoColumna(dtgvVenta);
        }


        
            //foreach (venta item in listVen)
            //{
            //    //int val = ws.buscarVenta(item.id_venta);
            //    int val = listVentasRespadadas.Find(x => x.idRes.ToString() == item.id_venta.ToString()) != null ? 1 : 0;
            //    if (val == 0)
            //    {
            //        ws.crearVenta(item.id_venta, item.subtotal.Value, item.propina, item.total.Value, item.pedido_id.Value);
            //        //MessageBox.Show("la venta no existe " + val);
            //    }
            //    else
            //    {
            //        //MessageBox.Show("la venta existe " + val);
            //    }
            //}
            //MessageBox.Show("Fin del respado");
    }
}
