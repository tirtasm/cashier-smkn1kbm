namespace cashier
{
    partial class ReportSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSupplier));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAllDay = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.dgvSupp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_exit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.btnAllDay);
            this.groupBox3.Controls.Add(this.btnToday);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbCari);
            this.groupBox3.Controls.Add(this.dgvSupp);
            this.groupBox3.Location = new System.Drawing.Point(29, 157);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(2091, 1087);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            // 
            // btnAllDay
            // 
            this.btnAllDay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAllDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllDay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAllDay.Location = new System.Drawing.Point(1871, 29);
            this.btnAllDay.Name = "btnAllDay";
            this.btnAllDay.Size = new System.Drawing.Size(175, 45);
            this.btnAllDay.TabIndex = 45;
            this.btnAllDay.Text = "Semua Hari";
            this.btnAllDay.UseVisualStyleBackColor = false;
            this.btnAllDay.Click += new System.EventHandler(this.btnAllDay_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.ForeColor = System.Drawing.SystemColors.Window;
            this.btnToday.Location = new System.Drawing.Point(1672, 29);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(175, 45);
            this.btnToday.TabIndex = 44;
            this.btnToday.Text = "Hari Ini";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
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
            // dgvSupp
            // 
            this.dgvSupp.AllowUserToAddRows = false;
            this.dgvSupp.AllowUserToDeleteRows = false;
            this.dgvSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupp.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupp.Location = new System.Drawing.Point(50, 95);
            this.dgvSupp.Margin = new System.Windows.Forms.Padding(6);
            this.dgvSupp.Name = "dgvSupp";
            this.dgvSupp.ReadOnly = true;
            this.dgvSupp.RowHeadersWidth = 82;
            this.dgvSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupp.Size = new System.Drawing.Size(1995, 961);
            this.dgvSupp.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2382, 137);
            this.panel1.TabIndex = 142;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1034, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "Detail Penjualan";
            // 
            // ReportSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2135, 1259);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportSupplier";
            this.Text = " Laporan Supplier | SMKN 1 Kebumen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportSupplier_FormClosed);
            this.Load += new System.EventHandler(this.ReportSupplier_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.DataGridView dgvSupp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnAllDay;
    }
}