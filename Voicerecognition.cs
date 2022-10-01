using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace SecondSemOOPproject
{
    public partial class Voicerecognition : Form
    {
        int timer = 30;
        int score = 0;
        int done = 1;
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synEngine = new SpeechSynthesizer();

        public Voicerecognition()
        {
            InitializeComponent();
        }

        private void Voicerecognition_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\voice.jpg");
            btnenable.Enabled = btnDisable.Enabled = btnPlayAgain.Enabled = btnPronounce.Enabled = btnRestart.Enabled = false;
            timer1.Stop();
            Choices command = new Choices();
            command.Add(new string[] { "sun", "look", "star" });
            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(command);
            Grammar grammer = new Grammar(gbuilder);
            recEngine.LoadGrammarAsync(grammer);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (done)
            {
                case 2:
                    if (e.Result.Text == "sun")
                    {
                        labelShow.Text = "Sun";
                        score++;
                        timer1.Stop();
                    }
                    else
                    {
                        labelShow.Text = "Try again";
                    }
                    break;
                case 3:
                    if (e.Result.Text == "look")
                    {
                        labelShow.Text = "Look";
                        score++;
                        timer1.Stop();
                    }
                    else
                    {
                        labelShow.Text = "Try Again";

                    }
                    break;
                case 4:
                    if (e.Result.Text == "star")
                    {
                        labelShow.Text = "Star";
                        score++;
                        timer1.Stop();
                    }
                    else
                    {
                        labelShow.Text = "Try again";
                    }
                    break;
            }
            labelScore.Text = Convert.ToString(score);
        }

        private void btnenable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
        }

        private void btnPronounce_Click(object sender, EventArgs e)
        {
            switch (done)
            {
                case 2:
                    synEngine.SpeakAsync("sun");
                    break;
                case 3:
                    synEngine.SpeakAsync("look");
                    break;
                case 4:
                    synEngine.SpeakAsync("star");
                    break;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == "START")
            {
                btnstart.Text = "NEXT";

            }
            AssignValue(done);
            timer = 30;
            labelTimer.Text = Convert.ToString(timer);
            timer1.Start();
            done++;
            labelShow.Text = " ";
            btnPlayAgain.Enabled = btnenable.Enabled = btnDisable.Enabled =
                btnPronounce.Enabled = true;
            if (done == 4)
            {
                btnstart.Enabled = false;
                btnRestart.Enabled = true;

            }
        }
        private void AssignValue(int d)
        {
            switch (d)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\Sun.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\look.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\star2.jpg");
                    break;
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if(labelShow.Text=="Sun"||labelShow.Text=="Look"||labelShow.Text=="Star")
            {
                score--;
                labelScore.Text = Convert.ToString(score);
            }
            labelShow.Text = " ";
            timer = 30;
            labelTimer.Text = Convert.ToString(timer);
            timer1.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\Downloads\voice.jpg");
            btnstart.Enabled = true;
            btnstart.Text = "Start";
            btnenable.Enabled = btnDisable.Enabled = btnPlayAgain.Enabled = btnPronounce.Enabled = btnRestart.Enabled = false;
            labelShow.Text = " ";
            done = 1;
            score = 0;
            labelScore.Text = Convert.ToString(score);
            timer1.Stop();
            timer = 30;
            labelTimer.Text = Convert.ToString(timer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer == 0)
            {
                timer = 30;
                timer1.Stop();             
                labelScore.Text = Convert.ToString(score);
                //done--;
                MessageBox.Show("time is up");
            }
            else
            {
                timer--;
            }
            labelTimer.Text = Convert.ToString(timer);
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
