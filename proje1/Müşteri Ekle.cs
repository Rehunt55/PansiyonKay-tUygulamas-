using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace proje1
{
    public partial class frmmusteriekle : Form
    {
        public frmmusteriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J0J1D1R\\SQLEXPRESS01;Initial Catalog=pansiyon;Integrated Security=True");

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda101 (adi,soyadi) values ('"+txtadi.Text+"','"+txtsoyadi.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda102 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda103 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtodano.Text = "201";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtodano.Text = "202";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtodano.Text = "203";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtodano.Text = "301";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtodano.Text = "302";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtodano.Text = "303";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtodano.Text = "401";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtodano.Text = "402";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtodano.Text = "403";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mavi renkli butonlar dolu odaları gösterir.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gri renkli butonlar boş odaları gösterir");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyuktarih = Convert.ToDateTime(dateTimePicker2.Text);


            //TimeSpan=iki tarih arasındaki farkı alır.
            TimeSpan sonuc; 
                sonuc= buyuktarih - kucuktarih;

            label10.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label10.Text)*50;
            txtucret.Text=ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)        //sqlde truncate table musteriekle tabloyu temizler.
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteriekle (adi,soyadi,telefon,mail,tc,odano,ucret,giristarihi,cikistarihi) values('"+txtadi.Text+"','"+txtsoyadi.Text+"','"+msktxttelefon.Text+"','"+txtmail.Text+"','"+txttcno.Text+"','"+txtodano.Text+"','"+txtucret.Text+"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"','"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("müşteri kaydı yapıldı");
        }

        private void frmmusteriekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda302", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn302.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn302.Text != "302")
            {
                btn302.BackColor = Color.Red;
                btn302.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn103.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda203", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn203.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            if (btn203.Text != "203")
            {
                btn203.BackColor = Color.Red;
                btn203.Enabled = false;
            }
        }
        }
    }

