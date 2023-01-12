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
        struct td
        {
            public Single up;
            public Single down;
            public Single height;
            public Single size;
        }

        struct newtd     //用static可設定預設值
        {
            static Single up = 1;
            static Single down = 1;
            static Single height = 1;
            static Single size = 0;

            public void set(Single u, Single d, Single h)  //讓他的值可以改
            {
                up = u;
                down = d;
                height = h;
            }
            public void compute()
            {
                size = ((up + down) * height) / 2.0f;
                
            }
            public Single getsize()   
            {
                return size;        //傳值
            }

        }
        public Form1()
        {
            InitializeComponent(); 
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single u, d, h;
            td tt;

            u = Convert.ToSingle(textBox1.Text);
            d = Convert.ToSingle(textBox2.Text);
            h = Convert.ToSingle(textBox3.Text);

            tt.up = u;
            tt.down = d;
            tt.height = h;
            tt.size = 0;

            com(ref tt);  //ref 要記得才能改變數字 不然會等於上面的tt.size=0

            label5.Text = tt.size.ToString();


        }
        void com(ref td tt)
        {
            tt.size = ((tt.up + tt.down) * tt.height) / 2.0f;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newtd newtd;
            Single u, d, h;

            u = Convert.ToSingle(textBox1.Text);
            d = Convert.ToSingle(textBox2.Text);
            h = Convert.ToSingle(textBox3.Text);

            newtd.set(u, d, h);

             newtd.compute();

            label5.Text = newtd.getsize().ToString();


        }
    }
}
