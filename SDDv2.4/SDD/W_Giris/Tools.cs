using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace W_Giris
{
    public class Tools
    {
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        SqlCommand komut = new SqlCommand();
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public DataTable Listele(string TabloAdı) {

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from "+TabloAdı+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;

        }
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public DataTable FiltreListele(string arananNesne ,String TabloAdı)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from " + TabloAdı + " where Ad like '%" + arananNesne + "%' or Soyad like '%" + arananNesne + "%' ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
            
        }
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public void PersonelSil(object referans, String TabloAdı)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Delete from "+TabloAdı+" where Id =@personelId";
            komut.Connection = Baglanti;
            komut.Parameters.AddWithValue("@personelId", referans);
            Baglanti.Open();
            int sayac = komut.ExecuteNonQuery();
            Baglanti.Close();
            if (sayac > 0)
            {
                
                MessageBox.Show("Kayıt Silinmiştir.");
                
            }
            else {
                MessageBox.Show("Silme işlemi yapılamadı.");
            }
            
        }
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public void PersonelEkle(String personelAd, String personelSoyad, byte personelCinsiyet, byte personelAktif)
        {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "INSERT INTO Personel (Ad,Soyad,Cinsiyet,Aktiflik) values(@personelAd,@personelSoyad,@personelCinsiyet,@personelAktif)";
            komut.Connection = Baglanti;
            komut.Parameters.AddWithValue("@personelAd", personelAd);
            komut.Parameters.AddWithValue("@personelSoyad", personelSoyad);
            komut.Parameters.AddWithValue("@personelCinsiyet", personelCinsiyet);
            komut.Parameters.AddWithValue("@personelAktif", personelAktif);
            Baglanti.Open();
            int eklenenDeger = komut.ExecuteNonQuery();
            if (eklenenDeger >= 1)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Hata!");
            }
            Baglanti.Close();

        }
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public void Giris(string kullaniciAdi, string sifre) {
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * from Kullanici where KullaniciAd='" +kullaniciAdi+ "' AND KullaniciSifre='" + sifre+ "' AND Aktiflik='"+1+"'";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                
                MessageBox.Show("Giriş Başarılı ");
                W_Anasayfa anasayfa = new W_Anasayfa();
                anasayfa.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }
            Baglanti.Close();

        }
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public void PersonelDetay(object arananId, String TabloAdı,DataGridView tabloAdı)
        {

            if (tabloAdı.CurrentRow != null)
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "select * from " + TabloAdı + " where Id=" + arananId + "";
                komut.Connection = Baglanti;
                Baglanti.Open();
                SqlDataReader dataReader = komut.ExecuteReader();
                if (dataReader.Read())
                {
                    W_Detay w_Detay = new W_Detay();
                    w_Detay.lblıd.Text = dataReader["Id"].ToString();
                    w_Detay.txt_AdDeger.Text = dataReader["Ad"].ToString();
                    w_Detay.txt_SoyadDeger.Text = dataReader["Soyad"].ToString();
                    if (dataReader["Cinsiyet"].Equals(true))
                    {
                        w_Detay.cb_CinsiyetDeger.Text = "Erkek";

                    }
                    else if (dataReader["Cinsiyet"].Equals(false))
                    {
                        w_Detay.cb_CinsiyetDeger.Text = "Kadın";

                    }
                    w_Detay.Show();


                }
                else
                {
                    MessageBox.Show("Listelenecek Veri Yok.");

                }
                Baglanti.Close();




            }
           



        }


        //--------------------------------------------------------------
        //--------------------------------------------------------------

        public void ComboboxListele(string tabloAdı,ComboBox comboAdı,string kolonAdı,int id)
        {
            SqlCommand komut = new SqlCommand("select * from " + tabloAdı +" where PersonelId= '"+id+"' ", Baglanti);
            SqlDataReader dataReader;
            Baglanti.Open();
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                
                comboAdı.Items.Add(dataReader[kolonAdı]);
            }
            Baglanti.Close();

        }



    }
}
