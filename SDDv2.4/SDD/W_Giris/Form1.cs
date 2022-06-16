using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_Giris
{
    public partial class Form1 : Form
    {
        Tools tools = new Tools();
        public Form1()
        {
            InitializeComponent();
        }
        
        W_Anasayfa anasayfa = new W_Anasayfa();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun ");
                txtKullaniciAdi.Text = null;
                txtSifre.Text = null;
                return;
            }
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            if (tools.Giris(kullaniciAdi, sifre)==1)
            {
                anasayfa.Show();
                this.Hide();
            }
            else if (tools.Giris(kullaniciAdi, sifre) == 0)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            //tools.Giris(kullaniciAdi,sifre);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
