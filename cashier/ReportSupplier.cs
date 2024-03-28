using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashier
{
    public partial class ReportSupplier : Form
    {
            config con = new config();
        
        public ReportSupplier()
        {
            InitializeComponent();
        
        }

        private void ReportSupplier_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1105, 705);
            con.tampil("SELECT tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                    " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier WHERE DATE(tp.tanggal) = CURDATE();", dgvSupp);
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            //
            mainmenu.main.reportSupplierToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void ReportSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.main.reportSupplierToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            con.tampil("SELECT tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                    " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier WHERE DATE(tp.tanggal) = CURDATE();", dgvSupp);
        }

        private void btnAllDay_Click(object sender, EventArgs e)
        {
            con.tampil("SELECT tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, tp.status AS Status" +
                    " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier", dgvSupp);
        }
    }
}
