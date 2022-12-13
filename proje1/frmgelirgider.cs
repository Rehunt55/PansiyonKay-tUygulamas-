using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proje1
{
    public partial class frmgelirgid : Form
    {
        public frmgelirgid()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J0J1D1R\\SQLEXPRESS01;Initial Catalog=pansiyon;Integrated Security=True");
      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(txtpersonelsayı.Text);
            lblpersonelmaas.Text = (personel * 5500).ToString();

            int sonuç;
            sonuç=Convert.ToInt32(lblkasatoplam.Text) - (Convert.ToInt32(lblpersonelmaas.Text)+Convert.ToInt32(lblgıda.Text)+Convert.ToInt32(lbliç.Text)+Convert.ToInt32(lblatıştır.Text)+Convert.ToInt32(lblelektrik.Text)+Convert.ToInt32(lblsu.Text)+Convert.ToInt32(lblinternet.Text));
            lblsonuc.Text = sonuç.ToString();
        }
        private void frmgelirgid_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(ucret) as toplam from musteriekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //gıda giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(gida) as toplam1 from alinanurunler", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                lblgıda.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //içecek giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(içecek) as toplam2 from alinanurunler", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                lbliç.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //çerez giderleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(çerezler) as toplam3 from alinanurunler", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                lblatıştır.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();


            //elektrik giderleri
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(elektrik) as toplam4 from faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                lblelektrik.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();


            //su giderleri
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(su) as toplam5 from faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                lblsu.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();


            //internet giderleri
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(internet) as toplam6 from faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                lblinternet.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
        }
    }
    }

