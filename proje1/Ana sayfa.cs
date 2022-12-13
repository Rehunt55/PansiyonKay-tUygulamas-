using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmadmingiris fr = new frmadmingiris();
            fr.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmusteriekle fr = new frmmusteriekle();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmodalar fr = new frmodalar();
            fr.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmmusteriler fr=new frmmusteriler();
            fr.Show();
            
            
        }

        private void btnhak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pansiyonumuza hoşgeldiniz");
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpersonelmaas_Click(object sender, EventArgs e)
        {
            frmgelirgid fr = new frmgelirgid();
            fr.Show();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            frmstokcs fr = new frmstokcs();
            fr.Show();
        }
    }
}
