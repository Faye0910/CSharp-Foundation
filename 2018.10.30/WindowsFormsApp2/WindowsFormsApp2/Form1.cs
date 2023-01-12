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
            int total=0;
            int ff=0;

            //-----------披薩----
            if (checkBox1.Checked == true)
                total+= 499;

            if (checkBox2.Checked == true)
                total+= 250 ;
            //-----------薯條----
            if(checkBox3.Checked==true)
            {
                if (radioButton1.Checked == true)
                    ff = 35 * Convert.ToInt32(textBox1.Text);
                else
                    ff =25 * Convert.ToInt32(textBox1.Text);
            }

            total += ff;
            label3.Text = total.ToString();
        }
    }
}
