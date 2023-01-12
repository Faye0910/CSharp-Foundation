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
            string str = "";
            int[,] grades = new int[50, 2];

            for (int y = 0; y < 50; y++)
            {
                for(int x=0;x<2;x++)
                {
                    str += grades[y, x].ToString() + ",";
                }
                textBox1.AppendText(str + "\n");
                str = "";
            }
        }
    }
}
