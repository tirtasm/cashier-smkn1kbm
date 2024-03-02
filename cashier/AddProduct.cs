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


namespace cashier
{
    public partial class AddProduct : Form
    {
        private mainmenu mainMenu;
            config con = new config();
        int id = 0;
        public AddProduct(mainmenu mainMenu = null)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }


        private void Product_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT * FROM produk", dgvProduk);
        }
        private void b_exit_Click(object sender, EventArgs e)
        {
            mainMenu.Enabled = true;
            this.Close();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            con.query("INSERT INTO produk (nama) VALUES ('" + tbProduk.Text + "')");
            con.tampil("SELECT * FROM produk",dgvProduk);
        }
        

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Enabled = true;
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            if(id != 0)
            {
                con.query("DELETE FROM produk WHERE id_produk= '" + id + "'");
                tbProduk.Clear();
                con.tampil("SELECT * FROM produk", dgvProduk);
            }
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvProduk.Rows[e.RowIndex];
            id = (int)dr.Cells[0].Value;
            tbProduk.Text = dr.Cells[1].Value.ToString();
            
        }
    }
}
