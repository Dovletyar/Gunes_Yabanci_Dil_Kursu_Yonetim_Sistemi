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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            PanelDesign();
        }

        //SQL CONNECTION
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=KursDb; user ID=postgres; password=0210");


        private void Form1_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void uyeler()
        {
            //SQL KOMUTLARI SELECT
            baglanti.Open();
            string sorgu = "SELECT * FROM \"ToplamOgrenciSayisiTbl\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }




        private void PanelDesign()
        {
            panel_ogrenciMenu.Visible = false;
            panel_kursMenu.Visible=false;
            panel_puanMenu.Visible = false;
            panel_ogretmenMenu.Visible = false;
        }
        private void HideMenu()
        {
            if(panel_ogrenciMenu.Visible==true)
                panel_ogrenciMenu.Visible=false;
            if(panel_kursMenu.Visible==true)
                panel_kursMenu.Visible = false;
            if(panel_puanMenu.Visible==true)
                panel_puanMenu.Visible=false;
            if (panel_ogretmenMenu.Visible == true)
                panel_ogretmenMenu.Visible = false;
        }
        private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void button_ogrenci_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_ogrenciMenu);
        }

        private void button_ogrenciKayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void button_ogrenciYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYonetim ogry = new OgrenciYonetim();
            ogry.Show();
            this.Hide();
        }

        private void button_ogrenciIcerik_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_ogrenciYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYazdir ogry = new OgrenciYazdir();
            ogry.Show();
            this.Hide();
        }

        private void button_kurs_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_kursMenu);
        }

        private void button_kursKayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniKurs kkayit = new YeniKurs();
            kkayit.Show();
            this.Hide();
        }

        private void button_kursYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            KayitYonetim kyonetim = new KayitYonetim();
            kyonetim.Show();
            this.Hide();
        }

        private void button_kursYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            KursYazdir kyazdir = new KursYazdir();
            kyazdir.Show();
            this.Hide();
        }

        private void button_puanlar_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_puanMenu);
        }

        private void button_yeniPuan_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniPuan ypuan = new YeniPuan();
            ypuan.Show();
            this.Hide();
        }

        private void button_puanYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYonetim pyonetim = new PuanYonetim();
            pyonetim.Show();
            this.Hide();
        }

        private void button_puanYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYazdir pyazdir = new PuanYazdir();
            pyazdir.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_ogretmen_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_ogretmenMenu);
        }

        private void button_yeniOgretmen_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgretmenKayit okayit = new OgretmenKayit();
            okayit.Show();
            this.Hide();
        }

        private void button_ogretmenYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgretmenYonetim oyonetim = new OgretmenYonetim();
            oyonetim.Show();
            this.Hide();
        }

        private void button_ogretmenYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgretmenYazdir oyazdir = new OgretmenYazdir();
            oyazdir.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_cıkıs_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
