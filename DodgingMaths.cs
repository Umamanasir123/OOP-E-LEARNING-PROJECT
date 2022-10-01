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
    public partial class DodgingMaths : Form
    {
        Random rn = new Random();
        int sumop1;
        int sumop2;

        int diffop1;
        int diffop2;

        int prodop1;
        int prodop2;

        int ratioop1;
        int ratioop2;

        int time = 30;
        int score = 0;
        public DodgingMaths()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            time = 30;
            startTest();
            mathstimer.Start();
        }
        private void check()
        {
            if (summation.Value == sumop1 + sumop2 && differance.Value == diffop1 - diffop2 && product.Value == prodop1 * prodop2 && ratio.Value == ratioop1 / ratioop2)
            {
           
                MessageBox.Show("congrats! all answers are correct");
                score++;
            }
            else
            {
               
                MessageBox.Show("Try Again! Make sure all answers are correct");

            }
            scoreshowlabel.Text = Convert.ToString(score);
        }

        private void resultbtn_Click(object sender, EventArgs e)
        {
            mathstimer.Stop();
            check();
        }
        private void startTest()
        {
            summation.Value = 0;
            differance.Value = 0;
            product.Value = 0;
            ratio.Value = 0;

            sumop1 = rn.Next(1, 10);
            sumopernd1.Text = sumop1.ToString();

            sumop2 = rn.Next(1, sumop1);
            sumopernd2.Text = sumop2.ToString();

            diffop1 = rn.Next(11, 25);
            diffopernd1.Text = diffop1.ToString();

            diffop2 = rn.Next(1, 10);
            diffopernd2.Text = diffop2.ToString();

            prodop1 = rn.Next(1, 5);
            prodopernd1.Text = prodop1.ToString();

            prodop2 = rn.Next(1, 3);
            prodopernd2.Text = prodop2.ToString();
            ratioop2 = rn.Next(1, 10);
            ratioopernd2.Text = ratioop2.ToString();
            int res;
            res = rn.Next(1, 10);
            ratioop1 = res * ratioop2;
            ratioopernd1.Text = ratioop1.ToString();
        }

        private void mathstimer_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                time = 30;
                mathstimer.Stop();
                MessageBox.Show("Time is up;");
            }
            else
            {
                time--;
            }

            timelabel.Text = Convert.ToString(time);
        }

        private void DodgingMaths_Load(object sender, EventArgs e)
        {
            mathstimer.Stop();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LearningSource ls = new LearningSource();
            ls.Show();
            this.Hide();
            mathstimer.Stop();
        }
    }
}
