using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            string output = "";
            for (i=7;i>=1;i--)
            {
                for(j=1;j<=i;j++)
                {
                        output += "*";
                   
                }
                output += "\r\n";
            } 
            textBox1.Text = output;
        }
    }
}
