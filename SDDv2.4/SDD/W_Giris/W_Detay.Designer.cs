namespace W_Giris
{
    partial class W_Detay
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblBelgeler = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_Kilit = new System.Windows.Forms.Button();
            this.cbBelgeler = new System.Windows.Forms.ComboBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.lblPersonelId_ref = new System.Windows.Forms.Label();
            this.lblcinsiyet_ref = new System.Windows.Forms.Label();
            this.lblKullanıcıId_ref = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(40, 27);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 7;
            this.lblAd.Text = "Adı";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(23, 69);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(42, 15);
            this.lblSoyad.TabIndex = 8;
            this.lblSoyad.Text = "Soyadı";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(13, 117);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(52, 15);
            this.lblCinsiyet.TabIndex = 9;
            this.lblCinsiyet.Text = "Cinsiyeti";
            // 
            // lblBelgeler
            // 
            this.lblBelgeler.AutoSize = true;
            this.lblBelgeler.Location = new System.Drawing.Point(13, 162);
            this.lblBelgeler.Name = "lblBelgeler";
            this.lblBelgeler.Size = new System.Drawing.Size(52, 15);
            this.lblBelgeler.TabIndex = 10;
            this.lblBelgeler.Text = "Belgeleri";
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(74, 24);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 23);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(74, 66);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 23);
            this.txtSoyad.TabIndex = 2;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.Enabled = false;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(74, 114);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(121, 23);
            this.cbCinsiyet.TabIndex = 3;
            // 
            // btn_Kilit
            // 
            this.btn_Kilit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kilit.Location = new System.Drawing.Point(236, 24);
            this.btn_Kilit.Name = "btn_Kilit";
            this.btn_Kilit.Size = new System.Drawing.Size(75, 23);
            this.btn_Kilit.TabIndex = 5;
            this.btn_Kilit.Text = "Kilit Aç";
            this.btn_Kilit.UseVisualStyleBackColor = true;
            this.btn_Kilit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBelgeler
            // 
            this.cbBelgeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBelgeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBelgeler.FormattingEnabled = true;
            this.cbBelgeler.Location = new System.Drawing.Point(74, 159);
            this.cbBelgeler.Name = "cbBelgeler";
            this.cbBelgeler.Size = new System.Drawing.Size(121, 23);
            this.cbBelgeler.TabIndex = 4;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.Location = new System.Drawing.Point(236, 65);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 6;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // lblPersonelId_ref
            // 
            this.lblPersonelId_ref.AutoSize = true;
            this.lblPersonelId_ref.Location = new System.Drawing.Point(396, 205);
            this.lblPersonelId_ref.Name = "lblPersonelId_ref";
            this.lblPersonelId_ref.Size = new System.Drawing.Size(17, 15);
            this.lblPersonelId_ref.TabIndex = 10;
            this.lblPersonelId_ref.Text = "--";
            // 
            // lblcinsiyet_ref
            // 
            this.lblcinsiyet_ref.AutoSize = true;
            this.lblcinsiyet_ref.Location = new System.Drawing.Point(396, 233);
            this.lblcinsiyet_ref.Name = "lblcinsiyet_ref";
            this.lblcinsiyet_ref.Size = new System.Drawing.Size(27, 15);
            this.lblcinsiyet_ref.TabIndex = 11;
            this.lblcinsiyet_ref.Text = "----";
            // 
            // lblKullanıcıId_ref
            // 
            this.lblKullanıcıId_ref.AutoSize = true;
            this.lblKullanıcıId_ref.Location = new System.Drawing.Point(396, 181);
            this.lblKullanıcıId_ref.Name = "lblKullanıcıId_ref";
            this.lblKullanıcıId_ref.Size = new System.Drawing.Size(32, 15);
            this.lblKullanıcıId_ref.TabIndex = 12;
            this.lblKullanıcıId_ref.Text = "-----";
            // 
            // W_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 309);
            this.Controls.Add(this.lblKullanıcıId_ref);
            this.Controls.Add(this.lblcinsiyet_ref);
            this.Controls.Add(this.lblPersonelId_ref);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.cbBelgeler);
            this.Controls.Add(this.btn_Kilit);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblBelgeler);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.MaximumSize = new System.Drawing.Size(349, 348);
            this.MinimumSize = new System.Drawing.Size(349, 348);
            this.Name = "W_Detay";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Detay Tablosu";
            this.Load += new System.EventHandler(this.W_Detay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblBelgeler;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Button btn_Kilit;
        private System.Windows.Forms.Button btn_Guncelle;
        public System.Windows.Forms.ComboBox cbBelgeler;
        public System.Windows.Forms.Label lblPersonelId_ref;
        public System.Windows.Forms.Label lblcinsiyet_ref;
        public System.Windows.Forms.Label lblKullanıcıId_ref;
    }
}