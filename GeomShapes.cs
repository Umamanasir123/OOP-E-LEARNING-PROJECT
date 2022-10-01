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
    public partial class GeomShapes : Form
    {
        Pen p = new Pen(Color.Black);
        Pen pen;
        bool paint = false;
        Graphics g;
        Random r = new Random();
        public GeomShapes()
        {
            InitializeComponent();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawRectangle(p, 50, 140, 200, 120);
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawPie(p, 240, 5, 200, 300, 30, 45);
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawEllipse(p, 50, 390, 120, 140);
        }

        private void square_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawRectangle(p, 350, 390, 130, 130);
        }

        private void selectPaint_Click(object sender, EventArgs e)
        {
            switch (choosecolourcombo.SelectedItem)
            {
                case "Beige":
                    {
                        pen = new Pen(Color.Beige);
                        break;
                    }
                case "Aqua":
                    {
                        pen = new Pen(Color.Aqua);
                        break;
                    }
                case "Forest Green":
                    {
                        pen = new Pen(Color.ForestGreen);
                        break;
                    }
                case "Orange Red":
                    {
                        pen = new Pen(Color.OrangeRed);
                        break;
                    }
                case "Green Yellow":
                    {
                        pen = new Pen(Color.GreenYellow);
                        break;
                    }
                case "Medium Purple":
                    {
                        pen = new Pen(Color.MediumPurple);
                        break;
                    }
                case "Deep Pink":
                    {
                        pen = new Pen(Color.DeepPink);
                        break;
                    }
               
                
            }
        }

        private void GeomShapes_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                g = CreateGraphics();
                g.DrawEllipse(pen, e.X, e.Y, 8, 8);
            
            }
        }

        private void GeomShapes_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void GeomShapes_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void timerformulticol_Tick(object sender, EventArgs e)
        {
            if (choosecolourcombo.SelectedItem == "MultiColours")
            {
                int red = r.Next(0, 255);
                int green = r.Next(0, 255);
                int blue = r.Next(0, 255);
                pen = new Pen(Color.FromArgb(red, green, blue));
               
            }
        }

        private void GeomShapes_Load(object sender, EventArgs e)
        {
        
            this.Size = new Size(990, 600);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            LearningSource ls = new LearningSource();
            ls.Show();
            this.Hide();
           
        }
    }
}
