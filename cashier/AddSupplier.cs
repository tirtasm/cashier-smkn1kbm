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
            if (!tbTelp.Text.StartsWith("+62") && !tbTelp.Text.StartsWith("08"))
            {
                MessageBox.Show("Nomor HP harus diawali dengan +62 atau 08", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (tbTelp.Text.Length < 11)
            {
                MessageBox.Show("Nomor HP harus lebih dari 11 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbAlamat.Text == "" || tbNama.Text == "" || tbTelp.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                con.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbTelp.Text + "')");
                MessageBox.Show("Data Berhasil Disimpan");

                con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
                con.kosongkanText(this);
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.supplierToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void AddSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.main.supplierToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
            this.Size = new Size(840, 440);
            dgvSupplier.Columns[0].Visible = false;
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.query("DELETE FROM supplier WHERE id_supplier = " + id);
                con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
                con.kosongkanText(this);
            }
            else
            {
                con.kosongkanText(this);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!tbTelp.Text.StartsWith("+62") && !tbTelp.Text.StartsWith("08"))
            {
                MessageBox.Show("Nomor HP harus diawali dengan +62 atau 08", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (tbTelp.Text.Length < 11)
            {
                MessageBox.Show("Nomor HP harus lebih dari 11 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbAlamat.Text == "" || tbNama.Text == "" || tbTelp.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
                return;
            }
            else
            {
                con.query("UPDATE supplier SET nama = '" + tbNama.Text + "', alamat='" + tbAlamat.Text + "', no_telp='" + tbTelp.Text + "' WHERE id_supplier = " + id);
                con.kosongkanText(this);
                con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier", dgvSupplier);
            }
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
            con.tampil("SELECT id_supplier as No, nama as Nama, no_telp as NoTelp, alamat as Alamat FROM supplier WHERE Nama LIKE '%"+tbCari.Text+"%'", dgvSupplier);
            dgvSupplier.Columns[0].Visible = false;
        }
        private void dgvSupplier_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvSupplier.Rows[e.RowIndex];
            id = int.Parse(dr.Cells[0].Value.ToString());
            tbNama.Text = dr.Cells[1].Value.ToString();
            tbTelp.Text = dr.Cells[2].Value.ToString();
            tbAlamat.Text = dr.Cells[3].Value.ToString();
        }
    }
}
