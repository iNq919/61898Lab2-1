using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61898Lab2_1
{
    public partial class Form1 : Form
    {
        double Kobieta = 0.85;
        double Mezczyzna = 0.90;
        double wzrost;
        double obliczenia;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wzrost = Convert.ToDouble(textBox1.Text);
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    MessageBox.Show("Mozna wybrac tylko jedna z wag");
                }
                else if ((radioButton1.Checked == true) && (checkBox1.Checked == true))
                {
                    obliczenia = (wzrost - 100);
                    label3.Text = Convert.ToString(obliczenia);
                }
                else if ((radioButton1.Checked == true) && (checkBox2.Checked == true))
                {
                    obliczenia = (wzrost - 100) * Kobieta;
                    label3.Text = Convert.ToString(obliczenia);
                }
                else if ((radioButton2.Checked == true) && (checkBox1.Checked == true))
                {
                    obliczenia = (wzrost - 100);
                    label3.Text = Convert.ToString(obliczenia);
                }
                else if ((radioButton2.Checked == true) && (checkBox2.Checked == true))
                {
                    obliczenia = (wzrost - 100) * Mezczyzna;
                    label3.Text = Convert.ToString(obliczenia);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz wybrane obliczenia");
            }
        }
    }
}
