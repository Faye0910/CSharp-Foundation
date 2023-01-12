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
        int[] score = {60,70,80,90,100};
        string[] name = {"a1","a2","a3","a4","a5"};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp=0;
            String str;

            for (int i = 0; i < score.Length-1; i++)
            {
                for(int j=i+1;j<score.Length;j++)
                {
                    if (score[i]<score[j])
                    {
                        tmp = score[i];
                        score[i] = score[j];
                        score[j] = tmp;


                        str = name[i];
                        name[i] = name[j];
                        name[j] = str;
                    }
                }
            }

            for (int i = 0; i < score.Length; i++)
            {
                str = String.Format("姓名: {0}, 分數: {1}\n", name[i], score[i]);
                textBox1.AppendText(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str="a3";
            int newscore = 150;

            for (int i = 0; i < name.Length; i++)
            {
                if(str==name[i])
                {
                    score[i] = newscore;
                }
            }

            for (int i = 0; i < score.Length; i++)
            {
                str = String.Format("姓名: {0}, 分數: {1}\n", name[i], score[i]);
                textBox1.AppendText(str);
            }

        }
    }
}
