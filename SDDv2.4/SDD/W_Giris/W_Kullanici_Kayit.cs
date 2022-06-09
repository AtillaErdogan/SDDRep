using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace W_Giris
{
    public partial class W_Kullanici_Kayit : Form
    {
        public W_Kullanici_Kayit()
        {
            InitializeComponent();
        }
        Tools tools = new Tools();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String kullanıcıAd = txtKullanıcıAd.Text;
            String sifre = txtSifre.Text;
            if (txtKullanıcıAd.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun ");
                txtKullanıcıAd.Text = null;
                txtSifre.Text = null;
                return;
            }
            tools.KullaniciEkle(kullanıcıAd,sifre,1);
            txtKullanıcıAd.Text = null;
            txtSifre.Text = null;
        }
    }
}
