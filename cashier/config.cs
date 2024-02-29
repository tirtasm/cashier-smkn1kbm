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
                db = "datasource=localhost;username=root;password=;database=kantin_sekolah"; 
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
        public MySqlDataReader tampil(string query)
        {
            MySqlDataReader hasil = null;
            try
            {
                cmd = new MySqlCommand(query, buka());
                hasil = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hasil;
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
        }


    }
}
