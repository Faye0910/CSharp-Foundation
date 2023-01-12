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
        int[] score = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            /* for (int i=0;i<score.Length;i++)
             {
                 textBox6.AppendText(score[i].ToString()+"\n");
             }*/

            string str;
            string[] name = {"王一","王二","王三","王四","王五" };

            textBox6.Clear();

            for(int i=0;i<score.Length; i++)
            {
                str = string.Format("{0}的成績={1}\n", name[i], score[i]);
                textBox6.AppendText(str);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score[0] = Convert.ToInt32(textBox1.Text);
            score[1] = Convert.ToInt32(textBox2.Text);
            score[2] = Convert.ToInt32(textBox3.Text);
            score[3] = Convert.ToInt32(textBox4.Text);
            score[4] = Convert.ToInt32(textBox5.Text);

            for(int i = 0;i<5;i++)
            {
                if(score[i]<0 || score[i]>100)
                {
                    MessageBox.Show("成績錯誤");
                    score[i] = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Single avg=0.0f;

            foreach(var a in score)
            {
                avg += a;
            }
            avg /= score.Length;

            label6.Text = string.Format("平均={0}", avg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == true) || (char.IsControl(e.KeyChar) == true)) //等於數字或是enter...
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == true) || (char.IsControl(e.KeyChar) == true)) //等於數字或是enter...
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == true) || (char.IsControl(e.KeyChar) == true))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == true) || (char.IsControl(e.KeyChar) == true))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == true) || (char.IsControl(e.KeyChar) == true))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int c;

            for(int i=0;i<score.Length;i++)
            {
                for(int j=i+1;j<score.Length+1;j++)
                {
                    if(i<j)
                    {
                        c= j;
                        j = i;
                        i = c;
                    }
                    textBox7.AppendText();
                }
            }
        }
    }
}
