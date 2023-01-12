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
        int score;
        int playernum=0;
        string player;
        int timeout;

        int[] scores = new int[5];
        string[] players = new string[5]; 

        public Form1()
        {
            InitializeComponent();
        }

        private void 開始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = "";
            score = 0;
            timeout = 5;

            if(playernum==5)
            {
                MessageBox.Show("人數已達上限");
                return;
            }


           panel1.Visible = true;
            panel1.Top = 70;
            panel1.Left = 200;


            textBox2.AppendText(playernum.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            playernum++;
            timer1.Enabled = true;
            textBox2.AppendText(playernum.ToString()+"\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeout--;

            textBox2.AppendText("a\n");

            if(timeout<=0)
            {
                timer1.Enabled = false;
                MessageBox.Show("遊戲結束");
                scores[playernum - 1] = score;
                players[playernum - 1] = player;
            }
        }
    }
}
