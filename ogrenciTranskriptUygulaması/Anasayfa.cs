using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciTranskriptUygulaması
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
//database baglama işlemleri

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;" +
            "Database=DBMS_project; user ID=postgres; password=1234");

        void listele()
        {
            string sorgu = "select * from ders";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           listele();
        }

        private void frmEkle_Click(object sender, EventArgs e)
        {
            Ekle ekleSayfasinaGecis = new Ekle();
            ekleSayfasinaGecis.Show();
            this.Hide();
            
        }

        private void frmSil_Click(object sender, EventArgs e)
        {
            Sil silmeSayfasinaGecis = new Sil();
            silmeSayfasinaGecis.Show();
            this.Hide();

        }

        private void frmGüncelle_Click(object sender, EventArgs e)
        {
            Güncelle güncelleSayfasınaGeciş = new Güncelle();
            güncelleSayfasınaGeciş.Show();
            this.Hide();
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transkript transkriptSayfasınaGecis = new Transkript();
            transkriptSayfasınaGecis.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
