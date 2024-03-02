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
    public partial class Supplier : Form
    {
            config con = new config();
        public Supplier()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            con.query("INSERT INTO supplier (nama, alamat, no_telp) VALUES ('" + tbNama.Text + "','" + tbAlamat.Text + "','" + tbHp.Text + "')");
            MessageBox.Show("Data Berhasil Disimpan");
        }
    }
}
