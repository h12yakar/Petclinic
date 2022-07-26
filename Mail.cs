using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class Mail : Form
    {
        Form1 frm = new Form1();
        Kayıtekle kyt = new Kayıtekle();
        public Mail()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-17LDD488;Initial Catalog=veteriner;Integrated Security=True;");

        public void verilerigöster(string veriler)
           {
             SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
             DataSet ds = new DataSet();
             da.Fill(ds);
             dataGridView.DataSource = ds.Tables[0];
           }

            private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
           {
            int seçilialan = dataGridView.SelectedCells[0].RowIndex;
            string Eposta = dataGridView.Rows[seçilialan].Cells[12].Value.ToString();
            string birsonrakimuayene = dataGridView.Rows[seçilialan].Cells[25].Value.ToString();
            this.birsonrakimuayene.Text = birsonrakimuayene;
            EPosta.Text = Eposta;
           }
            public void Gonder_Click(object sender, EventArgs e)
          {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("burak.maykk@gmail.com", "bg19971997");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(EPosta.Text);
            mesajım.From = new MailAddress("burak.maykk@gmail.com");
            mesajım.Subject = konu.Text;
            mesajım.Body = mesajiçeriği.Text;
            istemci.Send(mesajım);
            MessageBox.Show("E-Posta İletilmiştir...");
          }

        private void Sorgula_Click_1(object sender, EventArgs e)
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

        //Zamanlama Kısmı
        int saniye, dakika, saat, gün;
        private void Mail_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            verilerigöster("Select *from hastakayıt");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelsaniye.Text = Convert.ToString(saniye);
            if (saniye ==59)
            {
                saniye = 0;
                dakika++;
                labeldakika.Text = Convert.ToString(dakika);

            }
            if (dakika == 59)
            {
                dakika = 0;
                saat++;
                labelsaat.Text = Convert.ToString(saat);
            }
            if (saat == 24)
            {
                saat = 0;
                saniye = 0;
                dakika = 0;
                gün++;
                labelgün.Text = Convert.ToString(gün);

            }
            if (Convert.ToInt32(birsonrakimuayene.Text)==Convert.ToInt32(labelgün.Text))
            {
                timer1.Enabled = false;
                MailMessage mesajım = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("burak.maykk@gmail.com", "bg19971997");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                mesajım.To.Add(EPosta.Text);
                mesajım.From = new MailAddress("burak.maykk@gmail.com");
                mesajım.Subject = konu.Text;
                mesajım.Body = mesajiçeriği.Text;
                istemci.Send(mesajım);
                MessageBox.Show("E-Posta İletilmiştir...");
            }
        }


    }
}
