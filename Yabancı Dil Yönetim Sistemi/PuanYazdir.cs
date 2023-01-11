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
    public partial class PuanYazdir : Form
    {
        public PuanYazdir()
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

        private void PuanYazdir_Load(object sender, EventArgs e)
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

        //Yazdır Tuşu
        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        //Yazdırma işlemi
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.DGV.Columns["AldigiDerslerId"].Visible = false;
            Bitmap objBmp = new Bitmap(this.DGV.Width, this.DGV.Height);
            DGV.DrawToBitmap(objBmp, new Rectangle(0, 0, this.DGV.Width, this.DGV.Height));
            e.Graphics.DrawImage(objBmp, 3, 3);
        }
    }
}
