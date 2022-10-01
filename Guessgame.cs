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
    public partial class Guessgame : Form
    {
        public Guessgame()
        {
            InitializeComponent();
        }
        int score=0;
        int time = 60;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cattxtbox.Text == "cat")
            {
                guna2GradientButton1.FillColor = Color.YellowGreen;
                guna2GradientButton1.FillColor2 = Color.YellowGreen;
                guna2GradientButton1.Text = "Yes u are right!";
                score++;
                scorelabel.Text = Convert.ToString(score);
                guna2PictureBox2.Visible = false;
                guna2PictureBox1.Visible = true;
                check();
            }
            else
            {
                guna2GradientButton1.FillColor =Color. Red;
                guna2GradientButton1.FillColor2 = Color.Red;
                guna2GradientButton1.Text = "Sorry! u are wrong!";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (fruittxtbox.Text == "pineapple")
            {
                guna2GradientButton2.FillColor = Color.GreenYellow;
                guna2GradientButton2.FillColor2 = Color.GreenYellow;
                guna2GradientButton2.Text = "Yes u are right!";
                score++;
                scorelabel.Text = Convert.ToString(score);
                guna2PictureBox4.Visible = false;
                guna2PictureBox3.Visible = true;
                check();
            }
            else
            {
                guna2GradientButton2.FillColor = Color.Red;
                guna2GradientButton2.FillColor2 = Color.Red;
                guna2GradientButton2.Text = "Sorry! u are wrong!";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (vegetxtbox.Text == "carrot")
            {
                guna2GradientButton3.FillColor = Color.GreenYellow;
               guna2GradientButton3.FillColor2 = Color.GreenYellow;
                guna2GradientButton3.Text = "Yes u are right!";
                score++;
                scorelabel.Text = Convert.ToString(score);
                guna2PictureBox6.Visible = false;
                guna2PictureBox5.Visible = true;
                check();

            }
            else
            {
                guna2GradientButton3.FillColor = Color.Red;
                guna2GradientButton3.FillColor2 = Color.Red;
                guna2GradientButton3.Text = "Sorry! u are wrong!";
            }
        }
        private void check()
        {
            if (cattxtbox.Text == "cat" && fruittxtbox.Text == "pineapple" && vegetxtbox.Text == "carrot")
            {
              timer1.Stop();
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

            timeshowlabel.Text = Convert.ToString(time);
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
