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
    public partial class YeniKurs : Form
    {
        public YeniKurs()
        {
            InitializeComponent();
        }

        
        //SQL CONNECTION
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");



        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Geri tuşu
        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void YeniKurs_Load(object sender, EventArgs e)
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

        //EKLE BUTONU
        private void button3_Click(object sender, EventArgs e)
        {
            if (AdTb.Text==""||SaatTb.Text==""||KontenjanTb.Text=="")
            {
                MessageBox.Show("Kurs Bilgilerini Eksik Girdiniz, Lütfen Tekrar Kontrol Ediniz!");
            }
            else
            {
                try
                {
                    //SQL KOMUTLARI INSERT PROCEDURE KULLANIMI
                    baglanti.Open();
                    //string sorgu = "INSERT INTO \"KursTbl\" (\"Adi\", \"Saat\", \"Aciklama\", \"Kontenjan\") values('" + AdTb.Text + "','" + SaatTb.Text + "','" + AciklamaTb.Text + "','" + KontenjanTb.Text + "')";
                    string sorgu2 = "call kurs_ekle(:_adi,:_saati,:_aciklama,:_kontenjan)";
                    NpgsqlCommand komut = new NpgsqlCommand(sorgu2, baglanti);
                    komut.Parameters.AddWithValue("_adi", AdTb.Text);
                    komut.Parameters.AddWithValue("_saati", SaatTb.Text);
                    komut.Parameters.AddWithValue("_aciklama", AciklamaTb.Text);
                    komut.Parameters.AddWithValue("_kontenjan", KontenjanTb.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kurs Bilgileri Başarıyla Kaydedildi!");
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



        //Temizle butonu
        private void button2_Click(object sender, EventArgs e)
        {
            AdTb.Text = "";
            SaatTb.Text = "";
            AciklamaTb.Text = "";
            KontenjanTb.Text = "";
        }
    }
}
