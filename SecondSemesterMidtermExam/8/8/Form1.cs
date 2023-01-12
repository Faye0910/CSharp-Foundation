using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
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
            for(int i=0; i<12; i++)
            {
                textBox1.AppendText((rd.Next(54) + 13).ToString() + "\n");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i=0;i<11;i++)
            {
                for(int j=i+1;i<12;j++)
                {

                }
            }
        }
    }
}
