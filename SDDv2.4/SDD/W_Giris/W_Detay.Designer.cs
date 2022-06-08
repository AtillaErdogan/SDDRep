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
            this.txt_Ad = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.Label();
            this.txt_Cinsiyet = new System.Windows.Forms.Label();
            this.txt_Belgeler = new System.Windows.Forms.Label();
            this.txt_AdDeger = new System.Windows.Forms.TextBox();
            this.txt_SoyadDeger = new System.Windows.Forms.TextBox();
            this.cb_CinsiyetDeger = new System.Windows.Forms.ComboBox();
            this.btn_Kilit = new System.Windows.Forms.Button();
            this.cb_belgeler = new System.Windows.Forms.ComboBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.lblıd = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Ad
            // 
            this.txt_Ad.AutoSize = true;
            this.txt_Ad.Location = new System.Drawing.Point(40, 27);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(25, 15);
            this.txt_Ad.TabIndex = 7;
            this.txt_Ad.Text = "Adı";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.AutoSize = true;
            this.txt_Soyad.Location = new System.Drawing.Point(23, 69);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(42, 15);
            this.txt_Soyad.TabIndex = 8;
            this.txt_Soyad.Text = "Soyadı";
            // 
            // txt_Cinsiyet
            // 
            this.txt_Cinsiyet.AutoSize = true;
            this.txt_Cinsiyet.Location = new System.Drawing.Point(13, 117);
            this.txt_Cinsiyet.Name = "txt_Cinsiyet";
            this.txt_Cinsiyet.Size = new System.Drawing.Size(52, 15);
            this.txt_Cinsiyet.TabIndex = 9;
            this.txt_Cinsiyet.Text = "Cinsiyeti";
            // 
            // txt_Belgeler
            // 
            this.txt_Belgeler.AutoSize = true;
            this.txt_Belgeler.Location = new System.Drawing.Point(13, 162);
            this.txt_Belgeler.Name = "txt_Belgeler";
            this.txt_Belgeler.Size = new System.Drawing.Size(52, 15);
            this.txt_Belgeler.TabIndex = 10;
            this.txt_Belgeler.Text = "Belgeleri";
            // 
            // txt_AdDeger
            // 
            this.txt_AdDeger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdDeger.Enabled = false;
            this.txt_AdDeger.Location = new System.Drawing.Point(74, 24);
            this.txt_AdDeger.MaxLength = 50;
            this.txt_AdDeger.Name = "txt_AdDeger";
            this.txt_AdDeger.Size = new System.Drawing.Size(121, 23);
            this.txt_AdDeger.TabIndex = 1;
            // 
            // txt_SoyadDeger
            // 
            this.txt_SoyadDeger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoyadDeger.Enabled = false;
            this.txt_SoyadDeger.Location = new System.Drawing.Point(74, 66);
            this.txt_SoyadDeger.MaxLength = 50;
            this.txt_SoyadDeger.Name = "txt_SoyadDeger";
            this.txt_SoyadDeger.Size = new System.Drawing.Size(121, 23);
            this.txt_SoyadDeger.TabIndex = 2;
            // 
            // cb_CinsiyetDeger
            // 
            this.cb_CinsiyetDeger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_CinsiyetDeger.Enabled = false;
            this.cb_CinsiyetDeger.FormattingEnabled = true;
            this.cb_CinsiyetDeger.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cb_CinsiyetDeger.Location = new System.Drawing.Point(74, 114);
            this.cb_CinsiyetDeger.Name = "cb_CinsiyetDeger";
            this.cb_CinsiyetDeger.Size = new System.Drawing.Size(121, 23);
            this.cb_CinsiyetDeger.TabIndex = 3;
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
            // cb_belgeler
            // 
            this.cb_belgeler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_belgeler.FormattingEnabled = true;
            this.cb_belgeler.Location = new System.Drawing.Point(74, 159);
            this.cb_belgeler.Name = "cb_belgeler";
            this.cb_belgeler.Size = new System.Drawing.Size(121, 23);
            this.cb_belgeler.TabIndex = 4;
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
            // lblıd
            // 
            this.lblıd.AutoSize = true;
            this.lblıd.Location = new System.Drawing.Point(632, 240);
            this.lblıd.Name = "lblıd";
            this.lblıd.Size = new System.Drawing.Size(55, 15);
            this.lblıd.TabIndex = 10;
            this.lblıd.Text = "Belgeler :";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(632, 267);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(55, 15);
            this.lblcinsiyet.TabIndex = 11;
            this.lblcinsiyet.Text = "Belgeler :";
            // 
            // W_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 309);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lblıd);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.cb_belgeler);
            this.Controls.Add(this.btn_Kilit);
            this.Controls.Add(this.cb_CinsiyetDeger);
            this.Controls.Add(this.txt_SoyadDeger);
            this.Controls.Add(this.txt_AdDeger);
            this.Controls.Add(this.txt_Belgeler);
            this.Controls.Add(this.txt_Cinsiyet);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
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

        private System.Windows.Forms.Label txt_Ad;
        private System.Windows.Forms.Label txt_Soyad;
        private System.Windows.Forms.Label txt_Cinsiyet;
        private System.Windows.Forms.Label txt_Belgeler;
        public System.Windows.Forms.TextBox txt_AdDeger;
        public System.Windows.Forms.TextBox txt_SoyadDeger;
        public System.Windows.Forms.ComboBox cb_CinsiyetDeger;
        private System.Windows.Forms.Button btn_Kilit;
        private System.Windows.Forms.Button btn_Guncelle;
        public System.Windows.Forms.Label lblıd;
        public System.Windows.Forms.Label lblcinsiyet;
        public System.Windows.Forms.ComboBox cb_belgeler;
    }
}