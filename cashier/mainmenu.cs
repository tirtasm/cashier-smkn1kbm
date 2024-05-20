
﻿using Org.BouncyCastle.Asn1.IsisMtt.X509;
using Org.BouncyCastle.Pqc.Crypto.Falcon;
using System;

﻿using System;

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
    public partial class mainmenu : Form
    {
        public static mainmenu main;
        
        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();

        }

      

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
            supplierToolStripMenuItem.Enabled = false;

        }

        private void detailSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            detailSupplierToolStripMenuItem.Enabled = false;
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produkToolStripMenuItem.Enabled = false;
            AddProduct product = new AddProduct();
            product.Show();
        }
        private void transaksiPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaksiPenjualanToolStripMenuItem.Enabled = false;
            TransaksiPenjualan transaksi = new TransaksiPenjualan();
            transaksi.Show();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            main = this;

            

            

        }

        private void reportSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportSupplierToolStripMenuItem.Enabled = false;
            ReportSupplier reportSupplier = new ReportSupplier();
            reportSupplier.Show();
        }

        private void reportKeuntunganKantinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportKeuntunganKantinToolStripMenuItem.Enabled = false;
            KeuntunganKantin keuntunganKantin = new KeuntunganKantin();
            keuntunganKantin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void petugasKantinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            petugasKantinToolStripMenuItem.Enabled = true;
            Petugas pet= new Petugas();
            pet.Show();
        }

        
    }
}
