using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace cashier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
            }
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
