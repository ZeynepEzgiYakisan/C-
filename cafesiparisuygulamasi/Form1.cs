using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafesiparisuygulamasi
{
    public partial class Form1 : Form
    {
        int cay = 0, kahve = 0, kola, su = 0;

        private void btnCayArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblCay.Text);
            sayi++;
            cay = sayi;
            lblCay.Text = cay.ToString();
        } 
        private void btnKahveArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblKahve.Text);
            sayi++;
            kahve = sayi;
            lblKahve.Text = kahve.ToString();
        }

        private void btnKolaArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblKola.Text);
            sayi++;
            kola = sayi;
            lblKola.Text = kola.ToString();
        }

    
        private void btnSuArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblSu.Text);
            sayi++;
            su = sayi;
            lblSu.Text = su.ToString();
        }

      

        private void btnCayEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblCay.Text);
            
            if(cay>0)
            {
                sayi--;
                cay = sayi;
                lblCay.Text = cay.ToString();
            }
            
        }



        private void btnKahveEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblKahve.Text);

            if (kahve > 0)
            {
                sayi--;
                kahve= sayi;
                lblKahve.Text = kahve.ToString();
            }
        }

      

        private void btnKolaEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblKola.Text);

            if (kola > 0)
            {
                sayi--;
                kola = sayi;
                lblKola.Text = kola.ToString();
            }
        }


        private void btnSuEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblSu.Text);

            if (su > 0)
            {
                sayi--;
                su = sayi;
                lblSu.Text = su.ToString();
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Çay : {0} \n Kahve : {1}\n Kola : {2}  \n Su : {3}\n", cay, kahve, kola, su));
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cay = 0;
            kola = 0;
            kahve = 0;
            su = 0;

            lblCay.Text = "0";
            lblKahve.Text = "0";
            lblKola.Text = "0";
            lblSu.Text = "0";

        }

        public Form1()
        {
            InitializeComponent();
        }

       

     
    }
}
