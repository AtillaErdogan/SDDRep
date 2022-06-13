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
        //Detay tablosundaki Label'a değer çekiyor.
        public static int KullaniciId ;
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
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
        public DataTable ListeleKullanici(string arananNesne ,String TabloAdı)
        {
            //Personel Listele Formunda isim, soyisim e göre arama yapıyor.
            //Tablo adını ve aranan nesneyi fonksiyona değer olarak atıyorum.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from "+TabloAdı+ " where KullaniciAd like '%" + arananNesne+"%' ",Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
            //----------------------------------------------------------        

        }
        public DataTable FiltreListelePersonel(string arananNesne, string tabloAdı)
        {
            //Personel Listele Formunda isim, soyisim e göre arama yapıyor.
            //Tablo adını ve aranan nesneyi fonksiyona değer olarak atıyorum.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Personel INNER JOIN Cinsiyet_Tip ON Personel.PersonelCinsiyet = Cinsiyet_Tip.Id where PersonelAd like '%"+arananNesne+ "%' or PersonelSoyad like '%" + arananNesne + "%'", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
            //----------------------------------------------------------        

        }
        public void PersonelSil(object referans, String TabloAdı)
        {   //Kayıt Silme işlemi yapıyor.
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
            //-------------------------------

        }
        public void YetkiSil(object referans, String TabloAdı)
        {   //Kayıt Silme işlemi yapıyor.
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Delete from " + TabloAdı + " where Id =@personelId";
            komut.Connection = Baglanti;
            komut.Parameters.AddWithValue("@personelId", referans);
            Baglanti.Open();
            int sayac = komut.ExecuteNonQuery();
            Baglanti.Close();
            if (sayac > 0)
            {

                MessageBox.Show("Kayıt Silinmiştir.");

            }
            else
            {
                MessageBox.Show("Silme işlemi yapılamadı.");
            }
            //-------------------------------

        }
        public void PersonelEkle(String personelAd, String personelSoyad, byte personelCinsiyet, byte personelAktif)
        {
            //Personel kaydını yapıyor.
            Baglanti.Close();
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 1 + " And Kullanici_Yetki.NesneId =" + 1 + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                dataReader.Close();
                komut.CommandText = "INSERT INTO Personel (PersonelAd,PersonelSoyad,PersonelCinsiyet,Aktiflik) values(@personelAd,@personelSoyad,@personelCinsiyet,@personelAktif)";
                komut.Connection = Baglanti;
                komut.Parameters.AddWithValue("@personelAd", personelAd);
                komut.Parameters.AddWithValue("@personelSoyad", personelSoyad);
                komut.Parameters.AddWithValue("@personelCinsiyet", personelCinsiyet);
                komut.Parameters.AddWithValue("@personelAktif", personelAktif);
                int eklenenDeger = komut.ExecuteNonQuery();
                if (eklenenDeger >= 1)
                {
                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Personel Ekleme İşlemi İçin Yetkiniz Yok.");
            }
            Baglanti.Close();
            //-------------------------------------------------------
        }
        public void Giris(string kullaniciAdi, string sifre) 
        {
            //Kullanıcı Girişini sorgulayan fonksiyon
            //Veritabanına gidip bilgileri eşliyor dogru ise giriş yapmasını saglıyor.
            W_Anasayfa anasayfa = new W_Anasayfa();            
            SqlCommand komut = new SqlCommand();

            komut.CommandText = "Select * from Kullanici where KullaniciAd= '"+kullaniciAdi+"' " +
                "AND KullaniciSifre= '"+sifre+"' AND Aktiflik= '"+1+"' ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("Giriş Başarılı ");
                KullaniciId = Convert.ToInt32(dataReader["KullaniciId"].ToString());
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            Baglanti.Close();
            //-----------------------------------------------------------------------
        }
        public void PersonelDetay(object arananId, String TabloAdı, DataGridView tabloAdı)
        {
            
                SqlCommand komut = new SqlCommand();
                //Personenelin veritabanındaki verisini lbl'a aktarıyor.
                komut.CommandText = "select * from "+TabloAdı+" where Id= "+arananId+" ";
                komut.Connection = Baglanti;
                Baglanti.Open();
                SqlDataReader dataReader = komut.ExecuteReader();
                if (dataReader.Read())
                {
                    W_Detay w_Detay = new W_Detay();
                    w_Detay.lblPersonelId_ref.Text = dataReader["Id"].ToString();
                    w_Detay.txtAd.Text = dataReader["PersonelAd"].ToString();
                    w_Detay.txtSoyad.Text = dataReader["PersonelSoyad"].ToString();
                    if (dataReader["PersonelCinsiyet"].Equals(true))
                    {
                        w_Detay.cbCinsiyet.Text = "Erkek";
                    }
                    else if (dataReader["PersonelCinsiyet"].Equals(false))
                    {
                        w_Detay.cbCinsiyet.Text = "Kadın";
                    }
                    w_Detay.Show();
                }
                else
                {
                    MessageBox.Show("Listelenecek Veri Yok.");
                }
                Baglanti.Close();
                //--------------------------------------------------------------
        }

        public void ComboboxListele(string tabloAdı,ComboBox comboAdı,string kolonAdı,int id)
        {
            //ComboBox'a veri çekmeyi sağlıyor.
            SqlCommand komut = new SqlCommand("select * from " +tabloAdı+ " where PersonelId= '"+id+"' ", Baglanti);
            SqlDataReader dataReader;
            Baglanti.Open();
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                comboAdı.Items.Add(dataReader[kolonAdı]);
            }
            Baglanti.Close();
            //--------------------------------
        }
        public void KullaniciEkle(String KullaniciAd, String Sifre, byte Aktiflik)
        {
            Baglanti.Close();
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select Kullanici_Yetki.KullaniciId, Kullanici_Yetki.NesneId, Kullanici_Yetki.YetkiId from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici_Yetki.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 1 + " and Kullanici_Yetki.NesneId = " + 2 + "  ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                dataReader.Close();
                SqlCommand komut2 = new SqlCommand();
                komut2.CommandText = "INSERT INTO Kullanici (KullaniciAd,KullaniciSifre,Aktiflik) values(@KullaniciAd,@KullaniciSifre,@Aktiflik)";
                komut2.Connection = Baglanti;
                komut2.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                komut2.Parameters.AddWithValue("@KullaniciSifre", Sifre);
                komut2.Parameters.AddWithValue("@Aktiflik", Aktiflik);
                int eklenenDeger2 = komut2.ExecuteNonQuery();
                if (eklenenDeger2 >= 1)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    
                }
                else
                {
                    MessageBox.Show("Hata!");
                    
                }
                Baglanti.Close();

            }
            else
            {
                MessageBox.Show("Bu Kullanıcının Ekleme Yetkisi Bulunmuyor.");
            }
            //Personel kaydını yapıyor.





            
            //-------------------------------------------------------
        }
        public void KullaniciDetay(object arananId, String TabloAdı, DataGridView tabloAdı)
        {

            SqlCommand komut = new SqlCommand();
            //Personenelin veritabanındaki verisini lbl'a aktarıyor.
            komut.CommandText = "select * from " + TabloAdı + " where Id= " + arananId + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                W_Kullanici_Yetki kullanici_Yetki = new W_Kullanici_Yetki();
                kullanici_Yetki.dataGridView2.Rows[0].Cells[0].Value = dataReader["KullaniciAd"];
                kullanici_Yetki.dataGridView2.Rows[0].Cells[0].Value = dataReader["NesneAd"];
                kullanici_Yetki.dataGridView2.Rows[0].Cells[0].Value = dataReader["YetkiAd"];
            }
            else
            {
                MessageBox.Show("Listelenecek Veri Yok.");
            }
            Baglanti.Close();
            //--------------------------------------------------------------
        }
    }
}
