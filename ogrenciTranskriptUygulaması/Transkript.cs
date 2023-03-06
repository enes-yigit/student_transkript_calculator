using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciTranskriptUygulaması
{
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }

        //BAGLANTI
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;" + "Database=DBMS_project; user ID=postgres; password=1234");
        void listele()
        {
            string sorgu = "SELECT * FROM ders WHERE ders_not>0 order by ders_donem";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBirinciDonem_Click(object sender, EventArgs e)
        {
            // Listele
            string sorgu = "SELECT * FROM ders where ders_donem = '2021/1' and ders_not> 0";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            baglanti.Open();
            NpgsqlCommand birinciDonemGano = new NpgsqlCommand("SELECT ders_harfnot, ders_kredi FROM ders where ders_donem = '2021/1' and ders_not> 0", baglanti);

            double KarsılıkGelenNot = 0.0;
            double dersNotHesabı = 0.0;
            int toplamAlınanKredi = 0;
            double birinciDonemGanoHesap = 0.0;
            int derskredi = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                derskredi = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                toplamAlınanKredi += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                string HarfNot = dataGridView1.Rows[i].Cells[6].Value.ToString();

                if (HarfNot == "AA")
                    KarsılıkGelenNot = 4.0;
                else if (HarfNot == "BA")
                    KarsılıkGelenNot = 3.5;
                else if (HarfNot == "BB")
                    KarsılıkGelenNot = 3.0;
                else if (HarfNot == "CB")
                    KarsılıkGelenNot = 2.5;
                else if (HarfNot == "CC")
                    KarsılıkGelenNot = 2.0;
                else if (HarfNot == "DC")
                    KarsılıkGelenNot = 1.5;
                else if (HarfNot == "DD")
                    KarsılıkGelenNot = 1.0;
                else if (HarfNot == "FD")
                    KarsılıkGelenNot = 0.5;
                else if (HarfNot == "FF")
                    KarsılıkGelenNot = 0.0;

                dersNotHesabı += (KarsılıkGelenNot * derskredi);

                //MessageBox.Show("HarfNot: " + HarfNot);
                //MessageBox.Show("KarsılıkGelenNot: " + KarsılıkGelenNot);
                //MessageBox.Show("toplamAlınanKredi: " + toplamAlınanKredi);
                //MessageBox.Show("birinciDonemGanoHesap: " + birinciDonemGanoHesap);
            }
            birinciDonemGanoHesap = dersNotHesabı / toplamAlınanKredi;
            lblDonem.Text = "2021/1";
            lblGano.Text = birinciDonemGanoHesap.ToString();
            //MessageBox.Show("birinciDonemGanoHesap: " + birinciDonemGanoHesap);
            baglanti.Close();
        }

        private void btnIkkıncıDonem_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM ders where ders_donem = '2021/2' and ders_not> 0";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            baglanti.Open();
            NpgsqlCommand ikinciDonemGano = new NpgsqlCommand("SELECT ders_harfnot, ders_kredi FROM ders where ders_donem = '2021/2' and ders_not> 0", baglanti);



            double KarsılıkGelenNot = 0.0;
            double dersNotHesabı = 0.0;
            int toplamAlınanKredi = 0;
            double ikinciDonemGanoHesabı = 0.0;
            int derskredi = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                derskredi = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                toplamAlınanKredi += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                string HarfNot = dataGridView1.Rows[i].Cells[6].Value.ToString();
                if (HarfNot == "AA")
                    KarsılıkGelenNot = 4.0;
                else if (HarfNot == "BA")
                    KarsılıkGelenNot = 3.5;
                else if (HarfNot == "BB")
                    KarsılıkGelenNot = 3.0;
                else if (HarfNot == "CB")
                    KarsılıkGelenNot = 2.5;
                else if (HarfNot == "CC")
                    KarsılıkGelenNot = 2.0;
                else if (HarfNot == "DC")
                    KarsılıkGelenNot = 1.5;
                else if (HarfNot == "DD")
                    KarsılıkGelenNot = 1.0;
                else if (HarfNot == "FD")
                    KarsılıkGelenNot = 0.5;
                else if (HarfNot == "FF")
                    KarsılıkGelenNot = 0.0;


                dersNotHesabı += (KarsılıkGelenNot * derskredi);

            }
            ikinciDonemGanoHesabı = dersNotHesabı / toplamAlınanKredi;
            lblDonem.Text = "2021/2";
            lblGano.Text = ikinciDonemGanoHesabı.ToString();
            //MessageBox.Show("GANO: " + ikinciDonemGanoHesabı);

            baglanti.Close();

        }

        private void btnUcuncuDonem_Click(object sender, EventArgs e)
        {
            // Listele
            string sorgu = "SELECT * FROM ders where ders_donem = '2022/1' and ders_not> 0";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            baglanti.Open();
            NpgsqlCommand birinciDonemGano = new NpgsqlCommand("SELECT ders_harfnot, ders_kredi FROM ders where ders_donem = '2022/1' and ders_not> 0", baglanti);

            double KarsılıkGelenNot = 0.0;
            double dersNotHesabı = 0.0;
            int toplamAlınanKredi = 0;
            double ucuncuDonemGanoHesap = 0.0;
            int derskredi = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                derskredi = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                toplamAlınanKredi += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                string HarfNot = dataGridView1.Rows[i].Cells[6].Value.ToString();

                if (HarfNot == "AA")
                    KarsılıkGelenNot = 4.0;
                else if (HarfNot == "BA")
                    KarsılıkGelenNot = 3.5;
                else if (HarfNot == "BB")
                    KarsılıkGelenNot = 3.0;
                else if (HarfNot == "CB")
                    KarsılıkGelenNot = 2.5;
                else if (HarfNot == "CC")
                    KarsılıkGelenNot = 2.0;
                else if (HarfNot == "DC")
                    KarsılıkGelenNot = 1.5;
                else if (HarfNot == "DD")
                    KarsılıkGelenNot = 1.0;
                else if (HarfNot == "FD")
                    KarsılıkGelenNot = 0.5;
                else if (HarfNot == "FF")
                    KarsılıkGelenNot = 0.0;

                dersNotHesabı += (KarsılıkGelenNot * derskredi);

                //MessageBox.Show("HarfNot: " + HarfNot);
                //MessageBox.Show("KarsılıkGelenNot: " + KarsılıkGelenNot);
                //MessageBox.Show("toplamAlınanKredi: " + toplamAlınanKredi);
                //MessageBox.Show("birinciDonemGanoHesap: " + birinciDonemGanoHesap);
            }
            ucuncuDonemGanoHesap = dersNotHesabı / toplamAlınanKredi;
            lblDonem.Text = "2022/1";
            lblGano.Text = ucuncuDonemGanoHesap.ToString();
            //MessageBox.Show("birinciDonemGanoHesap: " + ucuncuDonemGanoHesap);
            baglanti.Close();
        }
        //Dorduncu Donem
        private void button3_Click(object sender, EventArgs e)
        {
            // Listele
            string sorgu = "SELECT * FROM ders where ders_donem = '2022/2' and ders_not> 0";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            baglanti.Open();
            NpgsqlCommand birinciDonemGano = new NpgsqlCommand("SELECT ders_harfnot, ders_kredi FROM ders where ders_donem = '2022/2' and ders_not> 0", baglanti);

            double KarsılıkGelenNot = 0.0;
            double dersNotHesabı = 0.0;
            int toplamAlınanKredi = 0;
            double dorduncuDonemGanoHesap = 0.0;
            int derskredi = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                derskredi = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                toplamAlınanKredi += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                string HarfNot = dataGridView1.Rows[i].Cells[6].Value.ToString();

                if (HarfNot == "AA")
                    KarsılıkGelenNot = 4.0;
                else if (HarfNot == "BA")
                    KarsılıkGelenNot = 3.5;
                else if (HarfNot == "BB")
                    KarsılıkGelenNot = 3.0;
                else if (HarfNot == "CB")
                    KarsılıkGelenNot = 2.5;
                else if (HarfNot == "CC")
                    KarsılıkGelenNot = 2.0;
                else if (HarfNot == "DC")
                    KarsılıkGelenNot = 1.5;
                else if (HarfNot == "DD")
                    KarsılıkGelenNot = 1.0;
                else if (HarfNot == "FD")
                    KarsılıkGelenNot = 0.5;
                else if (HarfNot == "FF")
                    KarsılıkGelenNot = 0.0;

                dersNotHesabı += (KarsılıkGelenNot * derskredi);

            }
            dorduncuDonemGanoHesap = dersNotHesabı / toplamAlınanKredi;
            lblDonem.Text = "2022/2";
            lblGano.Text = dorduncuDonemGanoHesap.ToString();
            //MessageBox.Show("birinciDonemGanoHesap: " + dorduncuDonemGanoHesap);
            baglanti.Close();
        }
        private void Transkript_Load(object sender, EventArgs e)
        {
            listele();
            baglanti.Open();
            NpgsqlCommand genelGano = new NpgsqlCommand("SELECT ders_harfnot, ders_kredi FROM ders where ders_not> 0", baglanti);

            double KarsılıkGelenNot = 0.0;
            double dersNotHesabı = 0.0;
            int toplamAlınanKredi = 0;
            double genelDonemGanoHesap = 0.0;
            int derskredi = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                derskredi = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                toplamAlınanKredi += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                string HarfNot = dataGridView1.Rows[i].Cells[6].Value.ToString();

                if (HarfNot == "AA")
                    KarsılıkGelenNot = 4.0;
                else if (HarfNot == "BA")
                    KarsılıkGelenNot = 3.5;
                else if (HarfNot == "BB")
                    KarsılıkGelenNot = 3.0;
                else if (HarfNot == "CB")
                    KarsılıkGelenNot = 2.5;
                else if (HarfNot == "CC")
                    KarsılıkGelenNot = 2.0;
                else if (HarfNot == "DC")
                    KarsılıkGelenNot = 1.5;
                else if (HarfNot == "DD")
                    KarsılıkGelenNot = 1.0;
                else if (HarfNot == "FD")
                    KarsılıkGelenNot = 0.5;
                else if (HarfNot == "FF")
                    KarsılıkGelenNot = 0.0;

                dersNotHesabı += (KarsılıkGelenNot * derskredi);
            }
            genelDonemGanoHesap = dersNotHesabı / toplamAlınanKredi;
            lblGano.Text = genelDonemGanoHesap.ToString();
            lblGenelGanonNot.Text = genelDonemGanoHesap.ToString();
            lblDonem.Text = "GENEL";
            baglanti.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfaDön_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void lblDonem_Click(object sender, EventArgs e)
        {

        }
    }
}