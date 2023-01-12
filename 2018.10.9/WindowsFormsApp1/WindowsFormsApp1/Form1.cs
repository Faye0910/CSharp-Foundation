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
            txtMessage.SelectionStart = 0;
            txtMessage.SelectionLength = 6;
            txtMessage.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtMessage.SelectedText+"/"+
              txtMessage.SelectionStart + "/" + 
            txtMessage.Focus();

        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否要儲存檔案","存檔提示",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);

        }
    }
}
