using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Yabancı_Dil_Yönetim_Sistemi
{
    public partial class PuanYonetim : Form
    {
        public PuanYonetim()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");


        //Geri Tuşu
        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void PuanYonetim_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void uyeler()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT \"ADI\".\"AldigiDerslerId\" AS \"ID\", \"OGR\".\"OgrenciId\" AS \"OgrId\", \"OGR\".\"Adi Soyadi\", \"OGR\".\"Cinsiyet\", \"K\".\"KursId\", \"K\".\"Adi\" as \"Kurs Adı\", \"ADI\".\"Puan\", \"OGRT\".\"OgretmenId\" as \"OgrtId\", \"OGRT\".\"Adi Soyadi\" as \"OgrtAdiSoyadi\", \"ADI\".\"Aciklama\"     " +
                           "FROM \"AldigiDerslerTbl\" AS \"ADI\"                " +
                           "INNER JOIN \"OgrenciTbl\" AS \"OGR\"                " +
                           "ON \"ADI\".\"Ogrenci\" = \"OGR\".\"OgrenciId\"      " +
                           "INNER JOIN \"KursTbl\" AS \"K\"                     " +
                           "ON \"ADI\".\"Kurs\" = \"K\".\"KursId\"              " +
                           "LEFT JOIN \"OgretmenTbl\" AS \"OGRT\"               " +
                           "ON \"ADI\".\"Ogretmen\" = \"OGRT\".\"OgretmenId\"   " +
                           "ORDER BY \"ADI\".\"AldigiDerslerId\"                ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        int AldigiDerslerKey;

        //SEÇME
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AldigiDerslerKey = Convert.ToInt32(DGV.SelectedRows[0].Cells[0].Value.ToString());
            AldigiDersIdTb.Text = DGV.SelectedRows[0].Cells[0].Value.ToString();
            OgrenciIdTb.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
            OgrenciAdiSoyadiTb.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
            OgrenciCinsiyetTb.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();

            KursIdTb.Text = DGV.SelectedRows[0].Cells[4].Value.ToString();
            KursAdTb.Text = DGV.SelectedRows[0].Cells[5].Value.ToString();

            PuanTb.Text = DGV.SelectedRows[0].Cells[6].Value.ToString();
            OgretmenIdTb.Text = DGV.SelectedRows[0].Cells[7].Value.ToString();
            AciklamaTb.Text = DGV.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void OgretmenAdiSoyadiTb_TextChanged(object sender, EventArgs e)
        {

        }

        //GÜNCELLEME KOMUTU UPDATE
        private void button4_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || KursIdTb.Text == "")
            {
                MessageBox.Show("Güncellenecek Verileri Seçiniz!");
            }
            else
            {
                try
                {
                    //SQL KOMUTU UPDATE
                    baglanti.Open();
                    string sorgu = "UPDATE \"AldigiDerslerTbl\" SET \"Ogrenci\"='" + OgrenciIdTb.Text + "', \"Kurs\"='" + KursIdTb.Text + "', \"Aciklama\"='" + AciklamaTb.Text + "', \"Ogretmen\"='" + OgretmenIdTb.Text + "', \"Puan\"='" + PuanTb.Text + "'  WHERE \"AldigiDerslerId\"=" + AldigiDerslerKey + "; ";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ders Verileri Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                    buttonTemizle_Click(sender, e);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //SİLME KOMUTU
        private void button3_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || KursIdTb.Text == "")
            {
                MessageBox.Show("Silinecek Verileri Seçiniz");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT
                    AldigiDerslerKey = Convert.ToInt32(DGV.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string sorgu = " DELETE FROM \"AldigiDerslerTbl\" WHERE \"AldigiDerslerId\"=" + AldigiDerslerKey + "";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ders Verileri Başarıyla Silindi!");
                    baglanti.Close();
                    uyeler();
                    buttonTemizle_Click(sender, e);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //Temizle Tuşu
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            OgrenciIdTb.Text = "";
            OgrenciAdiSoyadiTb.Text = "";
            OgrenciCinsiyetTb.Text = "";

            KursIdTb.Text = "";
            KursAdTb.Text = "";

            PuanTb.Text = "";
            AciklamaTb.Text = "";

        }

        
    }
}
