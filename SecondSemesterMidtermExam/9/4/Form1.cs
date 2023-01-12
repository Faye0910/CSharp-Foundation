using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            d = arg();

            aa(a,b,c,d);

        }

        void aa(int a,int b,int c,int d)
        {
            if (a >= 80 && b >= 80 && c >= 80 && d >= 85)
            {
                label6.Text = "獎學金審核通過！";
            }
            else
            {
                label6.Text = "獎學金審核失敗！";
            }
        }

         int arg()
        {
            int a, b, c, d;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = (a + b + c) / 3;
            return d;

        }
    }
}
