using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        string dosyaYolu;


        public void W_Detay_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Belge_Tip.BelgeAd from Personel INNER JOIN Personel_Belge ON Personel.Id = Personel_Belge.PersonelId INNER JOIN Belge_Tip ON Belge_Tip.Id = Personel_Belge.BelgeId where Personel.Id="+lblPersonelId_ref.Text+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            
            SqlCommand komut = new SqlCommand("select * from Belge_Tip", Baglanti);
            dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable2 = new DataTable();
            dataAdapter.Fill(dataTable2);
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "BelgeAd";
            comboBox1.DataSource = dataTable2;


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
                "where Kullanici.KullaniciId = "+id+" And Kullanici_Yetki.YetkiId = "+2+ " And Kullanici_Yetki.NesneID = " + 1 + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                if (txtAd.Enabled == true || txtSoyad.Enabled == true || cbCinsiyet.Enabled == true)
                {
                    string sorgu = "update Personel set PersonelAd=@personelAd, PersonelSoyad=@personelSoyadı, PersonelCinsiyet=@personelCinsiyet where Id=@personelId";
                    SqlCommand komut2 = new SqlCommand(sorgu, Baglanti);
                    if (cbCinsiyet.Text == "Erkek")
                    {
                        lblcinsiyet_ref.Text = 1.ToString();
                    }
                    else if (cbCinsiyet.Text == "Kadın")
                    {
                        lblcinsiyet_ref.Text = 2.ToString();
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
                MessageBox.Show("Personel Güncelleme İşlemi İçin Yetkiniz Yok.");
            }
            Baglanti.Close();            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(dosyaYolu,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] dosya = binaryReader.ReadBytes((int)dosyaYolu.Length);
            binaryReader.Close();
            fileStream.Close();
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            SqlCommand komut = new SqlCommand("insert into Personel_Belge (PersonelId,BelgeId,Tarih,BelgeIcerik) values (@PersonelId,@BelgeId,@Tarih,@BelgeIcerik)", Baglanti);
            Baglanti.Open();
            komut.Parameters.AddWithValue("@PersonelId", lblPersonelId_ref);
            komut.Parameters.AddWithValue("@BelgeId",comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(DateTime.Now)); ;
            komut.Parameters.AddWithValue("@BelgeIcerik",SqlDbType.VarBinary).Value = dosya; 

            
            komut.ExecuteNonQuery();
            Baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Dosya Seç";
            openFileDialog2.Filter = "Word Documents|*.doc|pdf Worksheets|*.pdf|PowerPoint Presentations|*.ppt" +
             "|Office Files|*.doc;*.xls;*.ppt" +
             "|All Files|*.*";
            
            if (openFileDialog2.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text=openFileDialog2.FileName;
                dosyaYolu= openFileDialog2.FileName; 
            }
        }
    }
}
