using System;

using System.Data;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
    
namespace cashier
{
    public partial class Supplier : Form
    {
        config con = new config();
        int lastIdSup;
        int idSup;
        int idTrx;
        private mainmenu mainMenu;
        
      
        
        public Supplier()
        {
            InitializeComponent();
            
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT transaksi_supplier.id_transaksi_supplier, detail_supplier.id_detail_supplier, transaksi_supplier.tanggal AS Tanggal, petugas.username AS Petugas, supplier.nama AS NamaSupplier, produk.nama AS Produk, detail_supplier.harga AS HargaSatuan, detail_supplier.stok AS Stok, detail_supplier.jumlah AS Jumlah FROM detail_supplier" +
                    " JOIN transaksi_supplier ON transaksi_supplier.id_transaksi_supplier = detail_supplier.id_transaksi_supplier JOIN petugas ON petugas.id_petugas = transaksi_supplier.id_petugas JOIN supplier ON " +
                    "supplier.id_supplier = transaksi_supplier.id_supplier JOIN produk ON produk.id_produk = detail_supplier.id_produk;", dgvAddSupplier);
            cmbSupp();
            cmbProduk();
            cmbPetugas();
            con.kosongkanText(this);
            this.Size = new System.Drawing.Size(950, 480);
            
            dgvAddSupplier.Columns[0].Visible = false;
            dgvAddSupplier.Columns[1].Visible = false;

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

  

        private void cbProduk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.detailSupplierToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            con.tampil("SELECT transaksi_supplier.id_transaksi_supplier, detail_supplier.id_detail_supplier, transaksi_supplier.tanggal AS Tanggal, petugas.username AS Petugas, supplier.nama AS NamaSupplier, produk.nama AS Produk, detail_supplier.harga AS HargaSatuan, detail_supplier.stok AS Stok, detail_supplier.jumlah AS Jumlah FROM detail_supplier" +
                " JOIN transaksi_supplier ON transaksi_supplier.id_transaksi_supplier = detail_supplier.id_transaksi_supplier JOIN petugas ON petugas.id_petugas = transaksi_supplier.id_petugas JOIN supplier ON " +
                "supplier.id_supplier = transaksi_supplier.id_supplier JOIN produk ON produk.id_produk = detail_supplier.id_produk WHERE supplier.nama LIKE '%"+tbCari.Text+"%'", dgvAddSupplier);
        }

        public void Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                con.query("DELETE FROM transaksi_supplier WHERE `transaksi_supplier`.`id_transaksi_supplier` =" + idTrx);
                //con.query("DELETE FROM detail_supplier WHERE `detail_supplier`.`id_detail_supplier` =" + idSup);
                con.tampil("SELECT transaksi_supplier.id_transaksi_supplier, detail_supplier.id_detail_supplier, transaksi_supplier.tanggal AS Tanggal, petugas.username AS Petugas, supplier.nama AS NamaSupplier, produk.nama AS Produk, detail_supplier.harga AS HargaSatuan, detail_supplier.stok AS Stok, detail_supplier.jumlah AS Jumlah FROM detail_supplier" +
                   " JOIN transaksi_supplier ON transaksi_supplier.id_transaksi_supplier = detail_supplier.id_transaksi_supplier JOIN petugas ON petugas.id_petugas = transaksi_supplier.id_petugas JOIN supplier ON " +
                   "supplier.id_supplier = transaksi_supplier.id_supplier JOIN produk ON produk.id_produk = detail_supplier.id_produk;", dgvAddSupplier);
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
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
                lastIdSup = con.getLastId("SELECT id_transaksi_supplier FROM transaksi_supplier ORDER BY id_transaksi_supplier DESC LIMIT 1");
                con.query("INSERT INTO detail_supplier (id_transaksi_supplier, id_produk, harga, stok) VALUES ('" + lastIdSup + "', '" + cbProduk.SelectedValue + "', '" + tbHarga.Text + "', '" + tbStok.Text + "')");
                /*MessageBox.Show("\ntanggal" + dtSupplier.Value.ToString() + "\n suppleir" + cbSupplier.SelectedValue + "\n petugas" + cbPetugas.SelectedValue + "\n lastid" + lastId + "\n produk" + cbProduk.SelectedValue + "\n harga"+ tbHarga.Text + "\nstok" + tbStok.Text);*/

