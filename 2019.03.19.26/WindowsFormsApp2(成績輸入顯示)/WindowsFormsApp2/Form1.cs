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
        struct student
        {                       //public一定要記得用
            public int id;
            public string name;
            public int age;
            public int chin;
            public int eng;
            public int math;
        }

        struct newstudent
        {                       //public一定要記得用
            static int id=0;
            static string name="noname";
            static int age=18;
            static int chin=0;
            static int eng=0;
            static int math=0;

            public void set(int i, string n,int a,int c,int e,int m)
            {
                id = i;
                name = n;
                age = a;
                chin = c;
                eng = e;
                math = m;
            }


            public int getid()
            {
                return id;
            }

            public string getname()
            {
                return name;
            }
            public int getage()
            {
                return age;
            }
            public int getchin()
            {
                return chin;
            }
            public int geteng()
            {
                return eng;
            }
            public int getmath()
            {
                return math;
            }



        }


        student [] score=new student[5];
        int index = 0;

        newstudent[] newscore = new newstudent[5];
        int newindex = 0;

        
        public Form1()
        {
            InitializeComponent();
            label7.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no, age, chin, eng, math = 0;
            string name;

            if (index>=5)
            {
                MessageBox.Show("資料已達上限");
                button1.Enabled=false;
                return;
            }

            no = Convert.ToInt32(label7.Text);
            name = textBox2.Text;
            age = Convert.ToInt32(textBox3.Text);
            chin = Convert.ToInt32(textBox4.Text);
            eng = Convert.ToInt32(textBox5.Text);
            math = Convert.ToInt32(textBox6.Text);

            add(no,name,age,chin,eng,math);

            label7.ForeColor = Color.Black;
            index++;

            MessageBox.Show("已輸入第" + index.ToString() + "筆資料");
            
            label7.Text = (index+1).ToString();
            label7.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            
            list(index,score);

            textBox7.AppendText("----共有" + index + "筆資料----" + "\n");
        }

        //--------------------------------------------
        void add(int no, string name="", int age=18, int chin=0, int eng=0, int math=0)
        {
            score[no - 1].id = no;  //也可用index不過盡量不要用到自訂void之外的,所以用no-1,資料從第0個位置開始
            score[no - 1].name = name;
            score[no - 1].age = age;
            score[no - 1].chin =chin;
            score[no - 1].eng = eng;
            score[no - 1].math = math;
        }
        //-------------------------------------------
        void list(int num,student []std)
        {
            for (int i = 0; i < num; i++)
            {
                textBox7.AppendText(string.Format("學號={0}\r\n姓名 ={1}\r\n年齡={2}\r\n國文成績 ={3}\r\n英文成績=\r\n數學成績={4}\r\n",
                                                  std[i].id , std[i].name ,std[i].age, std[i].chin, std[i].eng, std[i].math));
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no, age, chin, eng, math = 0;
            string name;

            

            if (newindex >= 5)
            {
                MessageBox.Show("資料已達上限");
                button1.Enabled = false;
                return;
            }

            no = Convert.ToInt32(label7.Text);
            name = textBox2.Text;
            age = Convert.ToInt32(textBox3.Text);
            chin = Convert.ToInt32(textBox4.Text);
            eng = Convert.ToInt32(textBox5.Text);
            math = Convert.ToInt32(textBox6.Text);

            newscore[newindex].set(no,name, age, chin, eng, math);

            label7.ForeColor = Color.Black;
            newindex++;

            MessageBox.Show("已輸入第" + newindex.ToString() + "筆資料");

            label7.Text = (newindex + 1).ToString();
            label7.ForeColor = Color.Red;


            
        }

        private void button4_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < newindex; i++)
            {
                textBox7.AppendText(string.Format("學號={0}\r\n姓名 ={1}\r\n年齡={2}\r\n國文成績 ={3}\r\n英文成績=\r\n數學成績={4}\r\n",
                                                  newscore[i].getid, newscore[i].getname, newscore[i].getage, newscore[i].getchin,newscore[i].));

            }
        }

            
    }
}
