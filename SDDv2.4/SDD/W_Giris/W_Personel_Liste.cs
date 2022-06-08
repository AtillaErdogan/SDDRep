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
        Tools tools = new Tools();
        //SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        private void Button1_Click(object sender, EventArgs e)
        {
            
            string arananPersonel = txtPersonel_Ad.Text;
            tools.FiltreListele(arananPersonel,"Personel");
            dataGridView1.DataSource = tools.FiltreListele(arananPersonel,"personel");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Aktiflik"].Visible = false;
            dataGridView1.Columns["PasifTarih"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Soyadı";
            dataGridView1.Columns[3].HeaderText = "Cinsiyeti";
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object id = dataGridView1.CurrentRow.Cells["Id"].Value;
            tools.PersonelDetay(id,"Personel",dataGridView1);
           

        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                object referans = dataGridView1.CurrentRow.Cells["Id"].Value;
                DialogResult result1 = MessageBox.Show("Silme işlemini onaylıyor musun?",
                "Uyarı", MessageBoxButtons.YesNo);
                if (result1 ==DialogResult.Yes)
                {
                    tools.PersonelSil(referans, "Personel");
                    dataGridView1.DataSource = tools.Listele("Personel");
                }
                else
                {
                    
                }
                
               

            }
            
        }

        
    }
}
