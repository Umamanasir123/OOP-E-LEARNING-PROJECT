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
    public partial class LearningSource : Form
    {
        public LearningSource()
        {
            InitializeComponent();
        }

        private void emotioncards_Click(object sender, EventArgs e)
        {
            EmotionCards ec = new EmotionCards();
            ec.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            ec.Show();
            this.Hide();
        }

        private void shapes_Click(object sender, EventArgs e)
        {
            GeomShapes gs = new GeomShapes();
            gs.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            gs.Show();
            this.Hide();
        }

        private void dodgingmaths_Click(object sender, EventArgs e)
        {
            Memory dm = new Memory();
           dm.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            dm.Show();
            this.Hide();
        }

        private void hangman_Click(object sender, EventArgs e)
        {
            HangsMan hm = new HangsMan();
            hm.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            hm.Show();
            this.Hide();
        }

        private void speechtotext_Click(object sender, EventArgs e)
        {
            Voicerecognition gs = new Voicerecognition();
            gs.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            gs.Show();
            this.Hide();
        }

        private void fractions_Click(object sender, EventArgs e)
        {
            Fractions f = new Fractions();
            f.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            f.Show();
            this.Hide();
        }

        private void humansenses_Click(object sender, EventArgs e)
        {
            HumanSenses hs = new HumanSenses();
            hs.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            hs.Show();
            this.Hide();
        }

        private void animals_Click(object sender, EventArgs e)
        {
            Animals an = new Animals();
            an.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            an.Show();
        }

        private void alphabets_Click(object sender, EventArgs e)
        {
            EngAlphabets en = new EngAlphabets();
            en.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            en.Show();
            this.Hide();
        }

        private void guesssinggame_Click(object sender, EventArgs e)
        {
            Guessgame hg = new Guessgame();
            hg.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_CENTER;
            hg.Show();
            this.Hide();
        }

        private void childhood_Click(object sender, EventArgs e)
        {
            ProphetsCildhood pc = new ProphetsCildhood();
            pc.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            pc.Show();
            this.Hide();
        }


        private void duas_Click(object sender, EventArgs e)
        {
            Islamiat isl = new Islamiat();
            isl.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HIDE;
            isl.Show();
            this.Hide();
        }

        private void fourpicsoneword_Click(object sender, EventArgs e)
        {
            fourPicsOneWord fp = new fourPicsOneWord();
            fp.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            fp.Show();
            this.Hide();
        }

        private void dodging2_Click(object sender, EventArgs e)
        {
           DodgingMaths hd = new DodgingMaths();
            hd.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            hd.Show();
            this.Hide();
        }
    }
}
