using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SecondSemOOPproject
{
    public partial class FourSurahs : Form
    {
        private SoundPlayer _soundPlayer;
        public FourSurahs()
        {
            InitializeComponent();
        }

        

        private void FourSurahs_Load(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\Islamiat\Islamiat\bin\Debug\surah kaafirroon.wav");
                checkBox1.Text = "Stop";
                guna2PictureBox1.Visible = true;
                guna2PictureBox2.Visible = false;
                _soundPlayer.Play();
            }
            else
            {
                checkBox1.Text = "Play";
                _soundPlayer.Stop();
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\Islamiat\Islamiat\bin\Debug\surah ikhlas.wav");
                checkBox2.Text = "Stop";
                guna2PictureBox3.Visible = true;
                guna2PictureBox4.Visible = false;
                _soundPlayer.Play();
            }
            else
            {
                checkBox2.Text = "Play";
                _soundPlayer.Stop();
                guna2PictureBox3.Visible = false;
                guna2PictureBox4.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\Islamiat\Islamiat\bin\Debug\surah falaq.wav");
                checkBox3.Text = "Stop";
                guna2PictureBox5.Visible = true;
                guna2PictureBox6.Visible = false;
                _soundPlayer.Play();
            }
            else
            {
                checkBox2.Text = "Play";
                _soundPlayer.Stop();
                guna2PictureBox5.Visible = false;
                guna2PictureBox6.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\Islamiat\Islamiat\bin\Debug\surah naas.wav");
                checkBox4.Text = "Stop";
                guna2PictureBox7.Visible = true;
                guna2PictureBox8.Visible = false;
                _soundPlayer.Play();
            }
            else
            {
                checkBox2.Text = "Play";
                _soundPlayer.Stop();
                guna2PictureBox7.Visible = false;
                guna2PictureBox8.Visible = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LearningSource LS = new LearningSource();
            LS.Show();
            this.Hide();
            _soundPlayer.Stop();
            
        }
    }
}
