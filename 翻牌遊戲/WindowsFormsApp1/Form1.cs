using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {  
        Random rd;
        int timeout=60;
        int score;
        string player;
        int playernum;
        int open = 0;

        int[] a = new int[16];
        int[] aa = new int[16]; // 1=已翻  2=已配對
        string[] players = new string[5];
        int[] scores = new int[5];

        public Form1()
        {
            rd = new Random();
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            aa[0] = 1;
            if(a[0]==1)
            {
                pictureBox1.Image = Image.FromFile("1.gif");
            }
            if (a[0] == 2)
            {
                pictureBox1.Image = Image.FromFile("2.gif");
            }
            if(a[0] == 3)
            {
                pictureBox1.Image = Image.FromFile("3.gif");   
            }
            if(a[0] == 4)
            {
                pictureBox1.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[0] == aa[j] && j != 0)
                    {
                        if (a[0] == a[j])
                        {
                            score = score + 10;
                            aa[0] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            aa[4] = 1;
            if (a[4] == 1)
            {
                pictureBox5.Image = Image.FromFile("1.gif");
            }
            if (a[4] == 2)
            {
                pictureBox5.Image = Image.FromFile("2.gif");
            }
            if (a[4] == 3)
            {
                pictureBox5.Image = Image.FromFile("3.gif");
            }
            if (a[4] == 4)
            {
                pictureBox5.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[4] == aa[j] && j != 4)
                    {
                        if (a[4] == a[j])
                        {
                            score = score + 10;
                            aa[4] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            aa[3] = 1;
            if (a[3] == 1)
            {
                pictureBox4.Image = Image.FromFile("1.gif");
            }
            if (a[3] == 2)
            {
                pictureBox4.Image = Image.FromFile("2.gif");
            }
            if (a[3] == 3)
            {
                pictureBox4.Image = Image.FromFile("3.gif");
            }
            if (a[3] == 4)
            {
                pictureBox4.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[3] == aa[j] && j != 3)
                    {
                        if (a[3] == a[j])
                        {
                            score = score + 10;
                            aa[3] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            aa[2] = 1;
            if (a[2] == 1)
            {
                pictureBox3.Image = Image.FromFile("1.gif");
            }
            if (a[2] == 2)
            {
                pictureBox3.Image = Image.FromFile("2.gif");
            }
            if (a[2] == 3)
            {
                pictureBox3.Image = Image.FromFile("3.gif");
            }
            if (a[2] == 4)
            {
                pictureBox3.Image = Image.FromFile("4.gif");
            }

            
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[2] == aa[j] && j != 2)
                    {
                        if (a[2] == a[j])
                        {
                            score = score + 10;
                            aa[2] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            aa[1] = 1;
            if (a[1] == 1)
            {
                pictureBox2.Image = Image.FromFile("1.gif");
            }
            if (a[1] == 2)
            {
                pictureBox2.Image = Image.FromFile("2.gif");
            }
            if (a[1] == 3)
            {
                pictureBox2.Image = Image.FromFile("3.gif");
            }
            if (a[1] == 4)
            {
                pictureBox2.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[1] == aa[j] && j != 1)
                    {
                        if (a[1] == a[j])
                        {
                            score = score + 10;
                            aa[1] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            aa[5] = 1;
            if (a[5] == 1)
            {
                pictureBox6.Image = Image.FromFile("1.gif");
            }
            if (a[5] == 2)
            {
                pictureBox6.Image = Image.FromFile("2.gif");
            }
            if (a[5] == 3)
            {
                pictureBox6.Image = Image.FromFile("3.gif");
            }
            if (a[5] == 4)
            {
                pictureBox6.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[5] == aa[j] && j != 5)
                    {
                        if (a[5] == a[j])
                        {
                            score = score + 10;
                            aa[5] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            aa[5] = 1;
            if (a[6] == 1)
            {
                pictureBox7.Image = Image.FromFile("1.gif");
            }
            if (a[6] == 2)
            {
                pictureBox7.Image = Image.FromFile("2.gif");
            }
            if (a[6] == 3)
            {
                pictureBox7.Image = Image.FromFile("3.gif");
            }
            if (a[6] == 4)
            {
                pictureBox7.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[6] == aa[j] && j != 6)
                    {
                        if (a[6] == a[j])
                        {
                            score = score + 10;
                            aa[6] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            aa[7] = 1;
            if (a[7] == 1)
            {
                pictureBox8.Image = Image.FromFile("1.gif");
            }
            if (a[7] == 2)
            {
                pictureBox8.Image = Image.FromFile("2.gif");
            }
            if (a[7] == 3)
            {
                pictureBox8.Image = Image.FromFile("3.gif");
            }
            if (a[7] == 4)
            {
                pictureBox8.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {
                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[7] == aa[j] && j != 7)
                    {
                        if (a[7] == a[j])
                        {
                            score = score + 10;
                            aa[7] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            aa[8] = 1;
            if (a[8] == 1)
            {
                pictureBox9.Image = Image.FromFile("1.gif");
            }
            if (a[8] == 2)
            {
                pictureBox9.Image = Image.FromFile("2.gif");
            }
            if (a[8] == 3)
            {
                pictureBox9.Image = Image.FromFile("3.gif");
            }
            if (a[8] == 4)
            {
                pictureBox9.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[8] == aa[j] && j != 8)
                    {
                        if (a[8] == a[j])
                        {
                            score = score + 10;
                            aa[8] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            aa[9] = 1;
            if (a[9] == 1)
            {
                pictureBox10.Image = Image.FromFile("1.gif");
            }
            if (a[9] == 2)
            {
                pictureBox10.Image = Image.FromFile("2.gif");
            }
            if (a[9] == 3)
            {
                pictureBox10.Image = Image.FromFile("3.gif");
            }
            if (a[9] == 4)
            {
                pictureBox10.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[9] == aa[j] && j != 9)
                    {
                        if (a[9] == a[j])
                        {
                            score = score + 10;
                            aa[9] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            aa[10] = 1;
            if (a[10] == 1)
            {
                pictureBox11.Image = Image.FromFile("1.gif");
            }
            if (a[10] == 2)
            {
                pictureBox11.Image = Image.FromFile("2.gif");
            }
            if (a[10] == 3)
            {
                pictureBox11.Image = Image.FromFile("3.gif");
            }
            if (a[10] == 4)
            {
                pictureBox11.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[10] == aa[j] && j !=10)
                    {
                        if (a[10] == a[j])
                        {
                            score = score + 10;
                            aa[10] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            aa[11] = 1;
            if (a[11] == 1)
            {
                pictureBox12.Image = Image.FromFile("1.gif");
            }
            if (a[11] == 2)
            {
                pictureBox12.Image = Image.FromFile("2.gif");
            }
            if (a[11] == 3)
            {
                pictureBox12.Image = Image.FromFile("3.gif");
            }
            if (a[11] == 4)
            {
                pictureBox12.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[11] == aa[j] && j != 11)
                    {
                        if (a[11] == a[j])
                        {
                            score = score + 10;
                            aa[11] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            aa[12] = 1;
            if (a[12] == 1)
            {
                pictureBox13.Image = Image.FromFile("1.gif");
            }
            if (a[12] == 2)
            {
                pictureBox13.Image = Image.FromFile("2.gif");
            }
            if (a[12] == 3)
            {
                pictureBox13.Image = Image.FromFile("3.gif");
            }
            if (a[12] == 4)
            {
                pictureBox13.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[12] == aa[j] && j != 12)
                    {
                        if (a[12] == a[j])
                        {
                            score = score + 10;
                            aa[12] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            aa[13] = 1;
            if (a[13] == 1)
            {
                pictureBox14.Image = Image.FromFile("1.gif");
            }
            if (a[13] == 2)
            {
                pictureBox14.Image = Image.FromFile("2.gif");
            }
            if (a[13] == 3)
            {
                pictureBox14.Image = Image.FromFile("3.gif");
            }
            if (a[13] == 4)
            {
                pictureBox14.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[13] == aa[j] && j !=13)
                    {
                        if (a[13] == a[j])
                        {
                            score = score + 10;
                            aa[13] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score +(-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            aa[15] = 1;
            if (a[15] == 1)
            {
                pictureBox16.Image = Image.FromFile("1.gif");
            }
            if (a[15] == 2)
            {
                pictureBox16.Image = Image.FromFile("2.gif");
            }
            if (a[15] == 3)
            {
                pictureBox16.Image = Image.FromFile("3.gif");
            }
            if (a[15] == 4)
            {
                pictureBox16.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if (aa[15] == aa[j] && j !=15)
                    {
                        if (a[15] == a[j])
                        {
                            score = score + 10;
                            aa[15] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            aa[14] = 1;
            if (a[14] == 1)
            {
                pictureBox15.Image = Image.FromFile("1.gif");
            }
            if (a[14] == 2)
            {
                pictureBox15.Image = Image.FromFile("2.gif");
            }
            if (a[14] == 3)
            {
                pictureBox15.Image = Image.FromFile("3.gif");
            }
            if (a[14] == 4)
            {
                pictureBox15.Image = Image.FromFile("4.gif");
            }
            open++;
            if (open % 2 == 0)
            {

                for (int j = 0; j < aa.Length; j++)
                {
                    if(aa[14]==aa[j]&& j!=14)
                    {
                        if (a[14] == a[j])
                        {
                            score = score + 10;
                            aa[14] = 2;
                            aa[j] = 2;
                        }
                        else
                        {
                            score = score + (-5);
                            timer2.Enabled = true;
                        }
                        label5.Text = score.ToString();
                    }
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string str="";

            if(playernum==5)
            {
                MessageBox.Show("人數已達上限");
                return;
            }

          
                for (int i = 0; i < 16; i++)
                {
                    a[i] = rd.Next(1, 5);
               
                    str = a[i].ToString();
                    textBox1.AppendText(str+"\n");    
                }
            panel1.Visible = true;
            panel1.Top = 100;
            panel1.Left = 150;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timeout--;

            label2.Text = timeout.ToString();

            if(timeout<=0)
            {
                timer1.Enabled = false;
                MessageBox.Show("遊戲結束");
                scores[playernum - 1] = score;
                players[playernum - 1] = player;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            panel1.Visible = false;
            player = textBox2.Text;
            playernum ++;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void 開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wmp;
            wmp = new WMPLib.WindowsMediaPlayer();
            wmp.URL = "Jingle Bell Rock.mp3";
            wmp.controls.play();
        }

        private void 關ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wmp;
            wmp = new WMPLib.WindowsMediaPlayer();
            wmp.URL = "Jingle Bell Rock.mp3";
            wmp.controls.stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for(int j=0;j<aa.Length;j++)
            {
                if (aa[j] == 1)
                {
                    switch(j)
                    {
                        case 0:
                            pictureBox1.Image = Image.FromFile("5.gif");
                            aa[0] = 0;
                            break;
                        case 1:
                            pictureBox2.Image = Image.FromFile("5.gif");
                            aa[1] = 0;
                            break;
                        case 2:
                            pictureBox3.Image = Image.FromFile("5.gif");
                            aa[2] = 0;
                            break;
                        case 3:
                            pictureBox4.Image = Image.FromFile("5.gif");
                            aa[3] = 0;
                            break;
                        case 4:
                            pictureBox5.Image = Image.FromFile("5.gif");
                            aa[4] = 0;
                            break;
                        case 5:
                            pictureBox6.Image = Image.FromFile("5.gif");
                            aa[5] = 0;
                            break;
                        case 6:
                            pictureBox7.Image = Image.FromFile("5.gif");
                            aa[6] = 0;
                            break;
                        case 7:
                            pictureBox8.Image = Image.FromFile("5.gif");
                            aa[7] = 0;
                            break;
                        case 8:
                            pictureBox9.Image = Image.FromFile("5.gif");
                            aa[8] = 0;
                            break;
                        case 9:
                            pictureBox10.Image = Image.FromFile("5.gif");
                            aa[9] = 0;
                            break;
                        case 10:
                            pictureBox11.Image = Image.FromFile("5.gif");
                            aa[10] = 0;
                            break;
                        case 11:
                            pictureBox12.Image = Image.FromFile("5.gif");
                            aa[11] = 0;
                            break;
                        case 12:
                            pictureBox13.Image = Image.FromFile("5.gif");
                            aa[12] = 0;
                            break;
                        case 13:
                            pictureBox14.Image = Image.FromFile("5.gif");
                            aa[13] = 0;
                            break;
                        case 14:
                            pictureBox15.Image = Image.FromFile("5.gif");
                            aa[14] = 0;
                            break;
                        case 15:
                            pictureBox16.Image = Image.FromFile("5.gif");
                            aa[15] = 0;
                            break;

                    }
                }
            }
            timer2.Enabled = false;
        }
    }



}
