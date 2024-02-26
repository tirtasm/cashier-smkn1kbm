using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                db = "datasource=localhost;username=root;password=;database=kantin"; 
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


    }
}
