using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Yabancı_Dil_Yönetim_Sistemi
{
    public partial class OgrenciYazdir : Form
    {
        public OgrenciYazdir()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");
        
        

        private void YazdirDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OgrenciYazdir_Load(object sender, EventArgs e)
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
            YazdirDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        //ARAMA KOMUTLARI
        private void button6_Click(object sender, EventArgs e)
        {
            //FİLTRELEME ARAMA
            baglanti.Open();
            string sorgu = "SELECT * FROM \"OgrenciTbl\" WHERE \"Adi Soyadi\" LIKE '%" + FilterTb.Text + "%' ";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            YazdirDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Yenile butonu
        private void button5_Click(object sender, EventArgs e)
        {
            FilterTb.Text = "";
            uyeler();
        }

        //Yazdırma işlemi
        private void OgrenciYazdirPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.YazdirDGV.Columns["OgrenciId"].Visible = false;
            this.YazdirDGV.Columns["Resim"].Visible = false;
            Bitmap objBmp = new Bitmap(this.YazdirDGV.Width, this.YazdirDGV.Height);
            YazdirDGV.DrawToBitmap(objBmp, new Rectangle(0,0,this.YazdirDGV.Width,this.YazdirDGV.Height));
            e.Graphics.DrawImage(objBmp, 3, 3);
            
        }

        //Yazdır butonu
        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciListesiPrintPreviewDialog.Document = OgrenciYazdirPrintDocument;
            OgrenciListesiPrintPreviewDialog.ShowDialog();
        }
    }
}
