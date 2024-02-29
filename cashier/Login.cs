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
            config conn = new config();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check koneksi ke database kirim pesan jika sudah terkoneksi
            conn.buka();
            MySqlConnection connection = conn.buka();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM petugas WHERE username = '" + tbUser.Text + "' AND password = '" + tbPass.Text + "'";
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

        /*private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            
        }*/



        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            //jika tombol enter ditekan maka akan pindah ke textbox password
            if (e.KeyCode == Keys.Enter)
            {
                tbPass.Focus();
            }
            

        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //form login close dan membuka form register
            Hide();
            register register = new register();
            register.Show();
        }
    }

}
