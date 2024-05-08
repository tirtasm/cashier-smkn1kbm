using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;




namespace cashier
{
    internal class config
    {

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        string db;


        // open connection mysql
        public MySqlConnection buka()
        {
            try
            {
                
                db = "datasource=localhost;username=root;password=0000;database=kantinv2"; 
                conn = new MySqlConnection(db);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;

        }
        public MySqlConnection tutup()
        {
            db = null;
            conn.Close();
            return conn;
        }
        public bool query(string query)
        {
            bool hasil = false;
            try
            {
                cmd = new MySqlCommand(query, buka());
                cmd.ExecuteNonQuery();
                tutup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
     
        public void tampil(string query, DataGridView dgv)
        {
            cmd = new MySqlCommand(query, buka());
            da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.ReadOnly = true;
            dgv.Refresh();
        }
        
        public void kosongkanText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    kosongkanText(c);
                }
            }
            foreach (Control c in con.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else
                {
                    kosongkanText(c);
                }
            }
        }
        //getLastId for auto increment id
        public int getLastId(string query)
        {
            int id = 0;
            cmd = new MySqlCommand(query, buka());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
    
        public void exportToExcel(DataGridView dgv, string path)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                excel.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        excel.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            excel.Columns.AutoFit();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = excel.ActiveSheet;
            worksheet.SaveAs(path);
        }
    }
}
