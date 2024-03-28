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
    public partial class KeuntunganKantin : Form
    {
        config con = new config();
        public KeuntunganKantin()
        {
            InitializeComponent();
        }

        private void KeuntunganKantin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(990, 690);
            //menghitung keuntungan kantin berdasarkan bulan
             con.tampil("SELECT tp.tanggal AS Tanggal, pet.username AS NamaPetugas, sup.nama AS NamaSupplier, produk.nama AS NamaProduk, dp.harga_jual AS Harga, dp.stok_terjual AS Terjual, dp.total_penjualan AS Total, tp.keuntungan AS Keuntungan, dp.keuntungan_kantin AS KeuntunganKantin, tp.status AS Status" +
           " FROM transaksi_penjualan AS tp JOIN detail_penjualan AS dp ON tp.id_transaksi_penjualan = dp.id_transaksi_penjualan JOIN supplier AS sup ON sup.id_supplier = tp.id_supplier JOIN petugas AS pet ON pet.id_petugas = tp.id_petugas JOIN produk ON produk.id_produk = tp.id_produk JOIN transaksi_supplier AS ts ON ts.id_transaksi_supplier = dp.id_transaksi_supplier WHERE MONTH(tp.tanggal) = MONTH(CURDATE());", dgvKeuntungan);
            
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.reportKeuntunganKantinToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KeuntunganKantin_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.main.reportKeuntunganKantinToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //export to excel file 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "KeuntunganKantin.xls";
            sfd.FilterIndex = 0;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                con.exportToExcel(dgvKeuntungan, path);
            }   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu.main.reportKeuntunganKantinToolStripMenuItem.Enabled = true;
            this.Hide();
            TransaksiPenjualan tp = new TransaksiPenjualan();
            tp.Show();
        }
    }
}
