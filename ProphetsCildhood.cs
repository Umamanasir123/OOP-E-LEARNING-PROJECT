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
    public partial class ProphetsCildhood : Form
    {
        public ProphetsCildhood()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private SoundPlayer _soundPlayer;
        int imageNo = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = imageList1.Images[imageNo];
            if (imageNo == imageList1.Images.Count - 1)
            {
                imageNo = 0;
            }
            else
            {

                imageNo++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
                _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\Islamiat\Islamiat\bin\Debug\Prophrt Childhood.wav");
                checkBox1.Text = "Stop";

                _soundPlayer.Play();

            }
            else
            {
                checkBox1.Text = "Play";
                _soundPlayer.Stop();
                timer1.Stop();
            }
        }

        private void ProphetsCildhood_Load(object sender, EventArgs e)
        {
            timer1.Stop();
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
