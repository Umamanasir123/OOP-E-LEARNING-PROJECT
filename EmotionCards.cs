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
    public partial class EmotionCards : Form
    {
        int timer = 10;
        int score = 0;
        int correctAns;
        int QuestionNo = 1;
        public EmotionCards()
        {
            InitializeComponent();
        }

        private void EmotionCards_Load(object sender, EventArgs e)
        {

            button1.Enabled = button2.Enabled = button3.Enabled = btnPlayAgain.Enabled = btnRestart.Enabled = false;
            timer1.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                btnStart.Text = "Next";
            }
            AssignValues(QuestionNo);
            QuestionNo++;
            button1.Enabled = button2.Enabled = button3.Enabled = btnPlayAgain.Enabled = true;
            button1.BackColor = button2.BackColor = button3.BackColor = Color.White;
            timer = 10;
            labelTimer.Text = Convert.ToString(timer);
            timer1.Start();
            if (QuestionNo == 4)
            {
                btnStart.Enabled = false;
                btnRestart.Enabled = true;
            }
        }
        private void AssignValues(int qNo)
        {
            switch (qNo)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\happy.jpg");
                    button1.Text = "Sad";
                    button2.Text = "Happy";
                    button3.Text = "Angry";
                    correctAns = 2;
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\sad.jpg");
                    button1.Text = "Happy";
                    button2.Text = "Angry";
                    button3.Text = "Sad";
                    correctAns = 3;
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\angry.jpg");
                    button1.Text = "Angry";
                    button2.Text = "Sad";
                    button3.Text = "Happy";
                    correctAns = 1;
                    break;


            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button1.BackColor = button2.BackColor = button3.BackColor = Color.White;
            if(button1.BackColor==Color.LightGreen|| button2.BackColor == Color.LightGreen||button3.BackColor == Color.LightGreen)
            {
                score--;
                labelScore.Text = Convert.ToString(score);
            }
          
            timer = 10;
            labelTimer.Text = Convert.ToString(timer);
            timer1.Start();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\emo.jpg");
            button1.Text = "Answer 1";
            button2.Text = "Answer 2";
            button3.Text = "Answer 3";
            btnStart.Text = "START";
            btnStart.Enabled = true;
            button1.Enabled = button2.Enabled = button3.Enabled = btnRestart.Enabled = btnPlayAgain.Enabled = false;
            button1.BackColor = button2.BackColor = button3.BackColor = Color.White;
            QuestionNo = 1;
            score = 0;
            labelScore.Text = Convert.ToString(score);
            timer1.Stop();
            timer = 10;
            labelTimer.Text = Convert.ToString(timer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer == 0)
            {
                timer = 10;
                timer1.Stop();
                
                labelScore.Text = Convert.ToString(score);
                MessageBox.Show("Your Time is Up! ");
            }
            else
            {
                timer--;
            }
            labelTimer.Text = Convert.ToString(timer);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var SenderObject = (Button)sender;
            int ButtonTag = Convert.ToInt32(SenderObject.Tag);
            if (ButtonTag == correctAns)
            {
                switch (QuestionNo)
                {
                    case 2:
                        button2.BackColor = Color.LightGreen;
                        button1.BackColor = Color.Red;
                        button3.BackColor = Color.Red;
                        break;
                    case 3:
                        button3.BackColor = Color.LightGreen;
                        button1.BackColor = Color.Red;
                        button2.BackColor = Color.Red;
                        break;
                    case 4:
                        button1.BackColor = Color.LightGreen;
                        button3.BackColor = Color.Red;
                        button2.BackColor = Color.Red;
                        break;
                }
                button1.Enabled = button2.Enabled = button3.Enabled = false;
                score++;
                timer1.Stop();
                labelScore.Text = Convert.ToString(score);
            }
            else
            {
                SenderObject.BackColor = Color.Red;

                labelScore.Text = Convert.ToString(score);
            }
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
