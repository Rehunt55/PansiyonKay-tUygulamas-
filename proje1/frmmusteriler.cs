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
using System.Drawing.Text;

namespace proje1
{
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J0J1D1R\\SQLEXPRESS01;Initial Catalog=pansiyon;Integrated Security=True");
            
            private void verilergoster()
            {
            listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from musteriekle", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["musteriid"].ToString();
                    ekle.SubItems.Add(oku["adi"].ToString());
                    ekle.SubItems.Add(oku["soyadi"].ToString());
                    ekle.SubItems.Add(oku["telefon"].ToString());
                    ekle.SubItems.Add(oku["mail"].ToString());
                    ekle.SubItems.Add(oku["tc"].ToString());
                    ekle.SubItems.Add(oku["odano"].ToString());
                    ekle.SubItems.Add(oku["ucret"].ToString());
                    ekle.SubItems.Add(oku["giristarihi"].ToString());
                    ekle.SubItems.Add(oku["cikistarihi"].ToString());

                    listView1.Items.Add(ekle);
                }
                baglanti.Close();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtodano.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "201")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda201 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "202")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda202 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "203")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda203 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "301")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda301 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "302")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda302 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "303")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda303 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "401")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda401 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "402")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda402 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtodano.Text == "403")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda403 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            msktxttelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txttcno.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[9].Text;
            
           

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            msktxttelefon.Clear();
            txtmail.Clear();
            txttcno.Clear();
            txtodano.Clear();
            txtucret.Clear();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriekle set adi='" + txtadi.Text + "',soyadi='" + txtsoyadi.Text + "',telefon='" + msktxttelefon.Text + "',mail='"+txtmail.Text+"',tc='"+txttcno.Text+"',odano='"+txtodano.Text+"',ucret='"+txtucret.Text+"',giristarihi='"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"',cikistarihi='"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"' where musteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriekle where adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
    }

