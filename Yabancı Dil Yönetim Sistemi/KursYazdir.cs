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
    public partial class KursYazdir : Form
    {
        public KursYazdir()
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

        private void KursYazdir_Load(object sender, EventArgs e)
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
            kursYazdirDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        //Seçme
        private void kursYazdirDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //ARAMA KOMUTLARI
        private void buttonAra_Click(object sender, EventArgs e)
        {
            //FİLTRELEME ARAMA
            baglanti.Open();
            string sorgu = "SELECT * FROM \"KursTbl\" WHERE \"Adi\" LIKE '%" + FilterTb.Text + "%' ";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            kursYazdirDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        //Yenile Tuşu
        private void buttonYenile_Click(object sender, EventArgs e)
        {
            FilterTb.Text = "";
            uyeler();
        }

        //Yazdır Tuşu
        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        //Yazdırma işlemi
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.kursYazdirDGV.Columns["KursId"].Visible = false;
            Bitmap objBmp = new Bitmap(this.kursYazdirDGV.Width, this.kursYazdirDGV.Height);
            kursYazdirDGV.DrawToBitmap(objBmp, new Rectangle(0, 0, this.kursYazdirDGV.Width, this.kursYazdirDGV.Height));
            e.Graphics.DrawImage(objBmp, 3, 3);
        }
    }
}
