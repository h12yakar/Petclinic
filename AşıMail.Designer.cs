namespace Veteriner_Takip_Otomasyonu
{
    partial class AşıMail
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
            this.Sorgula = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.EPosta = new System.Windows.Forms.TextBox();
            this.Gonder = new System.Windows.Forms.Button();
            this.mesajiçeriği = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.konu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.Birsonrakiaşı = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.labelsaat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labeldakika = new System.Windows.Forms.Label();
            this.labelsaniye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelgün = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Sorgula
            // 
            this.Sorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sorgula.ImageKey = "aaa.png";
            this.Sorgula.Location = new System.Drawing.Point(420, 43);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(111, 38);
            this.Sorgula.TabIndex = 20;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(199, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 24);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hasta Adı:";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(86, 91);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(445, 82);
            this.dataGridView.TabIndex = 56;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(87, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "E-posta:";
            // 
            // EPosta
            // 
            this.EPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EPosta.Location = new System.Drawing.Point(230, 241);
            this.EPosta.Name = "EPosta";
            this.EPosta.Size = new System.Drawing.Size(203, 21);
            this.EPosta.TabIndex = 63;
            // 
            // Gonder
            // 
            this.Gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gonder.Location = new System.Drawing.Point(249, 509);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(132, 48);
            this.Gonder.TabIndex = 61;
            this.Gonder.Text = "Mail Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // mesajiçeriği
            // 
            this.mesajiçeriği.Location = new System.Drawing.Point(231, 355);
            this.mesajiçeriği.Multiline = true;
            this.mesajiçeriği.Name = "mesajiçeriği";
            this.mesajiçeriği.Size = new System.Drawing.Size(202, 141);
            this.mesajiçeriği.TabIndex = 60;
            this.mesajiçeriği.Text = "Merhabalar, Yarın Muznur Veteriner Kliniğinde Hayvanınızın Aşısı vardır Bilginize" +
    " İyi Günler . . .";
            this.mesajiçeriği.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Mesaj  İçeriği :";
            // 
            // konu
            // 
            this.konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konu.Location = new System.Drawing.Point(231, 297);
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(202, 20);
            this.konu.TabIndex = 58;
            this.konu.Text = "Aşı Bilgilendirme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Konu :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(648, 35);
            this.label5.TabIndex = 64;
            this.label5.Text = "Aşı Hasta Listesi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.Location = new System.Drawing.Point(434, 190);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(156, 20);
            this.label54.TabIndex = 129;
            this.label54.Text = "Gün Sonra Olucak";
            // 
            // Birsonrakiaşı
            // 
            this.Birsonrakiaşı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Birsonrakiaşı.Location = new System.Drawing.Point(230, 189);
            this.Birsonrakiaşı.Name = "Birsonrakiaşı";
            this.Birsonrakiaşı.Size = new System.Drawing.Size(203, 21);
            this.Birsonrakiaşı.TabIndex = 128;
            this.Birsonrakiaşı.Text = "1";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.Location = new System.Drawing.Point(87, 189);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(132, 20);
            this.label52.TabIndex = 127;
            this.label52.Text = "Bir Sonraki Aşı:";
            // 
            // labelsaat
            // 
            this.labelsaat.AutoSize = true;
            this.labelsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelsaat.Location = new System.Drawing.Point(503, 530);
            this.labelsaat.Name = "labelsaat";
            this.labelsaat.Size = new System.Drawing.Size(24, 25);
            this.labelsaat.TabIndex = 176;
            this.labelsaat.Text = "0";
            this.labelsaat.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(484, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 175;
            this.label11.Text = "Saat";
            this.label11.Visible = false;
            // 
            // labeldakika
            // 
            this.labeldakika.AutoSize = true;
            this.labeldakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldakika.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldakika.Location = new System.Drawing.Point(155, 530);
            this.labeldakika.Name = "labeldakika";
            this.labeldakika.Size = new System.Drawing.Size(24, 25);
            this.labeldakika.TabIndex = 174;
            this.labeldakika.Text = "0";
            this.labeldakika.Visible = false;
            // 
            // labelsaniye
            // 
            this.labelsaniye.AutoSize = true;
            this.labelsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaniye.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelsaniye.Location = new System.Drawing.Point(33, 531);
            this.labelsaniye.Name = "labelsaniye";
            this.labelsaniye.Size = new System.Drawing.Size(24, 25);
            this.labelsaniye.TabIndex = 173;
            this.labelsaniye.Text = "0";
            this.labelsaniye.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(134, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 172;
            this.label2.Text = "Dakika";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 171;
            this.label6.Text = "Saniye";
            this.label6.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelgün
            // 
            this.labelgün.AutoSize = true;
            this.labelgün.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelgün.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelgün.Location = new System.Drawing.Point(578, 531);
            this.labelgün.Name = "labelgün";
            this.labelgün.Size = new System.Drawing.Size(24, 25);
            this.labelgün.TabIndex = 178;
            this.labelgün.Text = "0";
            this.labelgün.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(567, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 177;
            this.label7.Text = "Gün";
            this.label7.Visible = false;
            // 
            // AşıMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 562);
            this.Controls.Add(this.labelgün);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelsaat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labeldakika);
            this.Controls.Add(this.labelsaniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.Birsonrakiaşı);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EPosta);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.mesajiçeriği);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.konu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Sorgula);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AşıMail";
            this.Text = "A";
            this.Load += new System.EventHandler(this.AşıMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox EPosta;
        private System.Windows.Forms.Button Gonder;
        public System.Windows.Forms.TextBox mesajiçeriği;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox konu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label54;
        public System.Windows.Forms.TextBox Birsonrakiaşı;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label labelsaat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labeldakika;
        private System.Windows.Forms.Label labelsaniye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelgün;
        private System.Windows.Forms.Label label7;
    }
}