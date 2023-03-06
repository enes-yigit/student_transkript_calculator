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
    public partial class Sil : Form
    {
        public Sil()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                NpgsqlCommand komutSil = new NpgsqlCommand("delete from ders where ders_kod=@pKod", baglanti);
                komutSil.Parameters.AddWithValue("@pKod", txtKod.Text);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme işlemi başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                listele();
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from ders";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Sil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
