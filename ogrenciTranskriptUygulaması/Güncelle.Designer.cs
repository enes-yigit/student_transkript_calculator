namespace ogrenciTranskriptUygulaması
{
    partial class Güncelle
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
            this.txtHarfNot = new System.Windows.Forms.TextBox();
            this.txtOgretmen = new System.Windows.Forms.TextBox();
            this.txtAkts = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // anasayfaDön
            // 
            this.anasayfaDön.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anasayfaDön.Location = new System.Drawing.Point(12, 427);
            this.anasayfaDön.Name = "anasayfaDön";
            this.anasayfaDön.Size = new System.Drawing.Size(471, 23);
            this.anasayfaDön.TabIndex = 0;
            this.anasayfaDön.Text = "Anasayfa";
            this.anasayfaDön.UseVisualStyleBackColor = false;
            this.anasayfaDön.Click += new System.EventHandler(this.anasayfaDön_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 438);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Location = new System.Drawing.Point(12, 398);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(471, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Görüntüle";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(109, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(249, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Güncellemek İstediğiniz Değerleri Giriniz";
            // 
            // txtHarfNot
            // 
            this.txtHarfNot.Enabled = false;
            this.txtHarfNot.Location = new System.Drawing.Point(157, 283);
            this.txtHarfNot.Name = "txtHarfNot";
            this.txtHarfNot.Size = new System.Drawing.Size(326, 20);
            this.txtHarfNot.TabIndex = 27;
            this.txtHarfNot.Tag = "";
            // 
            // txtOgretmen
            // 
            this.txtOgretmen.Location = new System.Drawing.Point(157, 226);
            this.txtOgretmen.Name = "txtOgretmen";
            this.txtOgretmen.Size = new System.Drawing.Size(326, 20);
            this.txtOgretmen.TabIndex = 26;
            this.txtOgretmen.Tag = "";
            // 
            // txtAkts
            // 
            this.txtAkts.Location = new System.Drawing.Point(157, 200);
            this.txtAkts.Name = "txtAkts";
            this.txtAkts.Size = new System.Drawing.Size(326, 20);
            this.txtAkts.TabIndex = 25;
            this.txtAkts.Tag = "";
            this.txtAkts.TextChanged += new System.EventHandler(this.txtAkts_TextChanged);
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(157, 174);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(326, 20);
            this.txtKredi.TabIndex = 24;
            this.txtKredi.Tag = "";
            // 
            // txtDonem
            // 
            this.txtDonem.Enabled = false;
            this.txtDonem.Location = new System.Drawing.Point(157, 148);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(326, 20);
            this.txtDonem.TabIndex = 23;
            this.txtDonem.Tag = "";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(157, 122);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(326, 20);
            this.txtAd.TabIndex = 22;
            this.txtAd.Tag = "";
            // 
            // txtKod
            // 
            this.txtKod.Enabled = false;
            this.txtKod.Location = new System.Drawing.Point(157, 96);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(326, 20);
            this.txtKod.TabIndex = 21;
            this.txtKod.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ders Harf Notu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "*Öğretim Görevlisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "*Ders AKTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "*Ders Dönem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "*Ders Kredi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "*Ders Ad ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "*Ders Kod";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.button1.Location = new System.Drawing.Point(157, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(12, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ders Notu";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(157, 253);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(326, 20);
            this.txtNot.TabIndex = 36;
            this.txtNot.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(12, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "(Harf Notu Otomatik Hesaplanmaktadır.)";
            // 
            // Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1229, 465);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHarfNot);
            this.Controls.Add(this.txtOgretmen);
            this.Controls.Add(this.txtAkts);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.anasayfaDön);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Güncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Güncelle_FormClosing);
            this.Load += new System.EventHandler(this.Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anasayfaDön;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHarfNot;
        private System.Windows.Forms.TextBox txtOgretmen;
        private System.Windows.Forms.TextBox txtAkts;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label10;
    }
}