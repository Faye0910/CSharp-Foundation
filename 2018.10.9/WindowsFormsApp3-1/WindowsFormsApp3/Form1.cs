using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        String account, b;

        public Form1()
        {
            InitializeComponent();
            account = Interaction.InputBox("輸入帳號", "帳號密碼", "王小名", -1, -1);
        }
    }
}
