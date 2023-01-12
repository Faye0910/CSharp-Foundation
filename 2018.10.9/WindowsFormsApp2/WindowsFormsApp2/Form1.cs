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
            double a, b, c;
            DialogResult D ;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a * b;

           D = MessageBox.Show("新台幣="+Convert.ToString(c),"外匯兌換",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Asterisk);

            label3.Text = D.ToString();

        }
    }
}
