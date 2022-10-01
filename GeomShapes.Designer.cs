
namespace SecondSemOOPproject
{
    partial class GeomShapes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.choosecolourcombo = new System.Windows.Forms.ComboBox();
            this.timerformulticol = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.selectPaint = new Guna.UI2.WinForms.Guna2PictureBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.rectangle = new System.Windows.Forms.PictureBox();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.square = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(244, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(728, 47);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(19, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 7;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAINTING ON GEOMETRICAL SHAPES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // choosecolourcombo
            // 
            this.choosecolourcombo.FormattingEnabled = true;
            this.choosecolourcombo.Items.AddRange(new object[] {
            "Beige",
            "Aqua",
            "Forest Green",
            "Orange Red",
            "Green Yellow",
            "Medium Purple",
            "Deep Pink",
            "MultiColours"});
            this.choosecolourcombo.Location = new System.Drawing.Point(725, 57);
            this.choosecolourcombo.Name = "choosecolourcombo";
            this.choosecolourcombo.Size = new System.Drawing.Size(145, 21);
            this.choosecolourcombo.TabIndex = 6;
            // 
            // timerformulticol
            // 
            this.timerformulticol.Enabled = true;
            this.timerformulticol.Tick += new System.EventHandler(this.timerformulticol_Tick);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            this.guna2AnimateWindow1.Interval = 900;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // selectPaint
            // 
            this.selectPaint.BackColor = System.Drawing.Color.Transparent;
            this.selectPaint.BorderRadius = 23;
            this.selectPaint.Image = global::SecondSemOOPproject.Properties.Resources.shapes;
            this.selectPaint.ImageRotate = 0F;
            this.selectPaint.Location = new System.Drawing.Point(751, 193);
            this.selectPaint.Name = "selectPaint";
            this.selectPaint.ShadowDecoration.Parent = this.selectPaint;
            this.selectPaint.Size = new System.Drawing.Size(221, 249);
            this.selectPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectPaint.TabIndex = 5;
            this.selectPaint.TabStop = false;
            this.selectPaint.UseTransparentBackground = true;
            this.selectPaint.Click += new System.EventHandler(this.selectPaint_Click);
            // 
            // circle
            // 
            this.circle.Image = global::SecondSemOOPproject.Properties.Resources.circle;
            this.circle.Location = new System.Drawing.Point(24, 271);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(208, 115);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle.TabIndex = 3;
            this.circle.TabStop = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Image = global::SecondSemOOPproject.Properties.Resources.rectangle;
            this.rectangle.Location = new System.Drawing.Point(12, 9);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(187, 115);
            this.rectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectangle.TabIndex = 2;
            this.rectangle.TabStop = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // triangle
            // 
            this.triangle.Image = global::SecondSemOOPproject.Properties.Resources.tringle;
            this.triangle.Location = new System.Drawing.Point(372, 57);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(208, 115);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangle.TabIndex = 1;
            this.triangle.TabStop = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // square
            // 
            this.square.Image = global::SecondSemOOPproject.Properties.Resources.square;
            this.square.Location = new System.Drawing.Point(517, 250);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(187, 124);
            this.square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.square.TabIndex = 0;
            this.square.TabStop = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "After choosing colour, Click this pic\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "NOTE: Click on the pictures to get that shapes and colour it!";
            // 
            // GeomShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(987, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choosecolourcombo);
            this.Controls.Add(this.selectPaint);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.square);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeomShapes";
            this.Text = "GeomShapes";
            this.Load += new System.EventHandler(this.GeomShapes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeomShapes_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeomShapes_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeomShapes_MouseUp);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox square;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.PictureBox rectangle;
        private System.Windows.Forms.PictureBox circle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox selectPaint;
        private System.Windows.Forms.ComboBox choosecolourcombo;
        private System.Windows.Forms.Timer timerformulticol;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}