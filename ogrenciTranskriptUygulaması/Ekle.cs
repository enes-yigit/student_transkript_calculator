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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
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
        private void Ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anasayfaDön_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            listele();

        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand("insert into ders (ders_kod, ders_ad, ders_donem, ders_kredi, ders_akts, ders_ogretmen, ders_harfnot )" +
                " values (@pKod, @pAd, @pDonem, @pKredi, @pAkts, @pOgretmen, @pHarfnot)",baglanti);
            komutEkle.Parameters.AddWithValue("@pKod", txtKod.Text);
            komutEkle.Parameters.AddWithValue("@pAd", txtAd.Text);
            komutEkle.Parameters.AddWithValue("@pDonem", txtDonem.Text);
            komutEkle.Parameters.AddWithValue("@pKredi", int.Parse(txtKredi.Text));
            komutEkle.Parameters.AddWithValue("@pAkts", int.Parse(txtAkts.Text));
            komutEkle.Parameters.AddWithValue("@pOgretmen", txtOgretmen.Text);
            komutEkle.Parameters.AddWithValue("@pHarfnot", txtNot.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
