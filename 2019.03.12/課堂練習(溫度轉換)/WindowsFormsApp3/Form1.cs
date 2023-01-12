using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single a,sum;
            a = Convert.ToSingle(textBox1.Text);

            sum = aa(a);

            label1.Text = sum.ToString();
        }
        Single aa(Single a)
        {
            Single  b = 0.0f;
            a = Convert.ToSingle(textBox1.Text);

            b = ((9.0f / 5.0f) * a) + 32;
            return b;
            
        }


    }
}
