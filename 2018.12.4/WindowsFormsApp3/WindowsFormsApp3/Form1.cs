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
        int[] grades = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
         
            grades[0] = Convert.ToInt32(textBox1.Text);
            grades[1] = Convert.ToInt32(textBox2.Text);
            grades[2] = Convert.ToInt32(textBox3.Text);
            grades[3] = Convert.ToInt32(textBox4.Text);
            grades[4] = Convert.ToInt32(textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < 5; i++)
            {
                str = ("第" + i.ToString() + "筆成績="+grades[i]+ "\n");
                textBox6.AppendText(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Single avg = 0, sum = 0;
            foreach (var a in grades)
            {
                sum += a;
            }

            avg = sum / 5;

            label7.Text = avg.ToString();
                                            
        }
    }
}
