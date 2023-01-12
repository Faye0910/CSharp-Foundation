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
            int a = 5, b = 4;
            bool abc;

            abc = 5 > 3;
            textBox1.AppendText( abc.ToString()+"\n");

            abc = 13<15 && 15<10;
            textBox1.AppendText(abc.ToString()+"\n");

            abc = 5 > 3  ||  3<2;
            textBox1.AppendText(abc.ToString()+"\n");
        }
    }
}
