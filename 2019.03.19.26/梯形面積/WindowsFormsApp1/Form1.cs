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

        private void button1_Click(object sender, EventArgs e)
        {
           
            Single a, b, c ;
            Single d;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            c = Convert.ToSingle(textBox3.Text);

            d = vol(up:a, down:b, height:c);  //up對a ,down對b ,hight對c =====位置可任意換  <具名>

            label5.Text = d.ToString();
        }

        Single vol(Single up=1,Single down=1,Single height=1)  //可先給預設值 (具名的地方少打就會用預設值)
        {
            Single d;

            d = (( up + down) * height)/ 2;

            return d;
            
        }
    }
}
