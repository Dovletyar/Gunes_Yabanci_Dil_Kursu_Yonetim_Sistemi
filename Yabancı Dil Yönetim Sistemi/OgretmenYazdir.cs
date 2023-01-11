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
    public partial class OgretmenYazdir : Form
    {
        public OgretmenYazdir()
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

        private void OgretmenYazdir_Load(object sender, EventArgs e)
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
            YazdirDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        //ARAMA KOMUTLARI
        private void buttonAra_Click(object sender, EventArgs e)
        {
            //FİLTRELEME ARAMA
            baglanti.Open();
            string sorgu = "SELECT * FROM \"OgretmenTbl\" WHERE \"Adi Soyadi\" LIKE '%" + FilterTb.Text + "%' ";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            YazdirDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Yenile butonu
        private void buttonYenile_Click(object sender, EventArgs e)
        {
            FilterTb.Text = "";
            uyeler();
        }

        //Yazdırma işlemi
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.YazdirDGV.Columns["OgretmenId"].Visible = false;
            this.YazdirDGV.Columns["Resim"].Visible = false;
            Bitmap objBmp = new Bitmap(this.YazdirDGV.Width, this.YazdirDGV.Height);
            YazdirDGV.DrawToBitmap(objBmp, new Rectangle(0, 0, this.YazdirDGV.Width, this.YazdirDGV.Height));
            e.Graphics.DrawImage(objBmp, 3, 3);
        }

        //Yazdır butonu
        private void Yazdir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.ShowDialog();
        }
    }
}
