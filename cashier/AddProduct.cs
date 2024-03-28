using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace cashier
{
    public partial class AddProduct : Form
    {
        config con = new config();
        int id;
        public AddProduct()
        {
            InitializeComponent();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
            
            dgvProduk.Columns[0].Visible = false;
            this.Size = new Size(790, 420);
            
        }
        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.produkToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (tbProduk.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                con.query("INSERT INTO produk (nama) VALUES ('" + tbProduk.Text + "')");
                tbProduk.Clear();
                con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
            }
        }


        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.main.produkToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.query("DELETE FROM produk WHERE id_produk = " + id);
                    tbProduk.Clear();
                    con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
                }
                else
                {
                    con.kosongkanText(this);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("GAGAL");
            }
            
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk WHERE nama LIKE '%" + t_cari.Text + "%'", dgvProduk);
            dgvProduk.Columns[0].Visible = false;
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbProduk.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
                return;
            }
            else
            {
                con.query("UPDATE produk SET nama = '" + tbProduk.Text + "' WHERE id_produk = " + id);
                tbProduk.Clear();
                con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
            }

        }

        private void dgvProduk_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvProduk.Rows[e.RowIndex];
            id = Convert.ToInt32(dr.Cells[0].Value);
            tbProduk.Text = dr.Cells[1].Value.ToString();
        }

        private void AddProduct_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void b_simpan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
