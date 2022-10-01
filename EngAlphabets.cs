using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;

namespace SecondSemOOPproject
{
    public partial class EngAlphabets : Form
    {
        SpeechSynthesizer spsyn = new SpeechSynthesizer();
        SoundPlayer sp = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\EngAlphabetsforKids\EngAlphabetsforKids\bin\Debug\background abcd song.wav");
       
        public EngAlphabets()
        {
            InitializeComponent();
        }
           
        private void EngAlphabets_Load(object sender, EventArgs e)
        {
            sp.Play();
        }

        private void AllPicBox(object sender, EventArgs e)
        {
            var SenderPbox = (PictureBox)sender;
            checkBox1.Text = "P\nL\nA\nY\n\nA\nB\nC\n\nR\nH\nY\nM\nE";
            sp.Stop();
            if (SenderPbox == pictureBox1)
            {
                spsyn.SpeakAsync("a for apple");
            }
            if (SenderPbox == pictureBox2)
            {
                spsyn.SpeakAsync("b for ball");
            }
            if (SenderPbox == pictureBox3)
            {
                spsyn.SpeakAsync("c for cat");
            }
            if (SenderPbox == pictureBox4)
            {
                spsyn.SpeakAsync("d for dog");
            }
            if (SenderPbox == pictureBox5)
            {
                spsyn.SpeakAsync("e for egg");
            }
            if (SenderPbox == pictureBox6)
            {
                spsyn.SpeakAsync("f for fish");
            }
            if (SenderPbox == pictureBox7)
            {
                spsyn.SpeakAsync("g for goat");
            }
            if (SenderPbox == pictureBox8)
            {
                spsyn.SpeakAsync("h for hat");
            }
            if (SenderPbox == pictureBox9)
            {
                spsyn.SpeakAsync("i for ink");
            }
            if (SenderPbox == pictureBox10)
            {
                spsyn.SpeakAsync("j for juice");
            }
            if (SenderPbox == pictureBox11)
            {
                spsyn.SpeakAsync("k for king");
            }
            if (SenderPbox == pictureBox12)
            {
                spsyn.SpeakAsync("l for lamb");
            }
            if (SenderPbox == pictureBox13)
            {
                spsyn.SpeakAsync("m for monkey");
            }
            if (SenderPbox == pictureBox14)
            {
                spsyn.SpeakAsync("n for neck");
            }
            if (SenderPbox == pictureBox15)
            {
                spsyn.SpeakAsync("o for octopus");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            if(checkBox1.Checked)

            {
                checkBox1.Text = "P\nL\nA\nY\n\nA\nB\nC\n\nR\nH\nY\nM\nE";
              
                sp.Play();
            }
            else
            {
                checkBox1.Text = "S\nT\nO\nP\n\nA\nB\nC\n\nR\nH\nY\nM\nE";
                sp.Stop();
            }
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LearningSource ls = new LearningSource();
            ls.Show();
            this.Hide();
            sp.Stop();
        }
    }
}
