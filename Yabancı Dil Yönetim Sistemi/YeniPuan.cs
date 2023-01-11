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
    public partial class YeniPuan : Form
    {
        public YeniPuan()
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

        

        private void YeniPuan_Load(object sender, EventArgs e)
        {
            ogrenciGetir();
            kursGetir();
            ogretmenGetir();
        }


        private void ogrenciGetir()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT \"OgrenciId\" AS ID, \"Adi Soyadi\", \"Cinsiyet\", \"Dogum Tarihi\", \"Resim\"          " +
                " FROM \"OgrenciTbl\" ORDER BY \"OgrenciId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OgrenciBilgileriDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void kursGetir()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT * FROM \"KursTbl\" ORDER BY \"KursId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            KursBilgileriDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void ogretmenGetir()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT \"OgretmenId\" AS ID, \"Adi Soyadi\", \"Cinsiyet\", \"Alani\"         " +
                " FROM \"OgretmenTbl\" ORDER BY \"OgretmenId\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OgretmenBilgileriDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }







        int OgrDersKayitKey;
        int KursaKayitKey;
        int OgrtDersKayitKey;

        //Öğrenci Bilgilerini Seçme
        private void OgrenciBilgileriDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgrDersKayitKey = Convert.ToInt32(OgrenciBilgileriDGV.SelectedRows[0].Cells[0].Value.ToString());
            OgrenciIdTb.Text = OgrenciBilgileriDGV.SelectedRows[0].Cells[0].Value.ToString();
            OgrenciAdiSoyadiTb.Text = OgrenciBilgileriDGV.SelectedRows[0].Cells[1].Value.ToString();
            OgrenciCinsiyetTb.Text = OgrenciBilgileriDGV.SelectedRows[0].Cells[2].Value.ToString();
            OgrenciDogumTarihiTb.Text = OgrenciBilgileriDGV.SelectedRows[0].Cells[3].Value.ToString();
        }


        //Kurs Bilgilerini Seçme
        private void KursBilgileriDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            KursaKayitKey = Convert.ToInt32(KursBilgileriDGV.SelectedRows[0].Cells[0].Value.ToString());
            KursIdTb.Text = KursBilgileriDGV.SelectedRows[0].Cells[0].Value.ToString();
            KursAdTb.Text = KursBilgileriDGV.SelectedRows[0].Cells[1].Value.ToString();
            KursSaatTb.Text = KursBilgileriDGV.SelectedRows[0].Cells[2].Value.ToString();
            //KursAciklamaTb.Text = KursBilgileriDGV.SelectedRows[0].Cells[3].Value.ToString();
            KursKontenjanTb.Text = KursBilgileriDGV.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        //Öğretmen Bilgilerini Seçme
        private void OgretmenBilgileriDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OgrtDersKayitKey = Convert.ToInt32(OgretmenBilgileriDGV.SelectedRows[0].Cells[0].Value.ToString());
            OgretmenIdTb.Text = OgretmenBilgileriDGV.SelectedRows[0].Cells[0].Value.ToString();
            OgretmenAdiSoyadiTb.Text = OgretmenBilgileriDGV.SelectedRows[0].Cells[1].Value.ToString();
            OgretmenAlaniTb.Text = OgretmenBilgileriDGV.SelectedRows[0].Cells[3].Value.ToString();

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KursSaatTb_TextChanged(object sender, EventArgs e)
        {

        }


        //Kursa Kaydet Butonu
        private void buttonKursaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //SQL KOMUTLARI INSERT PROCEDURE KULLANIMI
                baglanti.Open();
                string sorgu = "INSERT INTO \"AldigiDerslerTbl\" (\"Ogrenci\", \"Kurs\", \"Ogretmen\") values('" + OgrenciIdTb.Text + "','" + KursIdTb.Text + "','" + OgretmenIdTb.Text + "')";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ders Kayıt İşlemi Başarılı!");
                baglanti.Close();
                ogrenciGetir();
                kursGetir();
                button2_Click(sender, e);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //Temizle Tuşu
        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciIdTb.Text = "";
            OgrenciAdiSoyadiTb.Text = "";
            OgrenciCinsiyetTb.Text = "";
            OgrenciDogumTarihiTb.Text = "";

            KursIdTb.Text = "";
            KursAdTb.Text = "";
            KursSaatTb.Text = "";
            KursKontenjanTb.Text = "";

            OgretmenIdTb.Text = "";
            OgretmenAdiSoyadiTb.Text = "";
            OgretmenAlaniTb.Text = "";
        }
    }
}
