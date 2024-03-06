namespace cashier
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbProduk = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nama Produk";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.t_cari);
            this.groupBox3.Controls.Add(this.dgvProduk);
            this.groupBox3.Location = new System.Drawing.Point(815, 211);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(1303, 715);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(147, 39);
            this.t_cari.Margin = new System.Windows.Forms.Padding(6);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(330, 31);
            this.t_cari.TabIndex = 0;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // dgvProduk
            // 
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduk.Location = new System.Drawing.Point(12, 104);
            this.dgvProduk.Margin = new System.Windows.Forms.Padding(6);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.RowHeadersWidth = 82;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(1279, 568);
            this.dgvProduk.TabIndex = 1;
            this.dgvProduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(966, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "Data Produk";
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
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
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.b_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_delete.FlatAppearance.BorderSize = 0;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.ForeColor = System.Drawing.Color.White;
            this.b_delete.Location = new System.Drawing.Point(486, 766);
            this.b_delete.Margin = new System.Windows.Forms.Padding(6);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(176, 63);
            this.b_delete.TabIndex = 3;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_edit
            // 
            this.b_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.b_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_edit.FlatAppearance.BorderSize = 0;
            this.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit.ForeColor = System.Drawing.Color.White;
            this.b_edit.Location = new System.Drawing.Point(298, 766);
            this.b_edit.Margin = new System.Windows.Forms.Padding(6);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(176, 63);
            this.b_edit.TabIndex = 1;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = false;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.b_simpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_simpan.FlatAppearance.BorderSize = 0;
            this.b_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_simpan.ForeColor = System.Drawing.Color.White;
            this.b_simpan.Location = new System.Drawing.Point(106, 766);
            this.b_simpan.Margin = new System.Windows.Forms.Padding(6);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(176, 63);
            this.b_simpan.TabIndex = 0;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = false;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(-20, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2326, 137);
            this.panel1.TabIndex = 63;
            // 
            // tbProduk
            // 
            this.tbProduk.Location = new System.Drawing.Point(285, 325);
            this.tbProduk.Name = "tbProduk";
            this.tbProduk.Size = new System.Drawing.Size(436, 31);
            this.tbProduk.TabIndex = 70;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2243, 1025);
            this.Controls.Add(this.tbProduk);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_simpan);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product | SMKN 1 KEBUMEN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.Load += new System.EventHandler(this.Product_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbProduk;
    }
}