                int jumlah = int.Parse(tbHarga.Text) * int.Parse(tbStok.Text);
                con.query("UPDATE detail_supplier SET jumlah = '" + jumlah + "' WHERE id_transaksi_supplier = '" + lastIdSup + "'");
                con.query("UPDATE transaksi_supplier SET total_harga = '" + jumlah + "' WHERE id_transaksi_supplier = '" + lastIdSup + "'");
                MessageBox.Show("Data Berhasil Disimpan");
                con.kosongkanText(this);
                con.tampil("SELECT transaksi_supplier.id_transaksi_supplier, detail_supplier.id_detail_supplier,transaksi_supplier.tanggal AS Tanggal, petugas.username AS Petugas, supplier.nama AS NamaSupplier, produk.nama AS Produk, detail_supplier.harga AS HargaSatuan, detail_supplier.stok AS Stok, detail_supplier.jumlah AS Jumlah FROM detail_supplier" +
                    " JOIN transaksi_supplier ON transaksi_supplier.id_transaksi_supplier = detail_supplier.id_transaksi_supplier JOIN petugas ON petugas.id_petugas = transaksi_supplier.id_petugas JOIN supplier ON " +
                    "supplier.id_supplier = transaksi_supplier.id_supplier JOIN produk ON produk.id_produk = detail_supplier.id_produk;", dgvAddSupplier);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //update data transaksi supplier    
            con.query("UPDATE transaksi_supplier SET tanggal = '" + dtSupplier.Value.ToString("yyyy-MM-dd") + "', id_supplier= '" + cbSupplier.SelectedValue + "', id_petugas= '" + cbPetugas.SelectedValue + "' WHERE id_transaksi_supplier = '" + idTrx + "'");
            //update data detail supplier 
            con.query("UPDATE detail_supplier SET id_produk = '" + cbProduk.SelectedValue + "', harga = '" + tbHarga.Text + "', stok = '" + tbStok.Text + "' WHERE id_transaksi_supplier = '" + idTrx + "'");
            int jumlah = int.Parse(tbHarga.Text) * int.Parse(tbStok.Text);
            con.query("UPDATE detail_supplier SET jumlah = '" + jumlah + "' WHERE id_transaksi_supplier = '" + lastIdSup + "'");
            con.tampil("SELECT transaksi_supplier.id_transaksi_supplier, detail_supplier.id_detail_supplier, transaksi_supplier.tanggal AS Tanggal, petugas.username AS Petugas, supplier.nama AS NamaSupplier, produk.nama AS Produk, detail_supplier.harga AS HargaSatuan, detail_supplier.stok AS Stok, detail_supplier.jumlah AS Jumlah FROM detail_supplier" +
                    " JOIN transaksi_supplier ON transaksi_supplier.id_transaksi_supplier = detail_supplier.id_transaksi_supplier JOIN petugas ON petugas.id_petugas = transaksi_supplier.id_petugas JOIN supplier ON " +
                    "supplier.id_supplier = transaksi_supplier.id_supplier JOIN produk ON produk.id_produk = detail_supplier.id_produk;", dgvAddSupplier);
            MessageBox.Show("Data Berhasil Diedit", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.kosongkanText(this);
        }

        private void dgvAddSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //menampilkan data dari datagridview ke textbox, tanggal dan combobox
            DataGridViewRow row = dgvAddSupplier.Rows[e.RowIndex];
            idTrx = int.Parse(row.Cells[0].Value.ToString());
            idSup = int.Parse(row.Cells[1].Value.ToString());
            dtSupplier.Text = row.Cells[2].Value.ToString();
            cbPetugas.Text = row.Cells[3].Value.ToString();
            cbSupplier.Text = row.Cells[4].Value.ToString();
            cbProduk.Text = row.Cells[5].Value.ToString();
            tbHarga.Text = row.Cells[6].Value.ToString();
            tbStok.Text = row.Cells[7].Value.ToString();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            AddSupplier sup = new AddSupplier();
            sup.Show();
            Hide();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
           AddProduct prod = new AddProduct();
            prod.Show();
            Hide();
        }
    }
}
