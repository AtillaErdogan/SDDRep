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
            groupBox3.Visible = false;

            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Secim", Baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox1.ValueMember = "SecimId";
            comboBox1.DisplayMember = "Secim";
            comboBox1.DataSource = dataTable;


            komut = new SqlCommand("select * from Sure", Baglanti);
            dataAdapter = new SqlDataAdapter(komut);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox2.ValueMember = "SureId";
            comboBox2.DisplayMember = "Sure";
            comboBox2.DataSource = dataTable;
            Baglanti.Close();




            Baglanti.Close();
            int id = Tools.KullaniciId;
            komut = new SqlCommand();
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
            label6.Text = PersonelId.ToString();
            object PersonelAdı = dataGridView1.CurrentRow.Cells["PersonelAd"].Value;
            label5.Text = PersonelAdı.ToString();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Izin where PersonelId = "+PersonelId+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            groupBox3.Visible = true;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Tarih";
            dataGridView2.Columns[2].HeaderText = "Seçim Türü";
            dataGridView2.Columns[3].HeaderText = "Süre Türü";
            dataGridView2.Columns[4].HeaderText = "Süre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Tools.KullaniciId;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kullanici INNER JOIN Kullanici_Yetki ON Kullanici.KullaniciId = Kullanici_Yetki.KullaniciId where Kullanici.KullaniciId = " + id + " And Kullanici_Yetki.YetkiId =" + 3 + " And Kullanici_Yetki.NesneId =" + 1 + " ";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                komut.CommandText = "Select * from Izin where PersonelId =" + label6.Text+ " And Tarih=" + maskedTextBox1.Text + " and SecimTur = " + comboBox1.SelectedValue + "";
                komut.Connection = Baglanti;
                dataReader.Close();
                dataReader = komut.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Bu verilere ait kayıt bulunmakta.");
                }
                else
                {
                    dataReader.Close();
                    komut.CommandText = "INSERT INTO Izin values(@PersonelId,@Tarih,@SecimTur,@SureTur,@Sure)";
                    komut.Connection = Baglanti;
                    komut.Parameters.AddWithValue("@PersonelId", label6.Text);
                    komut.Parameters.AddWithValue("@Tarih", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@SecimTur", Convert.ToInt32(comboBox1.SelectedValue));
                    komut.Parameters.AddWithValue("@SureTur", Convert.ToInt32(comboBox2.SelectedValue));
                    komut.Parameters.AddWithValue("@Sure", Convert.ToDouble(textBox1.Text));
                    int eklenenDeger = komut.ExecuteNonQuery();
                    if (eklenenDeger >= 1)
                    {
                        MessageBox.Show("Kayıt Başarılı");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Izin where PersonelId = " + label6.Text + " ", Baglanti);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                        groupBox3.Visible = true;
                        dataGridView2.Columns[0].Visible = false;
                        dataGridView2.Columns[1].HeaderText = "Tarih";
                        dataGridView2.Columns[2].HeaderText = "Seçim Türü";
                        dataGridView2.Columns[3].HeaderText = "Süre Türü";
                        dataGridView2.Columns[4].HeaderText = "Süre";
                    }
                    else
                    {
                        MessageBox.Show("Hata!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Bu İşlemi İçin Yetkiniz Yok.");
            }
            Baglanti.Close();








        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
