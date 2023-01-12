using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a, b, c, a1, b1 = 1, c1,aaa,bbb,ccc,d;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            a1 = Convert.ToInt32(textBox4.Text);
            b1 = Convert.ToInt32(textBox5.Text);
            c1 = Convert.ToInt32(textBox6.Text);

            if(b1==0)
            {
                MessageBox.Show("商品二最少須購買一個！！！");
                return;
            }

            aaa=aa(i:a,j:a1);
            bbb=bb(i: b, j: b1);
            ccc=cc(i: c, j: c1);

            d = aaa + bbb + ccc;
            label8.Text = d.ToString();
        }
        int aa(int i,int j)
        {
            int aa;
            aa = i * j;
            return aa;
        }
        int bb(int i, int j=1)
        {
            int bb;
            bb = i * j;
            return bb;
        }
        int cc(int i, int j)
        {
            int cc;
            cc = i * j;
            return cc;
        }

    }
}
