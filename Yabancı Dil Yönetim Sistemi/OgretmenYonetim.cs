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
    public partial class OgretmenYonetim : Form
    {
        public OgretmenYonetim()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");

        //Geri Tuşu
        private void labelGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void OgretmenYonetim_Load(object sender, EventArgs e)
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
            YonetimDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //SİLME KOMUTU DELETE
        int Ogrtmn;
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || CinsiyetCb.Text == "" || DogumTarihiDTP.Text == "" || TelefonTb.Text == "" || EmailTb.Text == "" || AlanTb.Text == "")
            {
                MessageBox.Show("Silinecek Öğretmeni Seçiniz");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT
                    Ogrtmn = Convert.ToInt32(YonetimDGV.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string sorgu = " DELETE FROM \"OgretmenTbl\" WHERE \"OgretmenId\"=" + Ogrtmn + "";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen Bilgileri Başarıyla Silindi!");
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

        //GÜNCELLEME KOMUTU UPDATE
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || CinsiyetCb.Text == "" || DogumTarihiDTP.Text == "" || TelefonTb.Text == "" || EmailTb.Text == "")
            {
                MessageBox.Show("Güncellenecek Öğrenciyi Seçiniz!");
            }
            else
            {
                try
                {
                    //SQL KOMUTU UPDATE
                    baglanti.Open();
                    string sorgu = "UPDATE \"OgretmenTbl\" SET \"Adi Soyadi\"='" + AdSoyadTb.Text + "', \"Cinsiyet\"='" + CinsiyetCb.Text + "', \"Dogum Tarihi\"='" + DogumTarihiDTP.Text + "', \"Telefon\"='" + TelefonTb.Text + "', \"Email\"='" + EmailTb.Text + "', \"Alani\"='" + AlanTb.Text + "', \"Adres\"='" + AdresTb.Text + "', \"Resim\"='" + ResimTb.Text + "'  WHERE \"OgretmenId\"=" + Ogrtmn + "; ";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen Bilgileri Başarıyla Güncellendi");
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

        //SEÇME
        private void YonetimDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ogrtmn = Convert.ToInt32(YonetimDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = YonetimDGV.SelectedRows[0].Cells[1].Value.ToString();
            CinsiyetCb.Text = YonetimDGV.SelectedRows[0].Cells[2].Value.ToString();
            DogumTarihiDTP.Text = YonetimDGV.SelectedRows[0].Cells[3].Value.ToString();
            TelefonTb.Text = YonetimDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmailTb.Text = YonetimDGV.SelectedRows[0].Cells[5].Value.ToString();
            AlanTb.Text = YonetimDGV.SelectedRows[0].Cells[6].Value.ToString();
            AdresTb.Text = YonetimDGV.SelectedRows[0].Cells[7].Value.ToString();
            ResimTb.Text = YonetimDGV.SelectedRows[0].Cells[8].Value.ToString();
            PictureBox.ImageLocation = YonetimDGV.SelectedRows[0].Cells[8].Value.ToString();

        }

        
        //Temizle Tuşu
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

        //ARAMA KOMUTU
        private void buttonAra_Click(object sender, EventArgs e)
        {
            //FİLTRELEME ARAMA
            baglanti.Open();
            string sorgu = "SELECT * FROM \"OgretmenTbl\" WHERE \"Adi Soyadi\" LIKE '%" + FilterTb.Text + "%' ";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            YonetimDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Yenile Tuşu
        private void buttonYenile_Click(object sender, EventArgs e)
        {
            FilterTb.Text = "";
            uyeler();
        }

        //Resim Seçme Butonu
        private void buttonResimSecme_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PictureBox.ImageLocation = openFileDialog1.FileName;
            ResimTb.Text = openFileDialog1.FileName;
        }


        ////Resim Seçme Butonu Eski
        //private void buttonResimSecme_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.ShowDialog();
        //    PictureBox.ImageLocation = openFileDialog1.FileName;
        //    ResimTb.Text = openFileDialog1.FileName;
        //}
    }
}
