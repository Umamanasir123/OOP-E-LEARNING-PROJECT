
namespace SecondSemOOPproject
{
    partial class CoverPg
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.regbtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginbtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecondSemOOPproject.Properties.Resources.coverpg;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "KIDS E-LEARNING ACADEMY";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(717, 51);
            this.guna2Panel1.TabIndex = 2;
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.Transparent;
            this.regbtn.BorderRadius = 20;
            this.regbtn.CheckedState.Parent = this.regbtn;
            this.regbtn.CustomImages.Parent = this.regbtn;
            this.regbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.regbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.regbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.regbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.regbtn.DisabledState.Parent = this.regbtn;
            this.regbtn.FillColor = System.Drawing.Color.MediumTurquoise;
            this.regbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.ForeColor = System.Drawing.Color.Black;
            this.regbtn.HoverState.Parent = this.regbtn;
            this.regbtn.Location = new System.Drawing.Point(570, 83);
            this.regbtn.Name = "regbtn";
            this.regbtn.ShadowDecoration.Parent = this.regbtn;
            this.regbtn.Size = new System.Drawing.Size(159, 45);
            this.regbtn.TabIndex = 3;
            this.regbtn.Text = "REGISTRATION";
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.BorderRadius = 20;
            this.loginbtn.CheckedState.Parent = this.loginbtn;
            this.loginbtn.CustomImages.Parent = this.loginbtn;
            this.loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginbtn.DisabledState.Parent = this.loginbtn;
            this.loginbtn.FillColor = System.Drawing.Color.MediumTurquoise;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.loginbtn.ForeColor = System.Drawing.Color.Black;
            this.loginbtn.HoverState.Parent = this.loginbtn;
            this.loginbtn.Location = new System.Drawing.Point(570, 134);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.ShadowDecoration.Parent = this.loginbtn;
            this.loginbtn.Size = new System.Drawing.Size(159, 39);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN ";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // CoverPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 448);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CoverPg";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button regbtn;
        private Guna.UI2.WinForms.Guna2Button loginbtn;
    }
}

