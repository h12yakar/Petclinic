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
    public partial class MuayneRaporu : Form
    {
        public MuayneRaporu()
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
        private void Sorgula_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string hastaadi = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string muayenetarihi = dataGridView1.Rows[seçilialan].Cells[13].Value.ToString();
            string muayenenedeni = dataGridView1.Rows[seçilialan].Cells[14].Value.ToString();
            string teşhis = dataGridView1.Rows[seçilialan].Cells[15].Value.ToString();
            string tedavi = dataGridView1.Rows[seçilialan].Cells[16].Value.ToString();
            string hekim = dataGridView1.Rows[seçilialan].Cells[17].Value.ToString();
            string muayeneşekli = dataGridView1.Rows[seçilialan].Cells[18].Value.ToString();
            string boy = dataGridView1.Rows[seçilialan].Cells[19].Value.ToString();
            string kilo = dataGridView1.Rows[seçilialan].Cells[20].Value.ToString();
            string ateş = dataGridView1.Rows[seçilialan].Cells[21].Value.ToString();
            string nabız = dataGridView1.Rows[seçilialan].Cells[22].Value.ToString();
            string solunum = dataGridView1.Rows[seçilialan].Cells[23].Value.ToString();
            string gövde = dataGridView1.Rows[seçilialan].Cells[24].Value.ToString();

            hastaadii.Text = hastaadi;
            muayenetarihii.Text = muayenetarihi;
            muayenenedenii.Text = muayenenedeni;
            teşhisi.Text = teşhis;
            uygulanantedavii.Text = tedavi;
            veterinerhekimi.Text = hekim;
            muayeneşeklii.Text = muayeneşekli;
            boyi.Text = boy;
            kiloi.Text = kilo;
            ateşi.Text = ateş;
            nabızi.Text = nabız;
            solunumi.Text = solunum;
            gövdei.Text = gövde;

        }

        private void MuayneRaporu_Load(object sender, EventArgs e)
        {
            verilerigöster("Select *from hastakayıt");
        }
    }


}
