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
using System.ComponentModel.Design;

namespace proje1
{
    public partial class frmstokcs : Form
    {
        public frmstokcs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J0J1D1R\\SQLEXPRESS01;Initial Catalog=pansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
             baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from alinanurunler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["gida"].ToString();
                ekle.SubItems.Add(oku["içecek"].ToString());
                ekle.SubItems.Add(oku["çerezler"].ToString());
                 
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["elektrik"].ToString();
                ekle.SubItems.Add(oku2["su"].ToString());
                ekle.SubItems.Add(oku2["internet"].ToString());

                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into alinanurunler(gıda,içecek,çerezler) values('" + txtgıdatutar.Text + "','" + txtiçecektut.Text + "','" + txtatıştı.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void frmstokcs_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnkaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into faturalar(elektrik,su,internet) values('" + txtelektrik.Text + "','" + txtsu.Text + "','" + txtint.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
