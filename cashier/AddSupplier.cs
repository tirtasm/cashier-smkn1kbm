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
        config con = new config();
        int id;
        private mainmenu mainMenu;
        public AddSupplier()
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            con.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbTelp.Text + "')");
            MessageBox.Show("Data Berhasil Disimpan");

            con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
            con.kosongkanText(this);
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.supplierToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void AddSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*mainmenu mainmenu = new mainmenu();
            mainmenu.Enabled = true;*/
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
            this.Size = new Size(840, 440);
            dgvSupplier.Columns[0].Visible = false;
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            /*conn.tampil("SELECT * FROM supplier WHERE no_telp or nama LIKE '%" + tbCari.Text + "%'", dgvSupplier);*/

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.query("DELETE FROM supplier WHERE id_supplier= " + id);
            con.kosongkanText(this);
            con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.query("UPDATE supplier SET nama = '" + tbNama.Text + "', alamat='" + tbAlamat.Text + "', no_telp='" + tbTelp.Text + "' WHERE id_supplier = " + id);
            con.kosongkanText(this);
            con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
        }
        private void tbTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        private void tbCari_TextChanged_1(object sender, EventArgs e)
        {
            con.tampil("SELECT * FROM supplier WHERE nama LIKE '%" +tbCari.Text +"%'", dgvSupplier);
        }
        private void dgvSupplier_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow dr = dgvSupplier.Rows[e.RowIndex];
                id = Convert.ToInt32(dr.Cells[0].Value);
                tbNama.Text = dr.Cells[1].Value.ToString();
                tbTelp.Text = dr.Cells[2].Value.ToString();
                tbAlamat.Text = dr.Cells[3].Value.ToString();
            
        }
    }
}
