using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_KararYapilari_1707
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LblRastgeleKarakterler_Click(object sender, EventArgs e)
        {

        }

        private void LblKalanHakkimiz_Click(object sender, EventArgs e)
        {

        }
        int KalanHak = 5;
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblRastgeleKarakterler.Text = Convert.ToString(rnd.Next(10000000, 100000000));

            lblKalanHakkimiz.Text = KalanHak.ToString();
            if (KalanHak > 0)
            {
                if (lblRastgeleKarakterler.Text == txtMetinGirisAlani.Text)
                {
                    MessageBox.Show("başardınız");
                }
                else
                {
                    MessageBox.Show("başaramadınız");
                    KalanHak = KalanHak - 1;
                    lblKalanHakkimiz.Text = KalanHak.ToString();
                }

            }
            else { MessageBox.Show("giriş hakkınız kalmadı"); }
        }
    }
}
