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
    public partial class W_Personel_Liste : Form
    {
        public W_Personel_Liste()
        {
            InitializeComponent();
        }
        //Tools Sınıfına ulaşmamı saglıyor.
        Tools tools = new Tools();
        //Veritabanı baglantım. 
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        private void Button1_Click(object sender, EventArgs e)
        {
            Baglanti.Close();
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select Kullanici_Yetki.KullaniciId, Kullanici_Yetki.NesneId, Kullanici_Yetki.YetkiId from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici_Yetki.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 4 + " and Kullanici_Yetki.NesneId = " + 1 + "  ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                string arananPersonel = txtPersonelAd.Text;
                tools.FiltreListelePersonel(arananPersonel, "Personel");
                dataGridView1.DataSource = tools.FiltreListelePersonel(arananPersonel, "Personel");
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Aktiflik"].Visible = false;
                dataGridView1.Columns["PasifTarih"].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Adı";
                dataGridView1.Columns[2].HeaderText = "Soyadı";
                dataGridView1.Columns[2].HeaderText = "Cinsiyeti";

            }
            else
            {
                MessageBox.Show("Kullanıcı Listeleme Yetkiniz yok.");
            }




            //Filtreli Veri çekme.
            //string arananPersonel = txtPersonelAd.Text
            //------------------------------------------------
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eğer tıkladıgım satır boş degil ise personel detayını çekiyor.
            if (dataGridView1.CurrentRow != null)
            {
                object id = dataGridView1.CurrentRow.Cells["Id"].Value;
                tools.PersonelDetay(id, "Personel",dataGridView1);
            }
            //-------------------------------------------------------------
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Yetki dogrultusunda silme işlemini yapıyor
            //eger veri tabanımda kullanıcıya yetki atamışssam silme işlemini yapıyor.
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 1 + " And Kullanici_Yetki.NesneId =" + 1 + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                if (dataGridView1.CurrentRow != null)
                {
                    object referans = dataGridView1.CurrentRow.Cells["Id"].Value;
                    DialogResult result1 = MessageBox.Show("Silme işlemini onaylıyor musun?",
                    "Uyarı", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        tools.PersonelSil(referans, "Personel");
                        dataGridView1.DataSource = tools.Listele("Personel");
                    }
                }
            }
            else
            {
                MessageBox.Show("Personel Silme İşlemi İçin Yetkiniz Yok.");
            }
            Baglanti.Close();
        }

        private void W_Personel_Liste_Load(object sender, EventArgs e)
        {
            //Tabloya ekleme çıkarma yapmamı engelliyor.
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

      
    }
}
