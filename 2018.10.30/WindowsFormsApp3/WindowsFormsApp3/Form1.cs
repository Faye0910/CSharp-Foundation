using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            int key;
            int x1, x2, x3;

            x1 = ovalShape1.Left;
            x2 = ovalShape1.Left + ovalShape1.Width + 20;
            x3 = ovalShape1.Top;

            label1.Text = e.KeyValue.ToString();
            key = e.KeyValue;

            
                key = e.KeyValue;

                if (key == 65   &&  x1-10 >0 )
                    ovalShape1.Left -= 10;
                //ovalShape1.Left = ovalShape1.Left - 1;

                if (key == 68  && x2+ 10 < ClientSize.Width)
                    ovalShape1.Left += 10;

                if (key == 87 &&   x3-10 > 0)
                    ovalShape1.Top -= 10;

                if (key == 83 && x3+ovalShape1.Width + 10 < ClientSize.Height)
                    ovalShape1.Top += 10;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            int move;
            int x1, x2, x3;

            x1 = ovalShape1.Left;
            x2 = ovalShape1.Left + ovalShape1.Width + 20;
            move = Convert.ToInt32(label2.Text);

            if  ((x1 - 10 < 0) || (x2 + 10 > this.ClientSize.Width))
            {
                move = -move;
                label2.Text = move.ToString();
            }
            ovalShape1.Left += move;
/*
            if ( x1 - 10 > 0 )
                ovalShape1.Left -= 10;
            else

            if (x2 + 10 < ClientSize.Width)
                ovalShape1.Left += 10;
*/
        }
    }
}
