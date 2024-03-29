namespace cashier
{
    partial class TransaksiPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiPenjualan));
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.dgvTrxPen = new System.Windows.Forms.DataGridView();
            this.b_exit = new System.Windows.Forms.Button();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPen = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Keterangan = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbPetugas = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduk = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrxPen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(775, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "Detail Penjualan";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbCari);
            this.groupBox3.Controls.Add(this.dgvTrxPen);
            this.groupBox3.Location = new System.Drawing.Point(762, 169);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(1240, 698);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 25);
            this.label13.TabIndex = 43;
            this.label13.Text = "Cari";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(147, 39);
            this.tbCari.Margin = new System.Windows.Forms.Padding(6);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(330, 31);
            this.tbCari.TabIndex = 0;
            // 
            // dgvTrxPen
            // 
            this.dgvTrxPen.AllowUserToAddRows = false;
            this.dgvTrxPen.AllowUserToDeleteRows = false;
            this.dgvTrxPen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrxPen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrxPen.Location = new System.Drawing.Point(12, 92);
            this.dgvTrxPen.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTrxPen.Name = "dgvTrxPen";
            this.dgvTrxPen.ReadOnly = true;
            this.dgvTrxPen.RowHeadersWidth = 82;
            this.dgvTrxPen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrxPen.Size = new System.Drawing.Size(1216, 594);
            this.dgvTrxPen.TabIndex = 1;
            this.dgvTrxPen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrxPen_CellDoubleClick);
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.Red;
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Location = new System.Drawing.Point(53, 35);
            this.b_exit.Margin = new System.Windows.Forms.Padding(6);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(112, 63);
            this.b_exit.TabIndex = 5;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(297, 460);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(240, 31);
            this.tbStok.TabIndex = 131;
            this.tbStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStok_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 130;
            this.label6.Text = "Stok Terjual";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(297, 404);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(240, 31);
            this.tbHarga.TabIndex = 129;
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 128;
            this.label3.Text = "Harga Jual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 124;
            this.label1.Text = "Tanggal";
            // 
            // dtPen
            // 
            this.dtPen.Location = new System.Drawing.Point(297, 188);
            this.dtPen.Name = "dtPen";
            this.dtPen.Size = new System.Drawing.Size(400, 31);
            this.dtPen.TabIndex = 123;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(308, 600);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 63);
            this.btnEdit.TabIndex = 117;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(116, 600);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(6);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(176, 63);
            this.btnSimpan.TabIndex = 116;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 119;
            this.label4.Text = "Petugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 120;
            this.label5.Text = "Nama Supplier";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(-19, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2109, 137);
            this.panel1.TabIndex = 121;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1897, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lihat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(496, 600);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 63);
            this.btnDelete.TabIndex = 118;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Keterangan
            // 
            this.Keterangan.AutoSize = true;
            this.Keterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keterangan.Location = new System.Drawing.Point(84, 521);
            this.Keterangan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Size = new System.Drawing.Size(137, 29);
            this.Keterangan.TabIndex = 127;
            this.Keterangan.Text = "Keterangan";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(297, 519);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(240, 33);
            this.cbStatus.TabIndex = 126;
            // 
            // cbPetugas
            // 
            this.cbPetugas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPetugas.FormattingEnabled = true;
            this.cbPetugas.Location = new System.Drawing.Point(297, 240);
            this.cbPetugas.Name = "cbPetugas";
            this.cbPetugas.Size = new System.Drawing.Size(240, 33);
            this.cbPetugas.TabIndex = 110;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(297, 295);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(240, 33);
            this.cbSupplier.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 133;
            this.label2.Text = "Nama Produk";
            // 
            // cbProduk
            // 
            this.cbProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduk.FormattingEnabled = true;
            this.cbProduk.Location = new System.Drawing.Point(297, 352);
            this.cbProduk.Name = "cbProduk";
            this.cbProduk.Size = new System.Drawing.Size(240, 33);
            this.cbProduk.TabIndex = 134;
            // 
            // TransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2030, 904);
            this.Controls.Add(this.cbProduk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPetugas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Keterangan);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(26, 71);
            this.Name = "TransaksiPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Transaksi Penjualan | SMKN 1 Kebumen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransaksiPenjualan_FormClosed);
            this.Load += new System.EventHandler(this.TransaksiPenjualan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrxPen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.DataGridView dgvTrxPen;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPen;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label Keterangan;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbPetugas;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProduk;
        private System.Windows.Forms.Button button1;
    }
}