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
        Random rd;
        public Form1()
        {
            rd = new Random();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            int tmp;

            for(int i=0;i<10;i++)
            {
                a[i] = rd.Next(20, 81);
            }

            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]<a[j])
                    {
                        tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                    }
                }
            }
            foreach(var b in a)
            {
                textBox1.AppendText(b.ToString() + " ");
            }
           textBox1.AppendText("\n");
        }
    }
}
