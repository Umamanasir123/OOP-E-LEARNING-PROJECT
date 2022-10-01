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
    public partial class HumanSenses : Form
    {
        public HumanSenses()
        {
            InitializeComponent();
        }
        int senseImgNo = 0;
         SoundPlayer sp;
        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = SenseimageList1.Images[senseImgNo];
            if (senseImgNo == SenseimageList1.Images.Count - 1)
            {
                senseImgNo = 0;
            }
            else
            {
                senseImgNo++;
            }
            int red = r.Next(0, 255);
            int green = r.Next(0, 255);
            int blue = r.Next(0, 255);
            this.BackColor=(Color.FromArgb(red, green, blue));
        }

        private void HumanSenses_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void playSensesbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (playSensesbtn.Checked)
            {
                timer1.Start();
                sp = new SoundPlayer(soundLocation: @"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\bin\Debug\Senses.wav");
                playSensesbtn.Text = "        Stop     ";
                sp.Play();
            }
            else
            {
                playSensesbtn.Text = "   PLAY AGAIN  ";
                sp.Stop();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            HumanSenseQuiz hq = new HumanSenseQuiz();
            hq.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            hq.Show();
            this.Hide();
          
        }
    }
}
