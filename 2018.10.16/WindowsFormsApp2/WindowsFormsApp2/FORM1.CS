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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score;
            try
            {
                score = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("輸入錯誤");
                textBox1.Text = "";
                return;
            }

            label1.Text = "";

            if (score < 0 || score > 100)
            {
                MessageBox.Show("錯誤成績");
                textBox1.Text = "";
                return;
            }
            if (score >= 60)
                label1.Text = "PASS";
            else
                label1.Text = "Fail";
            

        }
    }
}
