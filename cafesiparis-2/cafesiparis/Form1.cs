using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text =="")
            {
                label4.Text = "0";
            }
            else if (listBox1.Text == "Espresso")
            {
                label4.Text = "30";
            }
            else if (listBox1.Text == "Americano")
            {
                label4.Text = "40";
            }
            else if (listBox1.Text == "Latte")
            {
                label4.Text = "45";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
            {
                label5.Text = "0";
            }
            else if (listBox2.Text == "İced Latte")
            {
                label5.Text = "40";
            }
            else if (listBox2.Text == "İced Macchiato")
            {
                label5.Text = "50";
            }
            else if (listBox2.Text == "İced Americano")
            {
                label5.Text = "45";
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
            {
                label6.Text = "0";
            }
            else if (listBox3.Text == "Damla Sakızlı Türk Kahvesi")
            {
                label6.Text = "30";
            }
            else if (listBox3.Text == "Menengiç Türk Kahvesi")
            {
                label6.Text = "50";
            }
            else if (listBox3.Text == "Özel Türk Kahvesi")
            {
                label6.Text = "45";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            listBox4.Items.Clear();

            if (listBox1.Text != "")
            {
                listBox4.Items.Add("SICAK KAHVELER : " + " "+ listBox1.Text + "  "+ label4.Text);
            }

            if (listBox2.Text != "")
            {
                listBox4.Items.Add("SOĞUK KAHVELER : " +" "+ listBox2.Text + "  "+ label5.Text);
            }

            if (listBox3.Text != "")
            {
                listBox4.Items.Add("TÜRK KAHVELERİ : " + " " + listBox3.Text + "  " + label6.Text);
            }

            toplam = int.Parse(label4.Text) + int.Parse(label5.Text) + int.Parse(label6.Text);
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam, ogrenci, indirim,odenecekTutar;
            toplam = double.Parse(textBox1.Text);

            if(checkBox1.Checked)
            {
                ogrenci = toplam / 20;
            }
            else
            {
                ogrenci = 0;
            }
            if(toplam >= 100)
            {
                indirim = toplam / 10;
            }
            else
            {
                indirim = 0;
            }
            odenecekTutar = toplam - indirim - ogrenci;
            richTextBox1.Text = "";
            richTextBox1.Text += "TOPLAM TUTAR = " + toplam + "\n";
            richTextBox1.Text += "İNDİRİM TUTARI = " + indirim + "\n";
            richTextBox1.Text += "ÖĞRENCİ İNDİRİMİ = " + ogrenci + "\n";
            richTextBox1.Text += "-----------------------------------------";
            richTextBox1.Text += "ÖDENECEK TUTAR = " + odenecekTutar + "\n";



        }
    }
}
