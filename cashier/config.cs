using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Windows.Forms;
=======
>>>>>>> 988a070edf3bda57943c4c1fc1ad65fa81d6c395

namespace cashier
{
    internal class config
    {
<<<<<<< HEAD
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

=======
>>>>>>> 988a070edf3bda57943c4c1fc1ad65fa81d6c395

    }
}
