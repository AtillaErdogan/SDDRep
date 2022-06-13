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
    public partial class W_Kullanici_Yetki : Form
    {
        public W_Kullanici_Yetki()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        Tools tools = new Tools();
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Close();
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select Kullanici_Yetki.KullaniciId, Kullanici_Yetki.NesneId, Kullanici_Yetki.YetkiId from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici_Yetki.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 4 + " and Kullanici_Yetki.NesneId = " + 2 + "  ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                string arananPersonel = textBox1.Text;
                tools.ListeleKullanici(arananPersonel, "Kullanici");
                dataGridView1.DataSource = tools.ListeleKullanici(arananPersonel, "Kullanici");
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["Aktiflik"].Visible = false;
                dataGridView1.Columns["KullaniciSifre"].Visible = false;
                dataGridView1.Columns["PasifTarih"].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
                dataGridView1.Columns[2].HeaderText = "Şifresi";

            }
            else
            {
                MessageBox.Show("Kullanıcı Listeleme Yetkiniz yok.");
            }
            dataReader.Close();
        }

        private void W_Kullanici_Yetki_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Nesne", Baglanti);
            SqlDataReader dataReader;
            Baglanti.Open();
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader["NesneAd"]);
            }
            dataReader.Close();

            SqlCommand komut2 = new SqlCommand("select * from Yetki", Baglanti);
            SqlDataReader dataReader2;
            dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                comboBox2.Items.Add(dataReader2["YetkiAd"]);
            }
            Baglanti.Close();
            //dataGridView2.Columns[1].HeaderText = "Nesne";
            //dataGridView2.Columns[2].HeaderText = "Yetki";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ReadOnly = true;
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            object id = dataGridView1.CurrentRow.Cells["KullaniciId"].Value;
            label6.Text = id.ToString();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select  Kullanici.KullaniciId , Kullanici.KullaniciAd , Kullanici_Yetki.NesneId , Kullanici_Yetki.YetkiId , Nesne.NesneAd , Yetki.YetkiAd from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId INNER JOIN Yetki ON Yetki.Id = Kullanici_Yetki.YetkiId INNER JOIN Nesne ON Nesne.NesneId = Kullanici_Yetki.NesneId where Kullanici.KullaniciId = " + id+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource=dataTable;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            object deger = dataGridView1.CurrentRow.Cells["KullaniciAd"].Value;
            label3.Text = deger.ToString();
            groupBox3.Visible = true;
            dataGridView2.Columns[4].HeaderText = "Nesne Adı";
            dataGridView2.Columns[5].HeaderText = "Yetki Adı";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

            Baglanti.Close();
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 1 + " And Kullanici_Yetki.NesneId =" + 2 + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                if (dataGridView1.CurrentRow != null)
                {

                    DialogResult result1 = MessageBox.Show("Silme işlemini onaylıyor musun?",
                    "Uyarı", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {   
                        object KullaniciId = dataGridView2.CurrentRow.Cells["KullaniciId"].Value;
                        object NesneId = dataGridView2.CurrentRow.Cells["NesneId"].Value;
                        object YetkiId = dataGridView2.CurrentRow.Cells["YetkiId"].Value;
                        SqlCommand komut2 = new SqlCommand();
                        komut2.CommandText = "Delete from Kullanici_Yetki where KullaniciId =" +KullaniciId + " and NesneId="+NesneId+ " and YetkiId="+ YetkiId + "  ";
                        komut2.Connection = Baglanti;
                        dataReader.Close();
                        int sayac = komut2.ExecuteNonQuery();
                        Baglanti.Close();
                        if (sayac > 0)
                        {

                            MessageBox.Show("Kayıt Silinmiştir.");

                            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select  Kullanici.KullaniciId , Kullanici.KullaniciAd , Kullanici_Yetki.NesneId , Kullanici_Yetki.YetkiId , Nesne.NesneAd , Yetki.YetkiAd from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId INNER JOIN Yetki ON Yetki.Id = Kullanici_Yetki.YetkiId INNER JOIN Nesne ON Nesne.NesneId = Kullanici_Yetki.NesneId where Kullanici.KullaniciId =" +Convert.ToInt32( label6.Text) + " ", Baglanti);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                            dataGridView2.Columns[0].Visible = false;
                            dataGridView2.Columns[1].Visible = false;
                            dataGridView2.Columns[2].Visible = false;
                            dataGridView2.Columns[3].Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi yapılamadı.");
                        }


                        
                        //SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Kullanici_Yetki.Id , Kullanici.KullaniciId , Kullanici.KullaniciAd , Nesne.NesneAd , Yetki.YetkiAd from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId INNER JOIN Yetki ON Yetki.Id = Kullanici_Yetki.YetkiId INNER JOIN Nesne ON Nesne.NesneId = Kullanici_Yetki.NesneId where Kullanici.KullaniciId = " + id + " ", Baglanti);
                        //DataTable dataTable = new DataTable();
                        //dataAdapter.Fill(dataTable);
                        //dataGridView2.DataSource = dataTable;
                        //dataGridView2.Columns["KullaniciId"].Visible = false;
                        //dataGridView2.Columns["KullaniciAd"].Visible = false;
                        //object deger = dataGridView1.CurrentRow.Cells["KullaniciAd"].Value;
                        //label3.Text = deger.ToString();
                        //groupBox3.Visible = true;



                        //dataGridView1.AllowUserToAddRows = false;
                        //dataGridView1.AllowUserToDeleteRows = false;
                        //dataGridView1.ReadOnly = true;
                        //dataGridView2.AllowUserToAddRows = false;
                        //dataGridView2.AllowUserToDeleteRows = false;
                        //dataGridView2.ReadOnly = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Personel Silme İşlemi İçin Yetkiniz Yok.");
            }
            Baglanti.Close();
        }

        
    }
    
    
}
