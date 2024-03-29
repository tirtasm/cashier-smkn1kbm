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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cashier
{
    public partial class Login : Form
    {
            config con = new config();
            private const string connectionString = "datasource=localhost;username=root;password=;database=kantinv2";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPass.Text;
            string query = "SELECT id_petugas FROM petugas WHERE username = @Username AND password = @Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (tbPass.Text == "" || tbUser.Text == "")
                    {
                        MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (result != null)
                    {
                        int userId = Convert.ToInt32(result);

                        if (userId == 1)
                        {
                            MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            mainmenu mainmenu = new mainmenu();
                            mainmenu.Show();
                            mainmenu.main.petugasKantinToolStripMenuItem.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            mainmenu mainmenu = new mainmenu();
                            mainmenu.Show();
                            mainmenu.main.petugasKantinToolStripMenuItem.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username dan Password Salah!" , "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //form login close dan membuka form register
            Hide();
            register register = new register();
            register.Show();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
    }

}
