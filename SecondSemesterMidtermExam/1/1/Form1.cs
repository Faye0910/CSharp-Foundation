using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        Random rd;
        public Form1()
        {
            rd = new Random();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<14;i++)
            {
                textBox1.AppendText((rd.Next(1, 52)).ToString());
            }
              



        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                textBox2.AppendText((rd.Next(1, 52)).ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                textBox3.AppendText((rd.Next(1, 52)).ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                textBox4.AppendText((rd.Next(1, 52)).ToString());
            }
        }
    }
}
