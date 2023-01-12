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
            int sum;

            sum = add();

            label1.Text = sum.ToString();

            //等同 label1.Text = add().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c;
            int i, j;
            i = Convert.ToInt32(textBox1.Text);
            j = Convert.ToInt32(textBox2.Text);

            c = sub(i,j);  

            label1.Text = c.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mul();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            div();
        }
        //-----------兩數相加----------------------------
        int add() //傳回整數
        {
            int c = 0;
            int i, j;
            i = Convert.ToInt32(textBox1.Text);
            j = Convert.ToInt32(textBox2.Text);
            c = i + j;

            return c; 
        }
        //----------兩數相減-----------------
        int sub(int i,int j)
        {
            int c = 0;
           
            c = i - j;

            return c;
            
        }
        //--------兩數相乘寫在自定void-----------------------------
        void mul()
        {
            int c = 0;
            int i, j;
            i = Convert.ToInt32(textBox1.Text);
            j = Convert.ToInt32(textBox2.Text);
            c = i * j;
            label1.Text = c.ToString();
        }
        //-------------兩數相除--------------------
        void div()
        {
            Single c = 0.0f; //因為會有小數所以用single
            Single i, j;
            i = Convert.ToSingle(textBox1.Text);
            j = Convert.ToSingle(textBox2.Text);
            c = i / j;
            label1.Text = c.ToString();
        }
    }
}
