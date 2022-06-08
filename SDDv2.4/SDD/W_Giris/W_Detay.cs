﻿using System;
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
            tools.ComboboxListele("Personel_Belge", cbBelgeler, "BelgeId", Convert.ToInt32(lblPersonelId_ref.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //TxtBoxların kilidini açıyor.
            if (txtAd.Enabled == true || txtSoyad.Enabled == true || cbCinsiyet.Enabled == true)
            {
                btn_Kilit.Text = "Kilit Aç";
                txtAd.Enabled = false;
                txtSoyad.Enabled = false;
                cbCinsiyet.Enabled = false;
            }
            else if (txtAd.Enabled == false || txtSoyad.Enabled == false || cbCinsiyet.Enabled == false)
            {
                btn_Kilit.Text = "Kilit Kapat";
                txtAd.Enabled = true;
                txtSoyad.Enabled = true;
                cbCinsiyet.Enabled = true;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //İlk önce Kullanıcı'nın yetkisi var mı ona bakıyor ardından yetkisi var ise güncelleme işlemini yapıyor.
            lblKullanıcıId_ref.Text= Tools.KullaniciId.ToString(); 
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId " +
                "where Kullanici.KullaniciId = "+id+" And Kullanici_Yetki.YetkiId = "+2+" ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                if (txtAd.Enabled == true || txtSoyad.Enabled == true || cbCinsiyet.Enabled == true)
                {
                    string sorgu = "update Personel set Ad=@personelAd, Soyad=@personelSoyadı, Cinsiyet=@personelCinsiyet where Id=@personelId";
                    SqlCommand komut2 = new SqlCommand(sorgu, Baglanti);
                    if (cbCinsiyet.Text == "Erkek")
                    {
                        lblcinsiyet_ref.Text = 1.ToString();
                    }
                    else if (cbCinsiyet.Text == "Kadın")
                    {
                        lblcinsiyet_ref.Text = 0.ToString();
                    }
                    komut2.Parameters.AddWithValue("@personelId", Convert.ToInt32(lblPersonelId_ref.Text));
                    komut2.Parameters.AddWithValue("@personelAd", txtAd.Text);
                    komut2.Parameters.AddWithValue("@personelSoyadı", txtSoyad.Text);
                    komut2.Parameters.AddWithValue("@personelCinsiyet", lblcinsiyet_ref.Text);
                    dataReader.Close();
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kilidi aç ve deger degişikligi yap.");
                }
                Baglanti.Close();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İçin Yetkiniz Yok.");
            }
            Baglanti.Close();            
        }
            
        
    }
}