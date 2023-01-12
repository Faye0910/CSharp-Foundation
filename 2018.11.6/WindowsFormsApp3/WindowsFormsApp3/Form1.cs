using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
            for (int i = 0; i <= 50; i++)
            {
                pictureBox1.Left -= 10;
                this.Refresh();
                Thread.Sleep(30);

                pictureBox2.Top -=5;
                this.Refresh();
                Thread.Sleep(30);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum=0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;

                if (i >= 4)
                break;

                textBox1.AppendText(sum.ToString()+"\n");
             }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
              

                if (i == 4)
                 continue;

                 sum += i;
                textBox1.AppendText(sum.ToString()+"\n");
            }
        }
    }
}
