<<<<<<< HEAD
﻿using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
=======
﻿using System;
>>>>>>> 988a070edf3bda57943c4c1fc1ad65fa81d6c395
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
<<<<<<< HEAD
            
=======
>>>>>>> 988a070edf3bda57943c4c1fc1ad65fa81d6c395

        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
<<<<<<< HEAD
            product.Show();                        
            this.Enabled = false;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

=======
            product.Show();
            this.Hide();
>>>>>>> 988a070edf3bda57943c4c1fc1ad65fa81d6c395
        }
    }
}
