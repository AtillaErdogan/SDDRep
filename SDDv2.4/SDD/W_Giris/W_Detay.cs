using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace W_Giris
{
    public partial class W_Detay : Form
    {
        public W_Detay()
        {
            InitializeComponent();
        }
        Tools tools = new Tools();
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        
        
        public void W_Detay_Load(object sender, EventArgs e)
        {
            tools.ComboboxListele("Personel_Belge", cb_belgeler, "BelgeId", Convert.ToInt32(lblıd.Text));
            
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_AdDeger.Enabled == true || txt_SoyadDeger.Enabled == true || cb_CinsiyetDeger.Enabled == true)
            {
                btn_Kilit.Text = "Kilit Aç";
                txt_AdDeger.Enabled = false;
                txt_SoyadDeger.Enabled = false;
                cb_CinsiyetDeger.Enabled = false;
            }
            else if (txt_AdDeger.Enabled == false || txt_SoyadDeger.Enabled == false || cb_CinsiyetDeger.Enabled == false)
            {
                btn_Kilit.Text = "Kilit Kapat";
                txt_AdDeger.Enabled = true;
                txt_SoyadDeger.Enabled = true;
                cb_CinsiyetDeger.Enabled = true;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (txt_AdDeger.Enabled == true || txt_SoyadDeger.Enabled == true || cb_CinsiyetDeger.Enabled == true)
            {
                
                Baglanti.Open();
                string sorgu = "update Personel set Ad=@personelAd, Soyad=@personelSoyadı, Cinsiyet=@personelCinsiyet where Id=@personelId";
                SqlCommand komut = new SqlCommand(sorgu, Baglanti);
                if (cb_CinsiyetDeger.Text == "Erkek")
                {
                    lblcinsiyet.Text = 1.ToString();
                }
                else if (cb_CinsiyetDeger.Text == "Kadın")
                {
                    lblcinsiyet.Text = 0.ToString();
                }
                komut.Parameters.AddWithValue("@personelId", Convert.ToInt32(lblıd.Text));
                komut.Parameters.AddWithValue("@personelAd", txt_AdDeger.Text);
                komut.Parameters.AddWithValue("@personelSoyadı", txt_SoyadDeger.Text);
                komut.Parameters.AddWithValue("@personelCinsiyet",lblcinsiyet.Text);
                
                
                komut.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
            }
            else
            {
                MessageBox.Show("Kilidi aç ve deger degişikligi yap.");
            }

        }
            
        
    }
}
