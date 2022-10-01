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
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
        }
        int time = 20;
        Graphics g;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                guna2PictureBox1.Visible = false;

                memory2 m = new memory2();
                m.Show();
                this.Hide();
                timer1.Stop();
            }
            else
            {
                time--;
                guna2PictureBox1.Visible = true;

            }
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
