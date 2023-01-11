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
    public partial class OgretmenKayit : Form
    {
        public OgretmenKayit()
        {
            InitializeComponent();
        }

        //SQL CONNECTION
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");

        //Geri Tuşu
        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void OgretmenKayit_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void uyeler()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT * FROM \"OgretmenTbl\" ORDER BY \"OgretmenId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OgretmenDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //EKLE BUTONU
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || CinsiyetCb.Text == "" || DogumTarihiDTP.Text == "" || TelefonTb.Text == "" || EmailTb.Text == "" || AlanTb.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girdiniz, Lütfen Tekrar Kontrol Ediniz!");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT PROCEDURE KULLANIMI
                    baglanti.Open();
                    //string sorgu = "INSERT INTO \"OgretmenTbl\" (\"Adi Soyadi\", \"Cinsiyet\", \"Dogum Tarihi\", \"Telefon\", \"Email\", \"Alani\", \"Adres\", \"Resim\" ) values('" + AdSoyadTb.Text + "','" + CinsiyetCb.Text + "','" + DogumTarihiDTP.Text + "','" + TelefonTb.Text + "', '" + EmailTb.Text + "', '" + AlanTb.Text + "', '" + AdresTb.Text + "','" + ResimTb.Text + "')";
                    string sorgu2 = "call ogretmen_ekle(:_adsoyad,:_cinsiyet,:_dogumtarihi,:_telefon,:_email,:_alani,:_adres,:_resim)";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu2, baglanti);
                    komut.Parameters.AddWithValue("_adsoyad", AdSoyadTb.Text);
                    komut.Parameters.AddWithValue("_cinsiyet", CinsiyetCb.Text);
                    komut.Parameters.AddWithValue("_dogumtarihi", DogumTarihiDTP.Text);
                    komut.Parameters.AddWithValue("_telefon", TelefonTb.Text);
                    komut.Parameters.AddWithValue("_email", EmailTb.Text);
                    komut.Parameters.AddWithValue("_alani", AlanTb.Text);
                    komut.Parameters.AddWithValue("_adres", AdresTb.Text);
                    komut.Parameters.AddWithValue("_resim", ResimTb.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen Bilgileri Başarıyla Kaydedildi!");
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

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            CinsiyetCb.Text = "";
            DogumTarihiDTP.Text = "";
            TelefonTb.Text = "";
            EmailTb.Text = "";
            AlanTb.Text = "";
            AdresTb.Text = "";
            ResimTb.Text = "";
            PictureBox.ImageLocation = "";
        }

        //Resim Seçme Tuşu
        private void buttonResimSecme_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PictureBox.ImageLocation = openFileDialog1.FileName;
            ResimTb.Text = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
