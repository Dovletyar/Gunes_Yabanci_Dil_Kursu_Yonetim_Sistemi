using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Yabancı_Dil_Yönetim_Sistemi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //SQL CONNECTION
        //NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");
        
        NpgsqlConnection con;
        NpgsqlDataReader dr;
        NpgsqlCommand com;



        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string user = KullaniciTb.Text;
            string password = SifreTb.Text;
            con = new NpgsqlConnection("server=localHost; port=5432; Database=KursDb; user ID=postgres; password=0210");
            com = new NpgsqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From \"KullaniciBilgisi\" Where \"kullanici_adi\"='" + KullaniciTb.Text + "' And \"sifre\"='" + SifreTb.Text + "' ";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            con.Close();

        }
    }
}
