using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cashier
{
    public partial class register : Form
    {
        config conn = new config();
        public register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbPass.Text == "" || tbHp.Text == "" || tbAlamat.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
                return;
            }
            conn.query("INSERT INTO petugas (username, password, no_telp, alamat) VALUES ('" + tbUser.Text + "','" + tbPass.Text + "','" + tbHp.Text + "','" + tbAlamat.Text + "')");
            MessageBox.Show("Registrasi Berhasil");
            conn.kosongkanText(this);


        }
    }
}
