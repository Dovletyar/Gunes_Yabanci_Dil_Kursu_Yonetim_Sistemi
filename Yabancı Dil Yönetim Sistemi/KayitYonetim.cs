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
    public partial class KayitYonetim : Form
    {
        public KayitYonetim()
        {
            InitializeComponent();
        }

        //SQL CONNECTION
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");


        //Geri tuşu
        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void KayitYonetim_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void uyeler()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT * FROM \"KursTbl\" ORDER BY \"KursId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            KursDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        //SİLME KOMUTU
        int KursKey;
        private void button3_Click(object sender, EventArgs e)
        {
            if (AdTb.Text == "" || SaatTb.Text == "" || KontenjanTb.Text == "")
            {
                MessageBox.Show("Silinecek Kursu Seçiniz");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT
                    KursKey = Convert.ToInt32(KursDGV.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string sorgu = " DELETE FROM \"KursTbl\" WHERE \"KursId\"=" + KursKey + "";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kurs Bilgileri Başarıyla Silindi!");
                    baglanti.Close();
                    uyeler();
                    button2_Click(sender, e);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //GÜNCELLEME KOMUTU
        private void button4_Click(object sender, EventArgs e)
        {
            if (AdTb.Text == "" || SaatTb.Text == "" || KontenjanTb.Text == "")
            {
                MessageBox.Show("Güncellenecek Kursu Seçiniz!");
            }
            else
            {
                try
                {
                    //SQL KOMUTU UPDATE
                    baglanti.Open();
                    string sorgu = "UPDATE \"KursTbl\" SET \"Adi\"='" + AdTb.Text + "', \"Saat\"='" + SaatTb.Text + "', \"Aciklama\"='" + AciklamaTb.Text + "', \"Kontenjan\"='" + KontenjanTb.Text + "'  WHERE \"KursId\"=" + KursKey + "; ";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kurs Bilgileri Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                    button2_Click(sender, e);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //Temizle Tuşu
        private void button2_Click(object sender, EventArgs e)
        {
            AdTb.Text = "";
            SaatTb.Text = "";
            AciklamaTb.Text = "";
            KontenjanTb.Text = "";
        }

        //SEÇME
        private void KursDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            KursKey = Convert.ToInt32(KursDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdTb.Text = KursDGV.SelectedRows[0].Cells[1].Value.ToString();
            SaatTb.Text = KursDGV.SelectedRows[0].Cells[2].Value.ToString();
            AciklamaTb.Text = KursDGV.SelectedRows[0].Cells[3].Value.ToString();
            KontenjanTb.Text = KursDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        //Arama Tuşu
        private void button6_Click(object sender, EventArgs e)
        {
            //FİLTRELEME ARAMA
            baglanti.Open();
            string sorgu = "SELECT * FROM \"KursTbl\" WHERE \"Adi\" LIKE '%" + FilterTb.Text + "%' ";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            KursDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Yenile Tuşu
        private void button5_Click(object sender, EventArgs e)
        {
            FilterTb.Text = "";
            uyeler();
        }


        

        
    }
}
