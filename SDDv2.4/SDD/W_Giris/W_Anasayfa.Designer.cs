﻿namespace W_Giris
{
    partial class W_Anasayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.personelİzinleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kullnıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListeleSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.personelİzinleriToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(64, 20);
            this.Menu.Text = "Personel";
            // 
            // personelListeleSilToolStripMenuItem
            // 
            this.personelListeleSilToolStripMenuItem.Name = "personelListeleSilToolStripMenuItem";
            this.personelListeleSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.personelListeleSilToolStripMenuItem.Text = "Personeller";
            this.personelListeleSilToolStripMenuItem.Click += new System.EventHandler(this.PersonelListeleSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // personelİzinleriToolStripMenuItem
            // 
            this.personelİzinleriToolStripMenuItem.Name = "personelİzinleriToolStripMenuItem";
            this.personelİzinleriToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.personelİzinleriToolStripMenuItem.Text = "Personel İzinleri";
            this.personelİzinleriToolStripMenuItem.Click += new System.EventHandler(this.personelİzinleriToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kullnıcıListeleToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kullanıcıToolStripMenuItem.Text = "Admin";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıclar";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // kullnıcıListeleToolStripMenuItem
            // 
            this.kullnıcıListeleToolStripMenuItem.Name = "kullnıcıListeleToolStripMenuItem";
            this.kullnıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kullnıcıListeleToolStripMenuItem.Text = "Kullanıcı Yetki Ver";
            this.kullnıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.kullnıcıListeleToolStripMenuItem_Click);
            // 
            // W_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1450, 1000);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "W_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.W_Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem personelListeleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kullnıcıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİzinleriToolStripMenuItem;
    }
}