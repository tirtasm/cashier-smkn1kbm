using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace cashier
{
    public partial class Supplier : Form
    {
        config con = new config();
        int lastId;
        private mainmenu mainMenu;
        public Supplier(mainmenu mainMenu = null)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;   
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            /*con.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbHp.Text + "')");*/
            MessageBox.Show("Data Berhasil Disimpan");
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT * FROM supplier", dgvAddSupplier);
            cmbSupp();
            cmbProduk();
            cmbPetugas();
            con.kosongkanText(this);

        }
        private void cmbSupp()
        {
            //menampilkan data dari database ke combobox
            con.buka();
            string query = "SELECT * FROM supplier";
            MySqlCommand cmd = new MySqlCommand(query, con.buka());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSupplier.DataSource = dt;
            cbSupplier.DisplayMember = "nama";
            cbSupplier.ValueMember = "id_supplier";
            con.tutup();

        }
        private void cmbProduk()
        {
            //menampilkan data dari database ke combobox
            con.buka();
            string query = "SELECT * FROM produk";
            MySqlCommand cmd = new MySqlCommand(query, con.buka());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProduk.DataSource = dt;
            cbProduk.DisplayMember = "nama";
            cbProduk.ValueMember = "id_produk";
            con.tutup();
        }
        private void cmbPetugas()
        {
            con.buka();
            string query = "SELECT * FROM petugas";
            MySqlCommand cmd = new MySqlCommand(query, con.buka());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbPetugas.DataSource = dt;
            cbPetugas.DisplayMember = "username";
            cbPetugas.ValueMember = "id_petugas";
            con.tutup();
        }
        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (cbSupplier.Text == "" || cbProduk.Text == "" || cbPetugas.Text == "" || tbHarga.Text == "" || tbStok.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
                return;
            }
            else
            {

                con.query("INSERT INTO transaksi_supplier (tanggal, id_supplier, id_petugas) VALUES ('" + dtSupplier.Value.ToString("yyyy-MM-dd") + "', '" + cbSupplier.SelectedValue + "', '" + cbPetugas.SelectedValue + "')");
                lastId = con.getLastId("SELECT id_transaksi_supplier FROM transaksi_supplier ORDER BY id_transaksi_supplier DESC LIMIT 1");
                con.query("INSERT INTO detail_supplier (id_transaksi_supplier, id_produk, harga, stok) VALUES ('" + lastId + "', '" + cbProduk.SelectedValue + "', '" + tbHarga.Text + "', '" + tbStok.Text + "')");
                

                int jumlah = int.Parse(tbHarga.Text) * int.Parse(tbStok.Text);
                con.query("UPDATE detail_supplier SET jumlah = '" + jumlah + "' WHERE id_transaksi_supplier = '" + lastId + "'");
                MessageBox.Show("Data Berhasil Disimpan");
                con.kosongkanText(this);
            }
        }

        private void cbProduk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            
            mainMenu.Enabled = true;
            this.Close();
        }
    }
}
