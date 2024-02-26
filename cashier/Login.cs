using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace cashier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            //check koneksi ke database kirim pesan jika sudah terkoneksi
            config conn = new config();
            conn.buka();
            MySqlConnection connection = conn.buka();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM petugas WHERE nama = '" + tbUser.Text + "' AND password = '" + tbPass.Text + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Login Berhasil");
                Hide();
                mainmenu mainmenu = new mainmenu();
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
            conn.tutup();
}
=======

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            
        }
>>>>>>> 988a070edf3bda57943c4c1fc1ad65fa81d6c395


        
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
