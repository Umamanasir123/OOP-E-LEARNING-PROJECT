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
    public partial class WordsMaking : Form
    {
        public WordsMaking()
        {
            InitializeComponent();
        }

        private void WordsMaking_Load(object sender, EventArgs e)
        {

        }
        int score = 0;
        int time = 90;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string[] jan = { "ran", "ray", "run", "jar", "any", "yarn", "jury" };
            for (int i = 0; i < jan.Length; i++)
            {
                if (guna2TextBox1.Text == jan[i])
                {
                    score++;
                    guna2TextBox1.Text = "Correct";
                    guna2TextBox1.Enabled = false;
                }
                if (guna2TextBox2.Text == jan[i])
                {
                    score++;
                    guna2TextBox2.Text = "Correct";
                    guna2TextBox2.Enabled = false;
                }
                if (guna2TextBox3.Text == jan[i])
                {
                    score++;
                    guna2TextBox3.Text = "Correct";
                    guna2TextBox3.Enabled = false;
                }
                Scorelabel.Text = Convert.ToString(score);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string[] sep = { "meter", "metre", "temper", "beeper", "esteem", "tree", "reset", "meet", "seem","stem", "bee", "mere", "met", "set", "bet", "pet" };
            {
                for (int i = 0; i < sep.Length; i++)
                {
                    if (guna2TextBox4.Text == sep[i])
                    {
                        score++;
                        guna2TextBox4.Text = "Correct";
                        guna2TextBox4.Enabled = false;
                    }
                    if (guna2TextBox5.Text == sep[i])
                    {
                        score++;
                        guna2TextBox5.Text = "Correct";
                        guna2TextBox5.Enabled = false;
                    }

                    if (guna2TextBox6.Text == sep[i])
                    {
                        score++;
                        guna2TextBox6.Text = "Correct";
                        guna2TextBox6.Enabled = false;
                    }

                    if (guna2TextBox7.Text == sep[i])
                    {
                        score++;
                        guna2TextBox7.Text = "Correct";
                        guna2TextBox7.Enabled = false;
                    }
                    Scorelabel.Text = Convert.ToString(score);
                }
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string[] nov = { "remove", "venom","men", "never", "nerve", "oven", "more", "move", "over", "born", "bore", "robe", "bone", "ever", "even", "bee" };
            for (int i = 0; i < nov.Length; i++)
            {
                if (guna2TextBox8.Text == nov[i])
                {
                    score++;
                    guna2TextBox8.Text = "Correct";
                    guna2TextBox8.Enabled = false;
                }

                if (guna2TextBox9.Text == nov[i])
                {
                    score++;
                    guna2TextBox9.Text = "Correct";
                    guna2TextBox9.Enabled = false;
                }

                if (guna2TextBox10.Text == nov[i])
                {
                    score++;
                    guna2TextBox10.Text = "Correct";
                    guna2TextBox10.Enabled = false;
                }
                Scorelabel.Text = Convert.ToString(score);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                time = 90;
                timer1.Stop();
                MessageBox.Show("Your time is up!");

            }

            else
            {
                time--;
            }
            timeleftlabel.Text = Convert.ToString(time);
            if (guna2TextBox1.Enabled == false && guna2TextBox2.Enabled == false && guna2TextBox3.Enabled == guna2TextBox4.Enabled == false && guna2TextBox5.Enabled == false && guna2TextBox6.Enabled == false && guna2TextBox7.Enabled == false && guna2TextBox8.Enabled == false && guna2TextBox9.Enabled == false && guna2TextBox10.Enabled == false)
            {
                timer1.Stop();
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
