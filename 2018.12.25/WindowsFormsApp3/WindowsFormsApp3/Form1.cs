using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer SP;
            SP = new System.Media.SoundPlayer();
            SP.SoundLocation = "bubbs.wav";
            SP.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = "Jingle Bell Rock.mp3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wmp;
            wmp = new WMPLib.WindowsMediaPlayer();
            wmp.URL= "Jingle Bell Rock.mp3";
            wmp.controls.play();
        }
    }
}
