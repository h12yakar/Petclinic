namespace Veteriner_Takip_Otomasyonu
{
    partial class Mail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.konu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mesajiçeriği = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gonder = new System.Windows.Forms.Button();
            this.Sorgula = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EPosta = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label55 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelsaat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labeldakika = new System.Windows.Forms.Label();
            this.labelsaniye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelgün = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birsonrakimuayene = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // konu
            // 
            this.konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konu.Location = new System.Drawing.Point(251, 270);
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(202, 20);
            this.konu.TabIndex = 5;
            this.konu.Text = "Muayene Bilgilendirme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konu :";
            // 
            // mesajiçeriği
            // 
            this.mesajiçeriği.Location = new System.Drawing.Point(254, 326);
            this.mesajiçeriği.Multiline = true;
            this.mesajiçeriği.Name = "mesajiçeriği";
            this.mesajiçeriği.Size = new System.Drawing.Size(202, 141);
            this.mesajiçeriği.TabIndex = 7;
            this.mesajiçeriği.Text = "Merhabalar, Yarın Munzur Veteriner Kliniğinde Hayvanınızın  Muayenesi  vardır Bil" +
    "ginize İyi Günler . . .";
            this.mesajiçeriği.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(110, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mesaj  İçeriği :";
            // 
            // Gonder
            // 
            this.Gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gonder.Location = new System.Drawing.Point(267, 495);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(132, 48);
            this.Gonder.TabIndex = 8;
            this.Gonder.Text = "Mail Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // Sorgula
            // 
            this.Sorgula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sorgula.BackgroundImage")));
            this.Sorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sorgula.ImageKey = "aaa.png";
            this.Sorgula.Location = new System.Drawing.Point(417, 44);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(111, 38);
            this.Sorgula.TabIndex = 17;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(193, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 24);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hasta Adı:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(644, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Muayene Hasta Listesi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(110, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "E-posta:";
            // 
            // EPosta
            // 
            this.EPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EPosta.Location = new System.Drawing.Point(250, 226);
            this.EPosta.Name = "EPosta";
            this.EPosta.Size = new System.Drawing.Size(203, 21);
            this.EPosta.TabIndex = 54;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(85, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(443, 82);
            this.dataGridView.TabIndex = 55;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.Location = new System.Drawing.Point(459, 185);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(156, 20);
            this.label55.TabIndex = 154;
            this.label55.Text = "Gün Sonra Olucak";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.Location = new System.Drawing.Point(66, 185);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(179, 20);
            this.label43.TabIndex = 152;
            this.label43.Text = "Bir Sonraki Muayene:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelsaat
            // 
            this.labelsaat.AutoSize = true;
            this.labelsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelsaat.Location = new System.Drawing.Point(477, 525);
            this.labelsaat.Name = "labelsaat";
            this.labelsaat.Size = new System.Drawing.Size(24, 25);
            this.labelsaat.TabIndex = 169;
            this.labelsaat.Text = "0";
            this.labelsaat.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(458, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 168;
            this.label11.Text = "Saat";
            this.label11.Visible = false;
            // 
            // labeldakika
            // 
            this.labeldakika.AutoSize = true;
            this.labeldakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldakika.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldakika.Location = new System.Drawing.Point(165, 525);
            this.labeldakika.Name = "labeldakika";
            this.labeldakika.Size = new System.Drawing.Size(24, 25);
            this.labeldakika.TabIndex = 167;
            this.labeldakika.Text = "0";
            this.labeldakika.Visible = false;
            // 
            // labelsaniye
            // 
            this.labelsaniye.AutoSize = true;
            this.labelsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaniye.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelsaniye.Location = new System.Drawing.Point(55, 526);
            this.labelsaniye.Name = "labelsaniye";
            this.labelsaniye.Size = new System.Drawing.Size(24, 25);
            this.labelsaniye.TabIndex = 166;
            this.labelsaniye.Text = "0";
            this.labelsaniye.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(144, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 165;
            this.label2.Text = "Dakika";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(34, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 164;
            this.label6.Text = "Saniye";
            this.label6.Visible = false;
            // 
            // labelgün
            // 
            this.labelgün.AutoSize = true;
            this.labelgün.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelgün.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelgün.Location = new System.Drawing.Point(562, 526);
            this.labelgün.Name = "labelgün";
            this.labelgün.Size = new System.Drawing.Size(24, 25);
            this.labelgün.TabIndex = 171;
            this.labelgün.Text = "0";
            this.labelgün.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(551, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 170;
            this.label7.Text = "Gün";
            this.label7.Visible = false;
            // 
            // birsonrakimuayene
            // 
            this.birsonrakimuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birsonrakimuayene.Location = new System.Drawing.Point(250, 184);
            this.birsonrakimuayene.Name = "birsonrakimuayene";
            this.birsonrakimuayene.Size = new System.Drawing.Size(203, 21);
            this.birsonrakimuayene.TabIndex = 172;
            this.birsonrakimuayene.Text = "1";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 555);
            this.Controls.Add(this.birsonrakimuayene);
            this.Controls.Add(this.labelgün);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelsaat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labeldakika);
            this.Controls.Add(this.labelsaniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EPosta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Sorgula);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.mesajiçeriği);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.konu);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Mail";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Gonder;
        public System.Windows.Forms.TextBox konu;
        public System.Windows.Forms.TextBox mesajiçeriği;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox EPosta;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelsaat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labeldakika;
        private System.Windows.Forms.Label labelsaniye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelgün;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox birsonrakimuayene;
    }
}