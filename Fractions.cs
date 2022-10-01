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
    public partial class Fractions : Form
    {
        public Fractions()
        {
            InitializeComponent();
        }
        int score = 0;
        int time = 30;
        Random r = new Random();
        private void Fractions_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void Allradiobuttons(object sender, EventArgs e)
        {
            var senberButton = (RadioButton)sender;
            if (radioButton1.Checked || radioButton5.Checked || radioButton9.Checked || radioButton10.Checked || radioButton14.Checked)
            {
                checkAns();
                score++;
                labelScore.Text = Convert.ToString(score);
                
            }
            else
            {
                MessageBox.Show("try again");
                senberButton.Checked = false;
            }
        }
        private void checkAns()
        {
            if (radioButton1.Checked && radioButton5.Checked && radioButton9.Checked && radioButton10.Checked && radioButton14.Checked)
            {
                timer1.Stop();
                MessageBox.Show("Congratulations");
            
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time==0)
            {
                time = 30;
                timer1.Stop();
                MessageBox.Show("Time is Up");
            }
            else
            {
                time--;
            }
            Timelabel.Text = Convert.ToString(time);
            int red = r.Next(0, 255);
            int green = r.Next(0, 255);
            int blue = r.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
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
