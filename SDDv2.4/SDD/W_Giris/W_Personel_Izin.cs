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
    public partial class W_Personel_Izin : Form
    {
        public W_Personel_Izin()
        {
            InitializeComponent();
        }
        Tools tools = new Tools();
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        private void W_Personel_Izin_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ReadOnly = true;


            Baglanti.Close();
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 4 + " And Kullanici_Yetki.NesneId =" + 1 + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                dataGridView1.DataSource = tools.Listele("Personel");
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Adı";
                dataGridView1.Columns[2].HeaderText = "Soyadı";

            }
            Baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object PersonelId = dataGridView1.CurrentRow.Cells["Id"].Value;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Izin where PersonelId = "+PersonelId+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            //dataGridView2.Columns[0].Visible = false;
            //dataGridView2.Columns[3].Visible = false;
            //dataGridView2.Columns[4].Visible = false;
            //dataGridView2.Columns[3].Visible = false;
            //object deger = dataGridView1.CurrentRow.Cells["KullaniciAd"].Value;
            //groupBox3.Visible = true;
            //dataGridView2.Columns[4].HeaderText = "Nesne Adı";
            //dataGridView2.Columns[5].HeaderText = "Yetki Adı";
        }
    }
}
