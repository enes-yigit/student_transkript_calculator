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
    public partial class Güncelle : Form
    {
        public Güncelle()
        {
            InitializeComponent();
        }
       

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;" +
   "Database=DBMS_project; user ID=postgres; password=1234");



        void listele()
        {
            string sorgu = "SELECT * FROM ders";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

   




        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutGüncelle = new NpgsqlCommand("UPDATE ders SET ders_ad=@pAd, ders_ogretmen=@pOgretmen,ders_akts=@pAkts, ders_kredi=@pKredi, ders_not=@pNot, ders_harfnot=@pHarfnot WHERE ders_kod=@pKod", baglanti);
            komutGüncelle.Parameters.AddWithValue("@pKod", txtKod.Text);
            komutGüncelle.Parameters.AddWithValue("@pAd", txtAd.Text);
            komutGüncelle.Parameters.AddWithValue("@pDonem", txtDonem.Text);
            komutGüncelle.Parameters.AddWithValue("@pKredi", int.Parse(txtKredi.Text));
            komutGüncelle.Parameters.AddWithValue("@pAkts", int.Parse(txtAkts.Text));
            komutGüncelle.Parameters.AddWithValue("@pOgretmen", txtOgretmen.Text);
            komutGüncelle.Parameters.AddWithValue("@pNot", Convert.ToInt32(txtNot.Text));
        /*    if (txtNot.Text != "")
            {
                komutGüncelle.Parameters.AddWithValue("@pNot", Convert.ToInt32(txtNot.Text));

            }
            else
                MessageBox.Show("HATA", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        */



            int puan = int.Parse(txtNot.Text);
                     
            if (puan  >= 90)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "AA");
            else if (puan >= 80)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "BA");
            else if (puan >= 70)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "BB");
            else if (puan >= 60)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "CB");
            else if (puan >= 53)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "CC");
            else if (puan >= 48)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "DC");
            else if (puan >= 40)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "DD");
            else if (puan >= 30)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "FD");
            else if (puan > 30)
                komutGüncelle.Parameters.AddWithValue("@pHarfnot", "FF");
            

            komutGüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }







        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDonem.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKredi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAkts.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtOgretmen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtHarfNot.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtNot.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();   
        }
        private void anasayfaDön_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void txtAkts_TextChanged(object sender, EventArgs e)
        {

        }
        private void Güncelle_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void Güncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
// ders_harfnot=@pHarfnot 