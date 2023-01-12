using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyValue.ToString();  //顯示按鍵數值
            label2.Text = e.KeyCode.ToString();   //顯示字串
            label3.Text = e.KeyData.ToString();   //按的東西都顯示

            count++;  //count=count+1

            label4.Text = count.ToString();      //按住的時間


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label5.Text = e.KeyChar.ToString();  //顯示123 abc大小寫  不顯示enter甚麼的 
        }

        private void button1_MouseDown(object sender, MouseEventArgs e) //滑鼠按下去
        {
            button1.Text = "Mouse down";

        }

        private void button1_MouseUp(object sender, MouseEventArgs e) //滑鼠放開
        {
            button1.Text = "Mouse UP";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e) //移動進去
        {
            button1.Text = "Mouse Move";
        }

        private void button1_MouseLeave(object sender, EventArgs e) //滑鼠離開
        {
            button1.Text = "Mouse leave";
        }
    }
}
