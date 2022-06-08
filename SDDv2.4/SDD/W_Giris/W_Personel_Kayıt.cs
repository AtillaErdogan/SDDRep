using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace W_Giris
{
    public partial class W_Personel_Kayıt : Form
    {
        public W_Personel_Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        Tools tools = new Tools();
        private void Button1_Click(object sender, EventArgs e)
        {        
            //Kullanıcı kaydını yapıyor
            //Boş txtBoxları kontrol ediyor.
            String personelAd = txtAd.Text;
            String personelSoyad = txtSoyad.Text;
            byte personelCinsiyet = 0;
            byte personelAktif =1 ;
            if (CbCinsiyet.Text=="Erkek")
            {
                personelCinsiyet = 1;
            }
            else if (CbCinsiyet.Text == "Kadın")
            {
                personelCinsiyet = 0;
            }
            if (personelAd == "" || personelSoyad == "" || CbCinsiyet.Text=="") 
            {
                MessageBox.Show("Boş alanları doldurun ");
                txtAd.Text = null;
                txtSoyad.Text = null;
                CbCinsiyet.Text = null;
                return;
            }
            tools.PersonelEkle(personelAd,personelSoyad,personelCinsiyet,personelAktif);
            txtAd.Text = null;
            txtSoyad.Text = null;
            CbCinsiyet.Text = null;
        }

    }
}
