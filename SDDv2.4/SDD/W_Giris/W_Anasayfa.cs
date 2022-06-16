using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace W_Giris
{
    public partial class W_Anasayfa : Form
    {
        public W_Anasayfa()
        {
            InitializeComponent();
        }

        private void PersonelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PersonelListeleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Personel_Liste personelListe = new W_Personel_Liste();
            personelListe.MdiParent = this;
            personelListe.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            personelListe.Show();
        }

        private void kullanıcıYetkiVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Kullanici_Yetki kullanici_Yetki = new W_Kullanici_Yetki();
            kullanici_Yetki.Show();
        }

        private void kullnıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Kullanici_Yetki kullanici_Yetki = new W_Kullanici_Yetki();
            kullanici_Yetki.MdiParent = this;
            kullanici_Yetki.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            kullanici_Yetki.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Kullanıcı_Liste kullanıcı_Liste = new W_Kullanıcı_Liste();
            kullanıcı_Liste.MdiParent = this;
            kullanıcı_Liste.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            kullanıcı_Liste.Show();
        }

        private void personelİzinleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Personel_Izin personel_Izin = new W_Personel_Izin();
            personel_Izin.MdiParent = this;
            personel_Izin.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            personel_Izin.Show();
        }

        private void W_Anasayfa_Load(object sender, EventArgs e)
        {
        }
    }
}
