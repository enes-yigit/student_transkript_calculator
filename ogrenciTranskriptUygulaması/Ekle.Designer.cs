namespace ogrenciTranskriptUygulaması
{
    partial class Ekle
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
            this.anasayfaDön = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtAkts = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtOgretmen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHarfNot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // anasayfaDön
            // 
            this.anasayfaDön.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anasayfaDön.Location = new System.Drawing.Point(713, 447);
            this.anasayfaDön.Name = "anasayfaDön";
            this.anasayfaDön.Size = new System.Drawing.Size(468, 33);
            this.anasayfaDön.TabIndex = 0;
            this.anasayfaDön.Text = "Anasayfa";
            this.anasayfaDön.UseVisualStyleBackColor = false;
            this.anasayfaDön.Click += new System.EventHandler(this.anasayfaDön_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 424);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Location = new System.Drawing.Point(713, 412);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(468, 29);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Görüntüle";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(815, 62);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eklemek İstediğiniz Değerleri Giriniz";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(855, 120);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(326, 20);
            this.txtKod.TabIndex = 6;
            this.txtKod.Tag = "";
            this.txtKod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(855, 146);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(326, 20);
            this.txtAd.TabIndex = 7;
            this.txtAd.Tag = "";
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(855, 172);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(326, 20);
            this.txtDonem.TabIndex = 8;
            this.txtDonem.Tag = "";
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(855, 198);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(326, 20);
            this.txtKredi.TabIndex = 9;
            this.txtKredi.Tag = "";
            // 
            // txtAkts
            // 
            this.txtAkts.Location = new System.Drawing.Point(855, 224);
            this.txtAkts.Name = "txtAkts";
            this.txtAkts.Size = new System.Drawing.Size(326, 20);
            this.txtAkts.TabIndex = 10;
            this.txtAkts.Tag = "";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.btnEkle.Location = new System.Drawing.Point(855, 330);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(326, 26);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtOgretmen
            // 
            this.txtOgretmen.Location = new System.Drawing.Point(855, 250);
            this.txtOgretmen.Name = "txtOgretmen";
            this.txtOgretmen.Size = new System.Drawing.Size(326, 20);
            this.txtOgretmen.TabIndex = 12;
            this.txtOgretmen.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(710, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Ders Kod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(710, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "*Ders Ad ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(710, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "*Ders Kredi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(710, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "*Ders Dönem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(710, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "*Ders AKTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(710, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "*Öğretim Görevlisi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(710, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ders Notu";
            // 
            // txtNot
            // 
            this.txtNot.Enabled = false;
            this.txtNot.Location = new System.Drawing.Point(855, 278);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(326, 20);
            this.txtNot.TabIndex = 20;
            this.txtNot.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(710, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "(  * olan alanları doldurmak zorunludur..  )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(710, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "(  ** Not Ekleme İşlemleri İçin Güncelleme Sayfasına Gidiniz  )";
            // 
            // txtHarfNot
            // 
            this.txtHarfNot.Enabled = false;
            this.txtHarfNot.Location = new System.Drawing.Point(855, 304);
            this.txtHarfNot.Name = "txtHarfNot";
            this.txtHarfNot.Size = new System.Drawing.Size(326, 20);
            this.txtHarfNot.TabIndex = 24;
            this.txtHarfNot.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label11.Location = new System.Drawing.Point(710, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ders Harf Notu";
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1247, 506);
            this.Controls.Add(this.txtHarfNot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgretmen);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAkts);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.anasayfaDön);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ekle_FormClosing);
            this.Load += new System.EventHandler(this.Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anasayfaDön;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtAkts;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtOgretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHarfNot;
        private System.Windows.Forms.Label label11;
    }
}