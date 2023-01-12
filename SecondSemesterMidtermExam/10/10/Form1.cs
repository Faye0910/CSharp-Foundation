using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("日間");
            comboBox1.Items.Add("夜間");
            comboBox1.Items.Add("春節期間");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a,sum;
            a = Convert.ToSingle(textBox1.Text);

            if(comboBox1.Text=="日間")
            {
                sum = 70.0f + ((a - 1.25f) / 0.2f) * 5.0f;
                label3.Text = sum.ToString();
            }
            if (comboBox1.Text == "夜間")
            {
                sum = 20.0f+90.0f + ((a - 1.25f) / 0.2f) * 5.0f;
                label3.Text = sum.ToString();
            }
            if (comboBox1.Text == "春節期間")
            {
                sum = 20.0f+20.0f + 90.0f + ((a - 1.25f) / 0.2f) * 5.0f;
                label3.Text = sum.ToString();
            }
        }
    }
}
