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
        int a = 10;
        Random rd;
        public Form1()
        {
            rd = new Random();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a += 5;

            textBox1.AppendText(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;

            a += 5;

            textBox1.AppendText(a.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum=0;
            int i;
            for(i=1;i<11;i++)
            {
                sum += i;
            }
            textBox1.AppendText(sum.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox1.AppendText((rd.Next(5)+1).ToString()+"\n");
        }
    }
}
