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
    
    public partial class Form1 : Form
    {
        Kayıtekle kyt = new Kayıtekle();
        public Form1()
        {
            InitializeComponent();
            kyt = new Kayıtekle();
        }       
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-17LDD488;Initial Catalog=veteriner;Integrated Security=True;");

        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
        }
     
        public void BtnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigöster("Select *from hastakayıt");
        }

        public void BtnKayıtekle_Click(object sender, EventArgs e)
        {
         Kayıtekle kytekle = new Kayıtekle();
         kytekle.Show();
        }
        
        private void BtnKayıtsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from hastakayıt where hastaadi=@hastaadii", baglan);
            komut.Parameters.AddWithValue("@hastaadii", textBox2.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select *from hastakayıt");
            baglan.Close();
            textBox2.Clear();
        }

        public void Sorgula_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from hastakayıt where hastaadi like '%" + textBox1.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            baglan.Close();
            textBox1.Clear();
     
        }

       public void Güncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update hastakayıt set telefon='" + telefoni.Text  + "',hastatipi='" + hastatipii.Text + "',turu='" + turui.Text + "',ırkı='" + ırkii.Text + "',cinsiyeti='" + cinsiyetii.Text+ "',kimlikno='"+ kimliknoi.Text+ "',kulakno='"+ kulaknoi.Text+"',renk='"+ renki.Text+"',safkan='"+ safkani.Text+"',dogumtarihi='"+ dogumtarihii.Text+"',hastasahibi='"+ hastasahibii.Text+"',hekim='"+veterinerhekimi.Text+"',muayeneşekli='"+muayeneşeklii.Text+"',muayenetarihi='"+muayenetarihii.Text+"',muayenenedeni='"+muayenenedenii.Text+"',tedavi='"+uygulanantedavii.Text+"',teşhis='"+teşhisi.Text+"',birsonrakimuayene='"+birsonrakimuayenei.Text+"',muayenegerçekleşme='"+muayenegerçekleşmei.Text+"',boy='"+boyi.Text+"',kilo='"+kiloi.Text+"',ateş='"+ateşi.Text+"',nabız='"+nabızi.Text+"',solunum='"+solunumi.Text+"',gövde='"+gövdei.Text+"',tarih='"+aşıtarihi.Text+"',aşıadı='"+aşıadıi.Text+"',uygpersonel='"+uygpersoneli.Text+"',aşıüretici='"+aşıüreticii.Text+"',aşıticariadı='"+aşıticariadıi.Text+"',aşıserino='"+aşıserinoi.Text+"',açıklama='"+açıklamai.Text+"',birsonrakiaşı='"+birsonrakiaşıi.Text+"',Eposta='"+EPosta.Text+"',aşısonuç='"+aşısonuçi.Text+"'where hastaadi='"+ hastaadii.Text+"'", baglan); 
            komut.ExecuteNonQuery();
            verilerigöster("select *from hastakayıt");
            baglan.Close();

        }

          public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView.SelectedCells[0].RowIndex;
            string hastaadi = dataGridView.Rows[seçilialan].Cells[0].Value.ToString();
            string hastatipi = dataGridView.Rows[seçilialan].Cells[1].Value.ToString();
            string turu = dataGridView.Rows[seçilialan].Cells[2].Value.ToString();
            string ırkı = dataGridView.Rows[seçilialan].Cells[3].Value.ToString();
            string cinsiyeti = dataGridView.Rows[seçilialan].Cells[4].Value.ToString();
            string kimlikno = dataGridView.Rows[seçilialan].Cells[5].Value.ToString();
            string kulakno = dataGridView.Rows[seçilialan].Cells[6].Value.ToString();
            string renk = dataGridView.Rows[seçilialan].Cells[7].Value.ToString();
            string safkan = dataGridView.Rows[seçilialan].Cells[8].Value.ToString();
            string dogumtarihi = dataGridView.Rows[seçilialan].Cells[9].Value.ToString();
            string hastasahibi = dataGridView.Rows[seçilialan].Cells[10].Value.ToString();
            string telefon = dataGridView.Rows[seçilialan].Cells[11].Value.ToString();
            string Eposta = dataGridView.Rows[seçilialan].Cells[12].Value.ToString();
            //Muayene
            string muayenetarihi = dataGridView.Rows[seçilialan].Cells[13].Value.ToString();
            string muayenenedeni = dataGridView.Rows[seçilialan].Cells[14].Value.ToString();
            string teşhis= dataGridView.Rows[seçilialan].Cells[15].Value.ToString();
            string tedavi= dataGridView.Rows[seçilialan].Cells[16].Value.ToString();
            string hekim = dataGridView.Rows[seçilialan].Cells[17].Value.ToString();
            string muayeneşekli = dataGridView.Rows[seçilialan].Cells[18].Value.ToString();
            string boy = dataGridView.Rows[seçilialan].Cells[19].Value.ToString();
            string kilo = dataGridView.Rows[seçilialan].Cells[20].Value.ToString();
            string ateş = dataGridView.Rows[seçilialan].Cells[21].Value.ToString();
            string nabız = dataGridView.Rows[seçilialan].Cells[22].Value.ToString();
            string solunum = dataGridView.Rows[seçilialan].Cells[23].Value.ToString();
            string gövde = dataGridView.Rows[seçilialan].Cells[24].Value.ToString();
            string birsonrakimuayene = dataGridView.Rows[seçilialan].Cells[25].Value.ToString();
            string muayenegerçekleşme = dataGridView.Rows[seçilialan].Cells[26].Value.ToString();
            //Aşı
            string tarih = dataGridView.Rows[seçilialan].Cells[27].Value.ToString();
            string aşıadı = dataGridView.Rows[seçilialan].Cells[28].Value.ToString();
            string uygpersonel = dataGridView.Rows[seçilialan].Cells[29].Value.ToString();
            string aşıüretici = dataGridView.Rows[seçilialan].Cells[30].Value.ToString();
            string aşıticariadı = dataGridView.Rows[seçilialan].Cells[31].Value.ToString();
            string aşıserino = dataGridView.Rows[seçilialan].Cells[32].Value.ToString();
            string açıklama = dataGridView.Rows[seçilialan].Cells[33].Value.ToString();
            string birsonrakiaşı = dataGridView.Rows[seçilialan].Cells[34].Value.ToString();
            string aşısonuç = dataGridView.Rows[seçilialan].Cells[35].Value.ToString();

            //Genel Bilgiler
            hastaadii.Text = hastaadi;
            hastatipii.Text = hastatipi;
            turui.Text = turu;
            ırkii.Text = ırkı;
            cinsiyetii.Text = cinsiyeti;
            kimliknoi.Text = kimlikno;
            kulaknoi.Text = kulakno;
            renki.Text = renk;
            safkani.Text = safkan;
            dogumtarihii.Text = dogumtarihi;
            hastasahibii.Text = hastasahibi;
            telefoni.Text = telefon;
            EPosta.Text = Eposta;
            //Muayene
            muayenetarihii.Text=muayenetarihi;
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
            birsonrakimuayenei.Text = birsonrakimuayene;
            muayenegerçekleşmei.Text = muayenegerçekleşme;
            //AŞI tarih
            aşıtarihi.Text = tarih;
            aşıadıi.Text = aşıadı;
            uygpersoneli.Text = uygpersonel;
            aşıüreticii.Text = aşıüretici;
            aşıticariadıi.Text = aşıticariadı;
            aşıserinoi.Text = aşıserino;
            açıklamai.Text = açıklama;
            birsonrakiaşıi.Text = birsonrakiaşı;
            aşısonuçi.Text = aşısonuç;

        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail mai = new Mail();
            mai.Show();
        }

        private void ePostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AşıMail mail = new AşıMail();
            mail.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında hknda= new Hakkında();
            hknda.Show();
        }

        private void hastaMuayneRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayneRaporu muayne = new MuayneRaporu();
            muayne.Show();
        }

        private void hastaAşıRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aşırapor aşı = new Aşırapor();
            aşı.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aşıToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
