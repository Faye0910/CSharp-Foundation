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
            Single sum=0;
        
            for(Single i=(10); i>=5; i=i-0.2f)
            {
                sum = sum + i;

                textBox1.AppendText("i=" + i.ToString() + " sum=" + sum.ToString()+"\n");
            }
        }
    }
}
