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
            int sum = 0;
            int a = 1;
            /*           for(int a=1;a<=10;a++)
                       {
                           sum += a;
                           textBox1.AppendText(sum.ToString() + "\n");
                       }
           */
            while (a <= 10)
            {
                sum += a;
                a++;

                textBox1.AppendText(sum.ToString() + "\n");

            }
        }
    }
}
