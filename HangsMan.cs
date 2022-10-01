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
    public partial class HangsMan : Form
    {
        int timer = 10;
        int score = 0;
        int next = 1;
        public HangsMan()
        {
            InitializeComponent();
        }

        private void HangsMan_Load(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled =
            button9.Enabled = button10.Enabled = btnPlayAgain.Enabled =
                btnRestart.Enabled = false;
            timer1.Stop();
        }

        private void Button(object sender, EventArgs e)
        {
            var SenderObject = (Button)sender;
            switch (next)
            {
                case 2:
                    if (SenderObject.Text == "c" && label1.Text == "?")
                    {
                        label1.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "l" && label1.Text == "c" && label2.Text == "?")
                    {
                        label2.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "d" && label1.Text == "c" && label2.Text == "l" && label5.Text == "?")
                    {
                        label5.Text = SenderObject.Text;
                        score++;
                        timer1.Stop();
                        labelScore.Text = Convert.ToString(score);
                    }
                    else
                    {
                        MessageBox.Show("Try Again!");
                    }
                    break;
                case 3:
                    if (SenderObject.Text == "m" && label1.Text == "?")
                    {
                        label1.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "n" && label1.Text == "m" && label3.Text == "?")
                    {
                        label3.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "k" && label1.Text == "m" && label3.Text == "n" && label4.Text == "?")
                    {
                        label4.Text = SenderObject.Text;


                    }
                    else if (SenderObject.Text == "y" && label1.Text == "m" && label3.Text == "n" && label4.Text == "k" && label6.Text == "?")
                    {
                        label6.Text = SenderObject.Text;
                        score++;
                        timer1.Stop();
                        labelScore.Text = Convert.ToString(score);
                    }
                    else
                    {
                        MessageBox.Show("Try Again!");
                    }
                    break;
                case 4:
                    if (SenderObject.Text == "b" && label1.Text == "?")
                    {
                        label1.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "s" && label1.Text == "b" && label3.Text == "?")
                    {
                        label3.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "k" && label1.Text == "b" && label3.Text == "s" && label4.Text == "?")
                    {
                        label4.Text = SenderObject.Text;
                    }
                    else if (SenderObject.Text == "t" && label1.Text == "b" && label3.Text == "s" && label4.Text == "k" && label6.Text == "?")
                    {
                        label6.Text = SenderObject.Text;
                        score++;
                        timer1.Stop();
                        labelScore.Text = Convert.ToString(score);
                    }
                    else
                    {
                        MessageBox.Show("Try Again!");
                    }
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                btnStart.Text = "Next";
            }
            AssignValues(next);
            next++;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled =
                button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled =
                button9.Enabled = button10.Enabled = btnPlayAgain.Enabled = true;
            timer = 10;
            timelabel.Text = Convert.ToString(timer);
            timer1.Start(); if (next == 4)
            {
                btnRestart.Enabled = true;
                btnStart.Enabled = false;
            }
        }
        private void AssignValues(int n)
        {
            switch (n)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\cloud.jpg");
                    label1.Text = label2.Text = label5.Text = "?";
                    label3.Text = "o";
                    label4.Text = "u";
                    label6.Text = " ";
                    button1.Text = "i";
                    button2.Text = "m";
                    button3.Text = "l";
                    button4.Text = "h";
                    button5.Text = "a";
                    button6.Text = "q";
                    button7.Text = "d";
                    button8.Text = "y";
                    button9.Text = "c";
                    button10.Text = "e";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\monkeyhang.jpg");
                    label1.Text = label3.Text = label4.Text = label6.Text = "?";
                    label2.Text = "o";
                    label5.Text = "e";
                    button1.Text = "m";
                    button2.Text = "i";
                    button3.Text = "s";
                    button4.Text = "y";
                    button5.Text = "j";
                    button6.Text = "n";
                    button7.Text = "p";
                    button8.Text = "a";
                    button9.Text = "k";
                    button10.Text = "u";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\basket.jpg");
                    label1.Text = label3.Text = label4.Text = label6.Text = "?";
                    label2.Text = "a";
                    label5.Text = "e";
                    button1.Text = "u";
                    button2.Text = "l";
                    button3.Text = "b";
                    button4.Text = "r";
                    button5.Text = "t";
                    button6.Text = "w";
                    button7.Text = "k";
                    button8.Text = "i";
                    button9.Text = "o";
                    button10.Text = "s";
                    break;
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            switch (next)
            {
                case 2:
                   if(label5.Text=="d")
                    {
                        score--;
                    }
                    label1.Text = label2.Text = label5.Text = "?";
                    break;
                case 3:
                    if (label6.Text == "y")
                    {
                        score--;
                    }
                    label1.Text = label3.Text = label4.Text = label6.Text = "?";
                    break;
                case 4:
                    if (label6.Text == "t")
                    {
                        score--;
                    }
                    label1.Text = label3.Text = label4.Text = label6.Text = "?";
                    break;
            }
           
            labelScore.Text = Convert.ToString(score);
            timer = 10;
            timelabel.Text = Convert.ToString(timer);
            timer1.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\hangman.jpg");
            label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = "?";
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text =
                button6.Text = button7.Text = button8.Text = button9.Text = button10.Text = "_";
            btnStart.Text = "Start";
            btnStart.Enabled = true;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = btnPlayAgain.Enabled = btnRestart.Enabled = false;
            next = 1;
            score = 0;
            labelScore.Text = Convert.ToString(score);
            timer1.Stop();
            timer = 30;
            timelabel.Text = Convert.ToString(timer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer == 0)
            {
                timer = 10;
                timer1.Stop();

                labelScore.Text = Convert.ToString(score);
                MessageBox.Show("Your time is Up");
            }
            else
            {
                timer--;

            }
            timelabel.Text = Convert.ToString(timer);
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
