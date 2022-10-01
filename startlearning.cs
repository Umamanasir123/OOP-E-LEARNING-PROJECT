using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SecondSemOOPproject
{
    public partial class startlearning : Form
    {
        private SoundPlayer _soundPlayer;
        public startlearning()
        {
            InitializeComponent();
        }
        int time = 30;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
           guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;

        }
     
        private void startlearning_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Qasim\Downloads\learningdua.wav");
            _soundPlayer.Play();
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time==0)
            {
                LearningSource ls = new LearningSource();
                ls.Show();
                this.Hide();
                _soundPlayer.Stop();
                timer1.Stop();
            }
            else
            {
                time--;
            }
        }
    }
}
