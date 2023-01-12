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
            string[] name = { "王大明","王二名","王三名","王四名","王曉明" };
            int[] grades = { 50, 60, 70, 80, 90, 100 };
            int id,no;
            
            id = Convert.ToInt32(textBox1.Text);
            no = id - 1;

            if (no<0 || no > 4)

                MessageBox.Show("錯誤");
            else
            { 
                label4.Text = name[no].ToString();
                label5.Text = grades[no].ToString();
            }
        }
    }
}
