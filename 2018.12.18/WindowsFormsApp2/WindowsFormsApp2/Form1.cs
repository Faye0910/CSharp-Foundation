using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] a = new int[2, 3];
            double[] sum = new double[2];
            double[] avg = new double[2];

            a[0, 0] = Convert.ToInt32(textBox1.Text);
            a[0, 1] = Convert.ToInt32(textBox2.Text);
            a[0, 2] = Convert.ToInt32(textBox3.Text);

            a[1, 0] = Convert.ToInt32(textBox4.Text);
            a[1, 1] = Convert.ToInt32(textBox5.Text);
            a[1, 2] = Convert.ToInt32(textBox6.Text);

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    sum[i] += a[i, j];
                }
            }

            for(int i=0;i<2;i++)
            {
                avg[i] = sum[i] / 3.0;
            }

            label6.Text = sum[0].ToString();
            label7.Text = avg[0].ToString();
            label8.Text = sum[1].ToString();
            label9.Text = avg[1].ToString();


        }
    }
}
