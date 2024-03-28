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
    public partial class TransaksiPenjualan : Form
    {
        config con = new config();
        int idPen = 0;
        int idSup = 0;
        int idTrx = 0;
        private mainmenu mainMenu;
        public TransaksiPenjualan()
        {
            
            InitializeComponent();
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
        private void cmbProd()
        {
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

        private void TransaksiPenjualan_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT tp.id_transaksi_penjualan AS idTrx, dp.id_detail_penjualan, tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier;", dgvTrxPen);
            cmbSupp();
            cmbPetugas();
            cmbProd();
            cbStatus.Items.Add("Sudah Diambil");
            cbStatus.Items.Add("Belum Diambil");
            con.kosongkanText(this);
            this.Size = new Size(1030, 500);
            
            dgvTrxPen.Columns[0].Visible = false;
            dgvTrxPen.Columns[1].Visible = false;
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

        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.transaksiPenjualanToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                con.query("DELETE FROM transaksi_penjualan WHERE `transaksi_penjualan`.`id_transaksi_penjualan` =" + idTrx);
                //con.query("DELETE FROM detail_supplier WHERE `detail_supplier`.`id_detail_supplier` =" + idSup);
                con.tampil("SELECT tp.id_transaksi_penjualan AS idTrx, dp.id_detail_penjualan, tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier;", dgvTrxPen);
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                con.kosongkanText(this);
            }
        }

        public void dgvTrxPen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //menampilkan data dari datagridview ke textbox
            DataGridViewRow row = dgvTrxPen.Rows[e.RowIndex];
            idTrx = int.Parse(row.Cells[0].Value.ToString());
            idSup = int.Parse(row.Cells[1].Value.ToString());
            dtPen.Text = row.Cells[2].Value.ToString();
            cbPetugas.Text = row.Cells[3].Value.ToString();
            cbSupplier.Text = row.Cells[4].Value.ToString();
            cbProduk.Text = row.Cells[5].Value.ToString();
            tbHarga.Text = row.Cells[6].Value.ToString();
            tbStok.Text = row.Cells[7].Value.ToString();
            cbStatus.Text = row.Cells[10].Value.ToString();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //kondisi jika data kosong termasuk combobox maka akan muncul pesan error
            if (cbSupplier.Text == "" || cbPetugas.Text == "" || cbProduk.Text == "" || tbHarga.Text == "" || tbStok.Text == "" || cbStatus.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                con.query("INSERT INTO transaksi_penjualan (tanggal, id_supplier, id_petugas, id_produk, status) VALUES ('" + dtPen.Value.ToString("yyyy-MM-dd") + "', '" + cbSupplier.SelectedValue + "', '" + cbPetugas.SelectedValue + "', '" + cbProduk.SelectedValue + "' , '" + cbStatus.Text + "')");
                idPen = con.getLastId("SELECT id_transaksi_penjualan FROM transaksi_penjualan ORDER BY id_transaksi_penjualan DESC LIMIT 1");
                idSup = con.getLastId("SELECT id_transaksi_supplier FROM transaksi_supplier ORDER BY id_transaksi_supplier DESC LIMIT 1");
                con.query("INSERT INTO detail_penjualan (id_transaksi_penjualan, id_transaksi_supplier, harga_jual, stok_terjual) VALUES ('" + idPen + "','" + idSup + "', '" + tbHarga.Text + "', '" + tbStok.Text + "')");

                int total = int.Parse(tbHarga.Text) * int.Parse(tbStok.Text);
                int untungKantin = total * 10 / 100;
                //hitung untung supplier 
                int untungSupplier = total - untungKantin;
                con.query("UPDATE detail_penjualan SET total_penjualan = '" + total + "', keuntungan_kantin= '" + untungKantin + "'  WHERE id_transaksi_penjualan= '" + idPen + "'");
                con.query("UPDATE transaksi_penjualan SET total_penjualan ='" + total + "', keuntungan='" + untungSupplier + "' WHERE id_transaksi_penjualan = '" + idPen + "'");
                MessageBox.Show("Data Berhasil Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.kosongkanText(this);
                //MessageBox.Show("UNTUNG KANTIN: "+untungKantin + "\n Total : " + total + "\n UNTUNG SUPPLIER : " + untungSupplier);
                con.tampil("SELECT tp.id_transaksi_penjualan AS idTrx, dp.id_detail_penjualan, tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                    " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier;", dgvTrxPen);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (idTrx == 0 || idSup == 0)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbPetugas.Text == "" || cbProduk.Text == "" || cbStatus.Text == "" || cbSupplier.Text == "" || tbHarga.Text == "" || tbStok.Text == "")
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                con.query("UPDATE transaksi_penjualan SET tanggal = '" + dtPen.Value.ToString("yyyy-MM-dd") + "', id_supplier= '" + cbSupplier.SelectedValue + "', id_produk= '"+cbProduk.SelectedValue+"' , id_petugas= '" + cbPetugas.SelectedValue + "' WHERE id_transaksi_penjualan= '" + idTrx + "'");
                
                con.query("UPDATE detail_penjualan SET harga_jual = '" + tbHarga.Text + "', stok_terjual = '" + tbStok.Text + "' WHERE id_transaksi_penjualan= '" + idTrx + "'");

                int total = int.Parse(tbHarga.Text) * int.Parse(tbStok.Text);
                int untungKantin = total * 10 / 100;
                //hitung untung supplier 
                int untungSupplier = total - untungKantin;

                con.query("UPDATE detail_penjualan SET total_penjualan = '" + total + "' WHERE id_transaksi_penjualan = '" + idTrx + "'");
                con.query("UPDATE transaksi_penjualan SET total_penjualan ='" + total + "', keuntungan='" + untungSupplier + "', status='"+cbStatus.Text+"' WHERE id_transaksi_penjualan = '" + idTrx + "'");

                //MessageBox.Show("UNTUNG KANTIN: "+untungKantin + "\n Total : " + total + "\n UNTUNG SUPPLIER : " + untungSupplier);
                MessageBox.Show("Data Berhasil Diedit", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.kosongkanText(this);

                con.tampil("SELECT tp.id_transaksi_penjualan AS idTrx, dp.id_detail_penjualan, tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                    " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier;", dgvTrxPen);


                
            }



        }

        private void TransaksiPenjualan_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.main.transaksiPenjualanToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu.main.transaksiPenjualanToolStripMenuItem.Enabled = true;
            this.Hide();
            KeuntunganKantin keuntunganKantin = new KeuntunganKantin();
            keuntunganKantin.Show();
        }
    }
}
