using System;

namespace W_Giris
{
    partial class W_Personel_Liste
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.lblKullanıcıID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(1, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(637, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.SilToolStripMenuItem_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(87, 15);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Adı veya Soyad";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAd.Location = new System.Drawing.Point(12, 27);
            this.txtPersonelAd.MaxLength = 50;
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(87, 23);
            this.txtPersonelAd.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Location = new System.Drawing.Point(12, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbKadın.Location = new System.Drawing.Point(164, 28);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(55, 19);
            this.rbKadın.TabIndex = 2;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbErkek.Location = new System.Drawing.Point(105, 28);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 19);
            this.rbErkek.TabIndex = 3;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            this.rbErkek.CheckedChanged += new System.EventHandler(this.rbErkek_CheckedChanged);
            // 
            // lblKullanıcıID
            // 
            this.lblKullanıcıID.AutoSize = true;
            this.lblKullanıcıID.Location = new System.Drawing.Point(645, 56);
            this.lblKullanıcıID.Name = "lblKullanıcıID";
            this.lblKullanıcıID.Size = new System.Drawing.Size(38, 15);
            this.lblKullanıcıID.TabIndex = 5;
            this.lblKullanıcıID.Text = "label2";
            // 
            // W_Personel_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 438);
            this.Controls.Add(this.lblKullanıcıID);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.rbKadın);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(654, 477);
            this.MinimumSize = new System.Drawing.Size(654, 477);
            this.Name = "W_Personel_Liste";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.W_Personel_Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Button btnAra;
        //private EventHandler button1_Click_1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.Label lblKullanıcıID;
    }
}