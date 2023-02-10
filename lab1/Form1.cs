using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                timer1.Interval = 1;
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;

                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);
                double d = Math.Pow(b, 2) - 4 * a * c; ;
                if (a != 0 && b != 0 && c != 0)
                {
                    if (d > 0)
                    {
                        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        label1.Text = Convert.ToString(x1) + " " + Convert.ToString(x2);
                    }
                    else if (d == 0)
                    {
                        double x1 = -b / (2 * a);
                        label1.Text = Convert.ToString(x1);
                    }
                    else
                    {
                        label1.Text = "Решений нет";
                    }
                }
                else if (a == 0 && c != 0 && b!= 0)
                {
                    double x1 = c / b;
                    label1.Text = Convert.ToString(x1);
                }
                else if (b == 0 && c!= 0 && a!= 0)
                {
                    if (-(c / a) >= 0)
                    {
                        double x1 = Math.Sqrt(-(c / a));
                        double x2 = -(Math.Sqrt(-(c / a)));
                        label1.Text = Convert.ToString(x1) + " " + Convert.ToString(x2);
                    }
                    else
                    {
                        label1.Text = "Решений нет";
                    }

                }
                else if (c == 0 && b != 0 && a != 0)
                {
                    double x1 = 0;
                    double x2 = -(b / a);
                    label1.Text = Convert.ToString(x1) + " " + Convert.ToString(x2);
                }
                else if (a != 0 && b == 0 && c == 0)
                {
                    label1.Text = "Решений бесконечно";
                }
                else if(a == 0 && b == 0 && c == 0)
                {
                    label1.Text = "Решений нет";
                }
            }
            catch 
            {
                label1.Text = "ошибка программы";
            }
                

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
