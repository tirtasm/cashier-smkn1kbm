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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace cashier
{
    public partial class Supplier : Form
    {
            config con = new config();
        public Supplier()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            /*con.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbHp.Text + "')");*/
            MessageBox.Show("Data Berhasil Disimpan");
        }
        private void cmbSupp() 
        {
            string query = "SELECT nama FROM supplier ";
            MySqlCommand cmd = new MySqlCommand(query, con.buka());
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbSupplier.Items.Add(reader.GetString("nama"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbProduk()
        {
            string query = "SELECT nama FROM produk";
            MySqlCommand cmd = new MySqlCommand(query, con.buka());
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbProduk.Items.Add(reader.GetString("nama"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbPetugas()
        {
            string query = "SELECT username FROM petugas";
            MySqlCommand cmd = new MySqlCommand(query, con.buka());
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbPetugas.Items.Add(reader.GetString("username"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT * FROM detail_supplier", dgvAddSupplier);
            cmbSupp();
            cmbProduk();
            cmbPetugas();
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
            string query = "INSERT INTO detail_supplier (id_supplier, id_produk, id_petugas, harga, stok) VALUES (@idSupplier, @idProduk, @idPetugas, @harga, @stok)";

            using (MySqlCommand cmd = new MySqlCommand(query, con.buka()))
            {
                cmd.Parameters.AddWithValue("@idSupplier", cbSupplier.SelectedIndex.ToString());
                cmd.Parameters.AddWithValue("@idProduk", cbProduk.SelectedIndex.ToString());
                cmd.Parameters.AddWithValue("@idPetugas", cbPetugas.SelectedIndex.ToString());
                cmd.Parameters.AddWithValue("@harga", tbHarga.Text);
                cmd.Parameters.AddWithValue("@stok", tbStok.Text);

                // Hapus perintah ini karena koneksi sudah dibuka di constructor MySqlCommand
                // con.buka();

                cmd.ExecuteNonQuery();
            }

        }
    }
}
    