using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cashier
{
    public partial class AddSupplier : Form
    {
            config conn = new config();
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            
                /*conn.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbHp.Text + "')");*/
                /*conn.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbHp.Text + "')");*/
            MessageBox.Show("Data Berhasil Disimpan");
            
            conn.kosongkanText(this);
            /*conn.tampil("SELECT nama FROM supplier", dgvSupplier);*/
        }

        private void b_exit_Click(object sender, EventArgs e)
        {

        }

        private void AddSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*mainmenu mainmenu = new mainmenu();
            mainmenu.Enabled = true;*/
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            /*conn.tampil("SELECT nama, no_telp, alamat FROM supplier", dgvSupplier);*/
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            /*conn.tampil("SELECT * FROM supplier WHERE no_telp or nama LIKE '%" + tbCari.Text + "%'", dgvSupplier);*/

        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
