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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("公分");
            comboBox1.Items.Add("公尺");
            comboBox1.Items.Add("公里");
            comboBox1.SelectedIndex = comboBox1.FindStringExact("公分");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single a, b,c;
            a = Convert.ToSingle(textBox1.Text);

            if (comboBox1.SelectedItem.ToString() == "公分")
            {
                cm();
            }


            if (comboBox1.SelectedItem.ToString() == "公尺")
            {
                m();
            }


            if (comboBox1.SelectedItem.ToString() == "公里")
            {
                km();
            }


                //=============公分=========
                void cm()
            {
                    b = a / 100;
                    c = b / 1000;
                    label2.Text = b.ToString() + "公尺" + "\n" + c.ToString() + "公里";          
            }
            //============公尺=========
            void m()
            {
                    b = a * 100;
                    c = a / 1000;
                    label2.Text = b.ToString() + "公分" + "\n" + c.ToString() + "公里";

                
            }
            //===========公里=========
            void km()
            {
                    c = a * 1000;
                    b = c * 100;

                    label2.Text = b.ToString() + "公分" + "\n" + c.ToString() + "公尺";
            }
        }
    }
}
