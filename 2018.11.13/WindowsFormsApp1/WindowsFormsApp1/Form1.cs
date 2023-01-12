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
            int sum;
            string str=" ";
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    sum = a * b;
                    str += a.ToString() + "*" + b.ToString() + "=" + sum.ToString() + " ";
                    
                }
                textBox1.AppendText(str + "\n");
                textBox1.AppendText("\n");
                str = " ";
            }
        }
    }
}
