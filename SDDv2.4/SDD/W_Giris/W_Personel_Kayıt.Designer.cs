namespace W_Giris
{
    partial class W_Personel_Kayıt
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(39, 33);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "Adı";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(22, 73);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(42, 15);
            this.lblSoyad.TabIndex = 11;
            this.lblSoyad.Text = "Soyadı";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(12, 113);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(52, 15);
            this.lblCinsiyet.TabIndex = 12;
            this.lblCinsiyet.Text = "Cinsiyeti";
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Location = new System.Drawing.Point(75, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Location = new System.Drawing.Point(76, 73);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Location = new System.Drawing.Point(75, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 29);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CbCinsiyet.Location = new System.Drawing.Point(75, 110);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(100, 23);
            this.CbCinsiyet.TabIndex = 5;
            // 
            // W_Personel_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 245);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.MaximumSize = new System.Drawing.Size(264, 284);
            this.MinimumSize = new System.Drawing.Size(264, 284);
            this.Name = "W_Personel_Kayıt";
            this.Text = "Personel Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox CbCinsiyet;
    }
}