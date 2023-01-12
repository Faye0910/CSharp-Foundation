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
            int[] no = new int[500];   //從0開始

            for (int i = 0; i < no.Length; i++)
            {
                textBox1.AppendText(no[i].ToString() + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] grades = { 20, 30, 40, 50, 60, 70, 80, 90 }; //給了6個初始值


            //方法1
            for (int i = 0; i < grades.Length; i++)
            {
                textBox1.AppendText(grades[i].ToString() + "\n");
            }

            //方法2
            foreach (var a in grades)
                textBox1.AppendText(a.ToString() + "\n");
        }
    }
}
