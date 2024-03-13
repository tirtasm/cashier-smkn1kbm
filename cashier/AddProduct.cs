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
        private mainmenu mainMenu;
        config con = new config();
        
        int id;
        public AddProduct(mainmenu mainMenu = null)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }


        private void Product_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
        }
        private void b_exit_Click(object sender, EventArgs e)
        {
            mainMenu.Enabled = true;
            this.Close();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            con.query("INSERT INTO produk (nama) VALUES ('" + tbProduk.Text + "')");
            tbProduk.Clear();
            con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
        }


        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Enabled = true;
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
            con.query("DELETE FROM produk WHERE id_produk = " + id);
            tbProduk.Clear();
            con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);
            }
            catch (Exception x)
            {
                MessageBox.Show("GAGAL");
            }
            
        }
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvProduk.Rows[e.RowIndex];
            id = Convert.ToInt32(dr.Cells[0].Value);
            tbProduk.Text = dr.Cells[1].Value.ToString();
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            con.tampil("SELECT * FROM produk WHERE nama LIKE '%" + t_cari.Text + "%'", dgvProduk);
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            
            con.query("UPDATE produk SET nama = '" + tbProduk.Text + "' WHERE id_produk = " + id);
            tbProduk.Clear();
            con.tampil("SELECT id_produk as No, nama as NamaProduk FROM produk", dgvProduk);

        }

        private void tbProduk_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                b_simpan.PerformClick();
            }*/
        }
    }
}
