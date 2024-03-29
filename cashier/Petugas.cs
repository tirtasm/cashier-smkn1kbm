using Org.BouncyCastle.Crypto;
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
    public partial class Petugas : Form
    {
        config con = new config();
        int id;
        private mainmenu mainMenu;
        public Petugas()
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            mainmenu.main.petugasKantinToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //jika id = 1 maka tidak bisa dihapus karena id 1 adalah admin
            if (id == 1)
            {
                MessageBox.Show("Data Admin Tidak Bisa Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (id == 0)
                {
                    MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.query("DELETE FROM petugas WHERE id_petugas= " + id);
                    con.tampil("SELECT id_petugas as No, username as Nama, alamat as Alamat, no_telp as NoTelp FROM petugas", dgvPetugas);
                    con.kosongkanText(this);
                }
                else
                {
                    con.kosongkanText(this);

                }
            }
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            con.tampil("SELECT id_petugas as No, username as Nama, alamat as Alamat, no_telp as NoTelp FROM petugas", dgvPetugas);
            this.Size = new Size(840, 440);
            dgvPetugas.Columns[0].Visible = false;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!tbTelp.Text.StartsWith("+62") && !tbTelp.Text.StartsWith("08"))
            {
                MessageBox.Show("Nomor HP harus diawali dengan +62 atau 08", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (tbTelp.Text.Length < 11)
            {
                MessageBox.Show("Nomor HP harus lebih dari 11 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbAlamat.Text == "" || tbNama.Text == "" || tbTelp.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
                return;
            }
            else
            {
                con.query("UPDATE petugas SET username= '" + tbNama.Text + "', alamat='" + tbAlamat.Text + "', no_telp='" + tbTelp.Text + "' WHERE id_petugas= " + id);
                con.kosongkanText(this);
                con.tampil("SELECT id_petugas as No, username as Nama, no_telp as NoTelp, alamat as Alamat FROM petugas", dgvPetugas);
            
            }
            
        }

        private void Petugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainmenu.main.petugasKantinToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void dgvPetugas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvPetugas.Rows[e.RowIndex];
            id = int.Parse(dr.Cells[0].Value.ToString());
            tbNama.Text = dr.Cells[1].Value.ToString();
            tbAlamat.Text = dr.Cells[2].Value.ToString();
            tbTelp.Text = dr.Cells[3].Value.ToString();
            
        }

        private void tbTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            con.tampil("SELECT id_petugas as No, username as Nama, alamat as Alamat, no_telp as NoTelp, password FROM petugas WHERE username LIKE '%" + tbCari.Text + "%'", dgvPetugas);
        }
    }
}
