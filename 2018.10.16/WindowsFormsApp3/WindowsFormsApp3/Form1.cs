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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;


            try
            {
                a = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("錯誤數值");
                label1.Text = "";
                textBox1.Text = "0";
                return;
            }


            if ( a<40 || a > 300)
            {
                MessageBox.Show("錯誤數值");
                label1.Text = "";
                textBox1.Text = "0";
                return;
            }
            if (a >=120)
                label1.Text = "全票";
            else
                label1.Text = "半價";
        }
    }
}
