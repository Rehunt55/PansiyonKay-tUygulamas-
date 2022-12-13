using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proje1
{
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J0J1D1R\\SQLEXPRESS01;Initial Catalog=pansiyon;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from admingiris where kullanici=@kullaniciadi and sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", txtkullaniciadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    frmanasayfa fr = new frmanasayfa();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hatalý giriþ");
                throw;
            }
        }
    }
}