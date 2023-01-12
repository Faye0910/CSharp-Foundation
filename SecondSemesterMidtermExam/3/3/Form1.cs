using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        struct aa
        {
            public string name;
            public int bb;
            public int cc;
        }

        aa [] score = new aa[3];
        int index=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            int b, c;
            a = Convert.ToString(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            add(a,b,c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list();
        }

        void add(string a,int b,int c)
        {
            score[index].name = a;
            score[index].bb = b;
            score[index].cc = c;
            index++;
        }

        void list()
        {
            for (int i = 0; i < index; i++)
            {
                textBox4.AppendText(string.Format("姓名:{0}\r\n年薪:{1}\r\n業績:{2}\r\n"
                    , score[i].name, score[i].bb, score[i].cc));
            }
        }
    }
}
