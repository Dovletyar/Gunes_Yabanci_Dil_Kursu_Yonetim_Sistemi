using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using Npgsql;   //Kütüphane Ekliyoruz

namespace Yabancı_Dil_Yönetim_Sistemi
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        //SQL CONNECTION
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=KursDb; user ID=postgres; password=0210");


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void uyeler()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT * FROM \"OgrenciTbl\" ORDER BY \"OgrenciId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OgrenciDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        //Resim Seçme Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PictureBox.ImageLocation = openFileDialog1.FileName;
            ResimTb.Text=openFileDialog1.FileName;
        }

        //EKLE BUTONU
        private void button3_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || CinsiyetCb.Text == "" || DogumTarihiDTP.Text == "" || TelefonTb.Text == "" || EmailTb.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girdiniz, Lütfen Tekrar Kontrol Ediniz!");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT PROCEDURE KULLANIMI
                    baglanti.Open();
                    //string sorgu = "INSERT INTO \"OgrenciTbl\" (\"Adi Soyadi\", \"Cinsiyet\", \"Dogum Tarihi\", \"Telefon\", \"Email\", \"Adres\", \"Resim\" ) values('" + AdSoyadTb.Text + "','" + CinsiyetCb.Text + "','" + DogumTarihiDTP.Text + "','" + TelefonTb.Text + "', '" + EmailTb.Text + "','" + AdresTb.Text + "','" + ResimTb.Text + "')";
                    string sorgu2 = "call ogrenci_ekle(:_adsoyad,:_cinsiyet,:_dogumtarihi,:_telefon,:_email,:_adres,:_resim)";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu2, baglanti);
                    komut.Parameters.AddWithValue("_adsoyad", AdSoyadTb.Text);
                    komut.Parameters.AddWithValue("_cinsiyet", CinsiyetCb.Text);
                    komut.Parameters.AddWithValue("_dogumtarihi", DogumTarihiDTP.Text);
                    komut.Parameters.AddWithValue("_telefon", TelefonTb.Text);
                    komut.Parameters.AddWithValue("_email", EmailTb.Text);
                    komut.Parameters.AddWithValue("_adres", AdresTb.Text);
                    komut.Parameters.AddWithValue("_resim", ResimTb.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Bilgileri Başarıyla Kaydedildi!");
                    baglanti.Close();
                    uyeler();
                    buttonTemizle_Click(sender, e);

                }catch(Exception Ex)
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
            AdresTb.Text = "";
            ResimTb.Text = "";
            PictureBox.ImageLocation = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }























        private void OgrenciDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciTelefonTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
