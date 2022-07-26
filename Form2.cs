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
    public partial class Kayıtekle : Form
    {
        MuayneRaporu muayne = new MuayneRaporu();
        public Kayıtekle()
        {
            InitializeComponent();         
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-17LDD488;Initial Catalog=veteriner;Integrated Security=True;");
        DateTime tarih,tarih2;
        public void Kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into hastakayıt(hastaadi,hastatipi,turu,ırkı,cinsiyeti,kimlikno,kulakno,renk,safkan,dogumtarihi,hastasahibi,telefon,Eposta,muayenetarihi,muayenenedeni,teşhis,tedavi,hekim,muayeneşekli,boy,kilo,ateş,nabız,solunum,gövde,birsonrakimuayene,muayenegerçekleşme,tarih,aşıadı,uygpersonel,aşıüretici,aşıticariadı,aşıserino,açıklama,birsonrakiaşı,aşısonuç)values(@hastaadii,@hastatipii,@turuu,@ırkıı,@cinsiyetii,@kimliknoo,@kulaknoo,@renkk,@safkann,@dogumtarihii,@hastasahibii,@telefonn,@Epostaa,@muayenetarihii,@muayenenedenii,@teşhiss,@tedavii,@hekim,@muayeneşeklii,@boyy,@kiloo,@ateşş,@nabızz,@solunumm,@gövdee,@birsonrakimuayenee,@muayenegerçekleşmee,@tarihii,@aşıadıi,@uygpersoneli,@aşıüreticii,@aşıticariadıi,@aşıserinoi,@açıklamai,@birsonrakiaşıi,@aşısonuçi)", baglan);
            tarih = dateTimePicker2.Value;
            muayenetarih.Text = tarih.ToLongDateString();
            tarih2 = dateTimePicker1.Value;
            aşıtarih.Text = tarih.ToLongDateString();
            //Hasta Bilgileri
            komut.Parameters.AddWithValue("@hastaadii ", hastaadi.Text);
            komut.Parameters.AddWithValue("@hastatipii ", hastatipi.Text);
            komut.Parameters.AddWithValue("@turuu", turu.Text);
            komut.Parameters.AddWithValue("@ırkıı ", ırki.Text);
            komut.Parameters.AddWithValue("@cinsiyetii ", cinsiyeti.Text);
            komut.Parameters.AddWithValue("@kimliknoo ", kimlikno.Text);
            komut.Parameters.AddWithValue("@kulaknoo ", kulakno.Text);
            komut.Parameters.AddWithValue("@renkk ", renk.Text);
            komut.Parameters.AddWithValue("@safkann ", safkan.Text);
            komut.Parameters.AddWithValue("@dogumtarihii ", dogumtarihi.Text);
            komut.Parameters.AddWithValue("@hastasahibii ", hastasahibi.Text);
            komut.Parameters.AddWithValue("@telefonn ", telefon.Text);
            komut.Parameters.AddWithValue("@Epostaa ", eposta.Text);
            //Muayene Bilgileri
            komut.Parameters.AddWithValue("@muayenetarihii ", muayenetarih.Text);
            komut.Parameters.AddWithValue("@teşhiss ", teşhis.Text);
            komut.Parameters.AddWithValue("@tedavii", uygulanantedavi.Text);
            komut.Parameters.AddWithValue("@hekim ", veterinerhekim.Text);
            komut.Parameters.AddWithValue("@muayeneşeklii ", muayeneşekli.Text);
            komut.Parameters.AddWithValue("@boyy ", boy.Text);
            komut.Parameters.AddWithValue("@kiloo ", kilo.Text);
            komut.Parameters.AddWithValue("@ateşş ", ateş.Text);
            komut.Parameters.AddWithValue("@nabızz ", nabız.Text);
            komut.Parameters.AddWithValue("@solunumm ", solunum.Text);
            komut.Parameters.AddWithValue("@gövdee ", gövde.Text);
            komut.Parameters.AddWithValue("@birsonrakimuayenee ", birsonrakimuayene.Text);
            komut.Parameters.AddWithValue("@muayenegerçekleşmee ", muayenegerçekleşme.Text);
            komut.Parameters.AddWithValue("@muayenenedenii ", muayenenedeni.Text);
            //Aşı
            komut.Parameters.AddWithValue("@tarihii ", aşıtarih.Text);
            komut.Parameters.AddWithValue("@aşıadıi ", aşıadı.Text);
            komut.Parameters.AddWithValue("@uygpersoneli ", uygpersonel.Text);
            komut.Parameters.AddWithValue("@aşıüreticii", aşıüretici.Text);
            komut.Parameters.AddWithValue("@aşıticariadıi ", aşıticariadı.Text);
            komut.Parameters.AddWithValue("@aşıserinoi ", aşıserino.Text);
            komut.Parameters.AddWithValue("@açıklamai ", açıklama.Text);
            komut.Parameters.AddWithValue("@birsonrakiaşıi", birsonrakiaşı.Text);
            komut.Parameters.AddWithValue("@aşısonuçi", aşısonuç.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select *from hastakayıt");
            baglan.Close();

        }

        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void İptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }

}

