using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Veteriner_Takip_Otomasyonu
{
    public partial class Aşırapor : Form
    {
        public Aşırapor()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-17LDD488;Initial Catalog=veteriner;Integrated Security=True;");
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string hastaadi = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string tarih = dataGridView1.Rows[seçilialan].Cells[27].Value.ToString();
            string aşıadı = dataGridView1.Rows[seçilialan].Cells[28].Value.ToString();
            string uygpersonel = dataGridView1.Rows[seçilialan].Cells[29].Value.ToString();
            string aşıüretici = dataGridView1.Rows[seçilialan].Cells[30].Value.ToString();
            string aşıticariadı = dataGridView1.Rows[seçilialan].Cells[31].Value.ToString();
            string aşıserino = dataGridView1.Rows[seçilialan].Cells[32].Value.ToString();
            string açıklama = dataGridView1.Rows[seçilialan].Cells[33].Value.ToString();
            string birsonrakiaşı = dataGridView1.Rows[seçilialan].Cells[34].Value.ToString();
            string aşısonuç = dataGridView1.Rows[seçilialan].Cells[35].Value.ToString();

            hastaadii.Text = hastaadi;
            aşıtarihi.Text = tarih;
            aşıadıi.Text = aşıadı;
            uygpersoneli.Text = uygpersonel;
            aşıüreticii.Text = aşıüretici;
            aşıticariadıi.Text = aşıticariadı;
            aşıserinoi.Text = aşıserino;
            açıklamai.Text = açıklama;
            aşısonuçi.Text = aşısonuç;
        }
        private void Aşırapor_Load(object sender, EventArgs e)
        {
            verilerigöster("Select *from hastakayıt");
        }

        private void Sorgula_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from hastakayıt where hastaadi like '%" + textBox1.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
            textBox1.Clear();
        }

    }
}
