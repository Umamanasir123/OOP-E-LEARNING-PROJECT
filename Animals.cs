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
    public partial class Animals : Form
    {
        public Animals()
        {
            InitializeComponent();
        }

        private void dogbtn_Click(object sender, EventArgs e)
        {
           pictureBox1.Image = Image.FromFile(@"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\Resources\dog.jpg");
        }

        private void Animals_Load(object sender, EventArgs e)
        {

        }
        private void bearbtn_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\Resources\bear.jpg");

        }
        private void cowbtn_Click(object sender, EventArgs e)
        {
           pictureBox3.Image = Image.FromFile(@"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\Resources\cow.jpg");
        }

        private void lionbtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\Resources\lion.jpg");
        }

        private void deerbtn_Click(object sender, EventArgs e)
        {
           pictureBox4.Image = Image.FromFile(@"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\Resources\deer.jpg");

        }

        private void monkeybtn_Click(object sender, EventArgs e)
        {
          pictureBox6.Image = Image.FromFile(@"C:\Users\Qasim\source\repos\ScienceForKids\ScienceForKids\Resources\monkey.png");

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LearningSource al = new LearningSource();
            al.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            al.Show();
        }
    }
}
