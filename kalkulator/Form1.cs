using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Web;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int i =  0;
        private void button1_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 4;
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                long a = long.Parse(textBox1.Text);
                long b = long.Parse(textBox2.Text);
                switch(i)
                {
                    case 1:
                        textBox3.Text = Convert.ToString(a + b);
                        break;

                    case 2:
                        textBox3.Text = Convert.ToString(a - b);
                        break;
                    case 3:
                        textBox3.Text = Convert.ToString(a * b);
                        break;
                    case 4:
                        textBox3.Text = Convert.ToString(a / b);
                        break;
                    case 6:
                        textBox3.Text = Convert.ToString(a % b);
                        break;
                    default:
                        textBox3.Text = "";
                        break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            long a = long.Parse(textBox1.Text);
            long b = long.Parse(textBox2.Text);
            switch (i)
            {
                case 1:
                    textBox3.Text = Convert.ToString(a + b);
                    break;

                case 2:
                    textBox3.Text = Convert.ToString(a - b);
                    break;
                case 3:
                    textBox3.Text = Convert.ToString(a * b);
                    break;
                case 4:
                    textBox3.Text = Convert.ToString(a / b);
                    break;
                case 6:
                    textBox3.Text = Convert.ToString(a % b);
                    break;
                default:
                    textBox3.Text = "";
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                long a = long.Parse(textBox1.Text);
                textBox3.Text = Convert.ToString(Math.Sqrt(a));
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            long a = long.Parse(textBox1.Text);
            long b = long.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(a % b);
        }
    }
}
