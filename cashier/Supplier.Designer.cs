namespace cashier
{
    partial class Supplier
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
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(546, 334);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(422, 41);
            this.tbAlamat.TabIndex = 26;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(546, 254);
            this.tbHp.Multiline = true;
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(422, 41);
            this.tbHp.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "No HP";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(546, 172);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(422, 41);
            this.tbNama.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nama";
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(1000, 478);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(145, 60);
            this.btnRegis.TabIndex = 18;
            this.btnRegis.Text = "Tambah Supplier";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 764);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegis);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegis;
    }
}