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
            if(tbPass.Text == "" || tbUser.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (reader.Read())
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                mainmenu mainmenu = new mainmenu();
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.tutup();
}

        /*private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            
        }*/


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            //jika tombol enter ditekan maka akan pindah ke textbox password
            if(e.KeyCode == Keys.Enter)
            {
                tbPass.Focus();
            }


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //form login close dan membuka form register
            Hide();
            register register = new register();
            register.Show();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }
    }

}
