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
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Kullanici.KullaniciId , Kullanici.KullaniciAd ,Nesne.NesneAd,Yetki.YetkiAd from Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId INNER JOIN Yetki ON Yetki.Id = Kullanici_Yetki.YetkiId INNER JOIN Nesne ON Nesne.NesneId = Kullanici_Yetki.NesneId where Kullanici.KullaniciId = " + id+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource=dataTable;
            dataGridView2.Columns["KullaniciId"].Visible = false;
            dataGridView2.Columns["KullaniciAd"].Visible = false;



        }
    }
}
