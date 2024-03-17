namespace cashier
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportKeuntunganKantinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2085, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierToolStripMenuItem,
            this.produkToolStripMenuItem,
            this.detailSupplierToolStripMenuItem,
            this.transaksiPenjualanToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(163, 38);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(352, 44);
            this.supplierToolStripMenuItem.Text = "Tambah Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // produkToolStripMenuItem
            // 
            this.produkToolStripMenuItem.Name = "produkToolStripMenuItem";
            this.produkToolStripMenuItem.Size = new System.Drawing.Size(352, 44);
            this.produkToolStripMenuItem.Text = "Tambah Produk";
            this.produkToolStripMenuItem.Click += new System.EventHandler(this.produkToolStripMenuItem_Click);
            // 
            // detailSupplierToolStripMenuItem
            // 
            this.detailSupplierToolStripMenuItem.Name = "detailSupplierToolStripMenuItem";
            this.detailSupplierToolStripMenuItem.Size = new System.Drawing.Size(352, 44);
            this.detailSupplierToolStripMenuItem.Text = "Transaksi Supplier";
            this.detailSupplierToolStripMenuItem.Click += new System.EventHandler(this.detailSupplierToolStripMenuItem_Click);
            // 
            // transaksiPenjualanToolStripMenuItem
            // 
            this.transaksiPenjualanToolStripMenuItem.Name = "transaksiPenjualanToolStripMenuItem";
            this.transaksiPenjualanToolStripMenuItem.Size = new System.Drawing.Size(352, 44);
            this.transaksiPenjualanToolStripMenuItem.Text = "Transaksi Penjualan";
            this.transaksiPenjualanToolStripMenuItem.Click += new System.EventHandler(this.transaksiPenjualanToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportSupplierToolStripMenuItem,
            this.reportKeuntunganKantinToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // reportSupplierToolStripMenuItem
            // 
            this.reportSupplierToolStripMenuItem.Name = "reportSupplierToolStripMenuItem";
            this.reportSupplierToolStripMenuItem.Size = new System.Drawing.Size(430, 44);
            this.reportSupplierToolStripMenuItem.Text = "Report Supplier";
            this.reportSupplierToolStripMenuItem.Click += new System.EventHandler(this.reportSupplierToolStripMenuItem_Click);
            // 
            // reportKeuntunganKantinToolStripMenuItem
            // 
            this.reportKeuntunganKantinToolStripMenuItem.Name = "reportKeuntunganKantinToolStripMenuItem";
            this.reportKeuntunganKantinToolStripMenuItem.Size = new System.Drawing.Size(430, 44);
            this.reportKeuntunganKantinToolStripMenuItem.Text = "Report Keuntungan Kantin";
            this.reportKeuntunganKantinToolStripMenuItem.Click += new System.EventHandler(this.reportKeuntunganKantinToolStripMenuItem1_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2085, 1225);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu | SMKN 1 Kebumen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainmenu_FormClosing);
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem detailSupplierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transaksiPenjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem produkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportSupplierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportKeuntunganKantinToolStripMenuItem;
    }
}