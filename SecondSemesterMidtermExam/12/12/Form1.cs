using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = rd.Next(1, 6).ToString();
            textBox2.Text = rd.Next(1, 6).ToString();

            if(textBox1.Text==textBox2.Text)
            {
                return;
            }
        }
    }
}
