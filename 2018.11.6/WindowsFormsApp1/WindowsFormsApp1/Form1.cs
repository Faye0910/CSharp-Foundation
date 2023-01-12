using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char GPA;

            GPA = Convert.ToChar(textBox1.Text);

            switch (GPA)
            {
                case 'A':
                case 'a':
                    label1.Text= "超過80分";
                    break;

                case 'B':
                case 'b':
                    label1.Text = "70~79分";
                    break;

                case 'C':
                case 'c':
                    label1.Text = "60~69分";
                    break;

                default:
                    label1.Text = "低於60分";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score;
            score = Convert.ToInt32(textBox2.Text);

            score /= 10;

            switch (score)
            {
                case 10:
                case 9:
                    label2.Text = "A";
                    break;
                case 8:
                    label2.Text = "B";
                    break;
                case 7:
                    label2.Text = "C";
                    break;
                default:
                    label2.Text = "D";
                    break;
            }
        }
    }
}
