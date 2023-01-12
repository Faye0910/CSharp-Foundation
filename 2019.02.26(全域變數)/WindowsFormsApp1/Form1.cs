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
            int [] a = new int[5];
            int [] b = { 1, 2, 3, 4, 5 };
            int[] c;
            int[,] d = new int[5, 2];
            int[,] ee = { { 2, 3 }, { 3, 4 }, { 4, 5 }, { 5, 6 }, { 6, 7 } };
            int[,] f;

            f = new int[5, 2];


            c = new int[6];
            a[0] = 88;
            a[1] = 11;
            a[2] = 22;
            a[3] = 33;
            a[4] = 44;

            for (int i=0;i<5;i++)
            {
                textBox1.AppendText(a[i].ToString()+"\n");
            }

        }
    }
}
