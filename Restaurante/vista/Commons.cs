using System.Windows.Forms;

namespace vista
{
    public static class Commons
    {

        public static void anchoColumna(DataGridView dt)
        {
            dt.ReadOnly = true;
            int resto = 38 / dt.Columns.Count;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].Width = (dt.Width / dt.Columns.Count) - resto;
            }
        }
    }
}
