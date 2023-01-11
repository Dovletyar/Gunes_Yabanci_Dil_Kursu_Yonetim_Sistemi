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
    public partial class OgrenciYonetim : Form
    {
        public OgrenciYonetim()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");

        private void OgrenciYonetim_Load(object sender, EventArgs e)
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
            YonetimDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        //SİLME KOMUTU
        int OgrKey;
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || CinsiyetCb.Text == "" || DogumTarihiDTP.Text == "" || TelefonTb.Text == "" || EmailTb.Text == "")
            {
                MessageBox.Show("Silinecek Öğrenciyi Seçiniz");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT
                    OgrKey = Convert.ToInt32(YonetimDGV.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string sorgu = " DELETE FROM \"OgrenciTbl\" WHERE \"OgrenciId\"="+OgrKey+"";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Silindi!");
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
            OgrKey = Convert.ToInt32(YonetimDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = YonetimDGV.SelectedRows[0].Cells[1].Value.ToString();
            CinsiyetCb.Text = YonetimDGV.SelectedRows[0].Cells[2].Value.ToString();
            DogumTarihiDTP.Text = YonetimDGV.SelectedRows[0].Cells[3].Value.ToString();
            TelefonTb.Text = YonetimDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmailTb.Text = YonetimDGV.SelectedRows[0].Cells[5].Value.ToString();
            AdresTb.Text = YonetimDGV.SelectedRows[0].Cells[6].Value.ToString();
            ResimTb.Text = YonetimDGV.SelectedRows[0].Cells[7].Value.ToString();
            PictureBox.ImageLocation = YonetimDGV.SelectedRows[0].Cells[7].Value.ToString();

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
                    string sorgu = "UPDATE \"OgrenciTbl\" SET \"Adi Soyadi\"='"+AdSoyadTb.Text+"', \"Cinsiyet\"='"+CinsiyetCb.Text+"', \"Dogum Tarihi\"='"+DogumTarihiDTP.Text+"', \"Telefon\"='"+TelefonTb.Text+ "', \"Email\"='"+EmailTb.Text+ "', \"Adres\"='"+AdresTb.Text+ "', \"Resim\"='"+ResimTb.Text+ "'  WHERE \"OgrenciId\"="+OgrKey+"; ";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                    buttonTemizle_Click(sender, e);

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //Geri tuşu
        private void labelGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }


        //Resim Seçme Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PictureBox.ImageLocation = openFileDialog1.FileName;
            ResimTb.Text = openFileDialog1.FileName;
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
            string sorgu = "SELECT * FROM \"OgrenciTbl\" WHERE \"Adi Soyadi\" LIKE '%"+FilterTb.Text+"%' ";
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

        private void YonetimDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
