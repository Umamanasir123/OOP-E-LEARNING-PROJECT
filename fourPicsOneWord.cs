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
    public partial class fourPicsOneWord : Form
    {
        public fourPicsOneWord()
        {
            InitializeComponent();
        }
        int score = 0;
        int time = 60;
        private void firstAllbuttons(object sender, EventArgs e)
        {
            var SenderButton = (Button)sender;
            if (label2.Text == "")
            {
                label2.Text = SenderButton.Text;
            }
            else if (label3.Text == "")
            {
                label3.Text = SenderButton.Text;
            }
            else if (label4.Text == "")
            {
                label4.Text = SenderButton.Text;
            }
            else if (label5.Text == "")
            {
                label5.Text = SenderButton.Text;
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "S" && label3.Text == "O" && label4.Text == "U" && label5.Text == "R")
            {
                MessageBox.Show("Correct Guess!");
                score++;
                labelScore.Text = Convert.ToString(score);
            }
            else
            {
                MessageBox.Show("Try Again!");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label8.Text = "";
            }
        }

        private void SecAllButtons(object sender, EventArgs e)
        {
            var SenderButton = (Button)sender;
            if (label8.Text == "")
            {
                label8.Text = SenderButton.Text;
            }
            else if (label7.Text == "")
            {
                label7.Text = SenderButton.Text;
            }
            else if (label6.Text == "")
            {
                label6.Text = SenderButton.Text;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (label8.Text == "T" && label7.Text == "I" && label6.Text == "E")
            {
                MessageBox.Show("Congrats! Correct Guess..");
                score++;
                labelScore.Text = Convert.ToString(score);

            }
            else
            {
                MessageBox.Show("Try Again!");
                label8.Text = "";
                label7.Text = "";
                label6.Text = "";
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

            if ((label8.Text == "T" && label7.Text == "I" && label6.Text == "E") && (label2.Text == "S" && label3.Text == "O" && label4.Text == "U" && label5.Text == "R"))
            {
                timer1.Stop();
            }

            timeleftlabel.Text = Convert.ToString(time);

        }

       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            WordsMaking wm = new WordsMaking();
            wm.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            wm.Show();
            this.Hide();
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
