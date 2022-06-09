namespace W_Giris
{
    partial class W_Kullanici_Kayit
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Location = new System.Drawing.Point(79, 119);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 29);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Location = new System.Drawing.Point(79, 69);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 23);
            this.txtSifre.TabIndex = 14;
            // 
            // txtKullanıcıAd
            // 
            this.txtKullanıcıAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullanıcıAd.Location = new System.Drawing.Point(79, 28);
            this.txtKullanıcıAd.Name = "txtKullanıcıAd";
            this.txtKullanıcıAd.Size = new System.Drawing.Size(100, 23);
            this.txtKullanıcıAd.TabIndex = 13;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(43, 72);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(30, 15);
            this.lblSoyad.TabIndex = 18;
            this.lblSoyad.Text = "Şifre";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(0, 31);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(73, 15);
            this.lblAd.TabIndex = 17;
            this.lblAd.Text = "Kullanıcı Adı";
            // 
            // W_Kullanici_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 189);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.MaximumSize = new System.Drawing.Size(227, 228);
            this.MinimumSize = new System.Drawing.Size(227, 228);
            this.Name = "W_Kullanici_Kayit";
            this.Text = "Kullanici Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
    }
}