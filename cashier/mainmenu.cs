
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
        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();

        }

      

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            AddSupplier supplier = new AddSupplier(this);
            supplier.Show();
            supplierToolStripMenuItem.Enabled = false;
        }

        private void detailSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier(this);
            supplier.Show();
            detailSupplierToolStripMenuItem.Enabled = false;
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct(this);
            product.Show();
            produkToolStripMenuItem.Enabled = false;

        }
    }
}
