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

        private void button1_Click(object sender, EventArgs e) // length應用
        {
            string str = "I! Sa m@ 5aL Fg;o,o.d/ !s!t u[d]e{n+t9.F";
            char c;

            for(int a=0; a<str.Length; a+=2)  //length是字串的全長
            {
                c = str[a];
                textBox1.AppendText(c.ToString()+"\n");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)  //format應用
        {
            string str = " ";
            string name="王小明";
             int   balance=5000000;

            str = String.Format("姓名:{0}的帳戶餘額是{1:C}", name, balance);// :C會顯示NT:0,000,000
            textBox1.AppendText(str);

        }

        private void button3_Click(object sender, EventArgs e)   //刪掉前後空白
        {
            string str = "ABC      ";
            string str1;
            
            str1 = str.Trim();

            textBox1.AppendText(str.Length.ToString()+"\n");
            textBox1.AppendText(str1.Length.ToString() + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "abcdefghijk";
            string str1;

            //str1 = str.Remove(3, 4);    //從第3個之後刪掉4個字
            str1 = str.Insert(3, "123");  //從第3個字後插入123的字
            textBox1.AppendText(str1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "1234567890";
            string str1;



            str1 = str.IndexOf("567",10);
        }
    }
}
