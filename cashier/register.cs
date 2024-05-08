using Org.BouncyCastle.Bcpg.Sig;
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
            //jika nomor hp depannya tidak +62 dan 08 maka akan muncul peringatan 

            if (tbUser.Text == "" || tbPass.Text == "" || tbHp.Text == "" || tbAlamat.Text == "" || tbRetype.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            else if (tbHp.Text.Length < 11)
            {
                MessageBox.Show("Nomor HP harus lebih dari 11 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!tbHp.Text.StartsWith("+62") && !tbHp.Text.StartsWith("08"))
            {
                
                MessageBox.Show("Nomor HP harus diawali dengan +62 atau 08", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            conn.query("INSERT INTO petugas (username, password, no_telp, alamat) VALUES ('" + tbUser.Text + "','" + tbPass.Text + "','" + tbHp.Text + "','" + tbAlamat.Text + "')");
            MessageBox.Show("Registrasi Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
            Hide();
            conn.kosongkanText(this);
                return;
            }
            else
            {
                MessageBox.Show("Registrasi Gagal.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Terjadi masalah pada koneksi database.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            


        }

        private void tbHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            //text harus lebih dari 6 karakter
            if (tbPass.Text.Length < 6)
            {
                errorProvider1.SetError(tbPass, "Password harus lebih dari 6 karakter");
                btnRegis.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnRegis.Enabled = true;
            }
        }

        private void tbRetype_TextChanged(object sender, EventArgs e)
        {
            if (tbPass.Text != tbRetype.Text)
            {
                errorProvider1.SetError(tbRetype, "Password Harus Sama");
                btnRegis.Enabled= false;
            }
            else
            {
                errorProvider1.Clear();
                btnRegis.Enabled= true;
            }
        }

        private void register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
