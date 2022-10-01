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
    public partial class memory2 : Form
    {
        public memory2()
        {
            InitializeComponent();
        }
        int score = 0;

        private void memory2_Load(object sender, EventArgs e)
        {

           ( radioButton1=radioButton2=radioButton3=radioButton4=radioButton5=radioButton6=radioButton7=radioButton8=radioButton9).Checked=false;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton4.Checked || radioButton8.Checked)
            {
                score++;
            }
            scorelbl.Text = Convert.ToString(score);
        }
    }
}
