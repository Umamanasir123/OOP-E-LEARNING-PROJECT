using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondSemOOPproject
{
    public partial class HumanSenseQuiz : Form
    {
        public HumanSenseQuiz()
        {
            InitializeComponent();
        }
        int score = 0;
        int time = 30;

        private void AllPicBoxEvent(object sender, EventArgs e)
        {
            var SenderObj = (PictureBox)sender;
            if (SenderObj == pictureBox2 || SenderObj == pictureBox4 || SenderObj == pictureBox9)
            {
                if (SenderObj == pictureBox2)
                {
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                }

                else if (SenderObj == pictureBox4)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }

                else if (SenderObj == pictureBox9)
                {
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false && pictureBox3.Visible == false && pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false)
            {
                score++;
                scorelabel.Text = Convert.ToString(score);
                timer1.Stop();
                MessageBox.Show("Congrats");
            }
            else
            {
                MessageBox.Show("try again");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (time == 0)
            {
                time = 30;
                timer1.Stop();
                MessageBox.Show("Time is up;");
            }
            else
            {
                time--;
            }

            timelabel.Text = Convert.ToString(time);
        }

        private void HumanSenseQuiz_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LearningSource ls = new LearningSource();
            ls.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
