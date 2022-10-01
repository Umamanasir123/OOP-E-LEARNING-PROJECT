
namespace SecondSemOOPproject
{
    partial class Voicerecognition
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.btnenable = new Guna.UI2.WinForms.Guna2Button();
            this.btnDisable = new Guna.UI2.WinForms.Guna2Button();
            this.btnPronounce = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlayAgain = new Guna.UI2.WinForms.Guna2Button();
            this.btnstart = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestart = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(734, 57);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOICE RECOGNITION";
            // 
            // labelShow
            // 
            this.labelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(325, 266);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(100, 35);
            this.labelShow.TabIndex = 2;
            // 
            // btnenable
            // 
            this.btnenable.AutoRoundedCorners = true;
            this.btnenable.BackColor = System.Drawing.Color.Transparent;
            this.btnenable.BorderRadius = 27;
            this.btnenable.CheckedState.Parent = this.btnenable;
            this.btnenable.CustomImages.Parent = this.btnenable;
            this.btnenable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnenable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnenable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnenable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnenable.DisabledState.Parent = this.btnenable;
            this.btnenable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnenable.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenable.ForeColor = System.Drawing.Color.Black;
            this.btnenable.HoverState.Parent = this.btnenable;
            this.btnenable.Location = new System.Drawing.Point(78, 316);
            this.btnenable.Name = "btnenable";
            this.btnenable.ShadowDecoration.Parent = this.btnenable;
            this.btnenable.Size = new System.Drawing.Size(180, 57);
            this.btnenable.TabIndex = 3;
            this.btnenable.Text = "ENABLE VOICE CONTROL";
            this.btnenable.UseTransparentBackground = true;
            this.btnenable.Click += new System.EventHandler(this.btnenable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.AutoRoundedCorners = true;
            this.btnDisable.BackColor = System.Drawing.Color.Transparent;
            this.btnDisable.BorderRadius = 27;
            this.btnDisable.CheckedState.Parent = this.btnDisable;
            this.btnDisable.CustomImages.Parent = this.btnDisable;
            this.btnDisable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisable.DisabledState.Parent = this.btnDisable;
            this.btnDisable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisable.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.Black;
            this.btnDisable.HoverState.Parent = this.btnDisable;
            this.btnDisable.Location = new System.Drawing.Point(289, 316);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.ShadowDecoration.Parent = this.btnDisable;
            this.btnDisable.Size = new System.Drawing.Size(180, 57);
            this.btnDisable.TabIndex = 4;
            this.btnDisable.Text = "DISABLE VOICE CONTROL";
            this.btnDisable.UseTransparentBackground = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnPronounce
            // 
            this.btnPronounce.AutoRoundedCorners = true;
            this.btnPronounce.BackColor = System.Drawing.Color.Transparent;
            this.btnPronounce.BorderRadius = 27;
            this.btnPronounce.CheckedState.Parent = this.btnPronounce;
            this.btnPronounce.CustomImages.Parent = this.btnPronounce;
            this.btnPronounce.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPronounce.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPronounce.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPronounce.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPronounce.DisabledState.Parent = this.btnPronounce;
            this.btnPronounce.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPronounce.Font = new System.Drawing.Font("Algerian", 18F);
            this.btnPronounce.ForeColor = System.Drawing.Color.Black;
            this.btnPronounce.HoverState.Parent = this.btnPronounce;
            this.btnPronounce.Location = new System.Drawing.Point(497, 316);
            this.btnPronounce.Name = "btnPronounce";
            this.btnPronounce.ShadowDecoration.Parent = this.btnPronounce;
            this.btnPronounce.Size = new System.Drawing.Size(180, 57);
            this.btnPronounce.TabIndex = 5;
            this.btnPronounce.Text = "PRONOUNCE";
            this.btnPronounce.UseTransparentBackground = true;
            this.btnPronounce.Click += new System.EventHandler(this.btnPronounce_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.AutoRoundedCorners = true;
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.BorderRadius = 21;
            this.btnPlayAgain.CheckedState.Parent = this.btnPlayAgain;
            this.btnPlayAgain.CustomImages.Parent = this.btnPlayAgain;
            this.btnPlayAgain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayAgain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayAgain.DisabledState.Parent = this.btnPlayAgain;
            this.btnPlayAgain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlayAgain.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.HoverState.Parent = this.btnPlayAgain;
            this.btnPlayAgain.Location = new System.Drawing.Point(68, 393);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.ShadowDecoration.Parent = this.btnPlayAgain;
            this.btnPlayAgain.Size = new System.Drawing.Size(190, 45);
            this.btnPlayAgain.TabIndex = 6;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseTransparentBackground = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnstart
            // 
            this.btnstart.AutoRoundedCorners = true;
            this.btnstart.BackColor = System.Drawing.Color.Transparent;
            this.btnstart.BorderRadius = 21;
            this.btnstart.CheckedState.Parent = this.btnstart;
            this.btnstart.CustomImages.Parent = this.btnstart;
            this.btnstart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstart.DisabledState.Parent = this.btnstart;
            this.btnstart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnstart.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.btnstart.ForeColor = System.Drawing.Color.Black;
            this.btnstart.HoverState.Parent = this.btnstart;
            this.btnstart.Location = new System.Drawing.Point(289, 393);
            this.btnstart.Name = "btnstart";
            this.btnstart.ShadowDecoration.Parent = this.btnstart;
            this.btnstart.Size = new System.Drawing.Size(192, 45);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "START";
            this.btnstart.UseTransparentBackground = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.AutoRoundedCorners = true;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BorderRadius = 21;
            this.btnRestart.CheckedState.Parent = this.btnRestart;
            this.btnRestart.CustomImages.Parent = this.btnRestart;
            this.btnRestart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestart.DisabledState.Parent = this.btnRestart;
            this.btnRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRestart.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.HoverState.Parent = this.btnRestart;
            this.btnRestart.Location = new System.Drawing.Point(497, 393);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ShadowDecoration.Parent = this.btnRestart;
            this.btnRestart.Size = new System.Drawing.Size(180, 45);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseTransparentBackground = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecondSemOOPproject.Properties.Resources.voice;
            this.pictureBox1.Location = new System.Drawing.Point(224, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(138, 111);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(51, 16);
            this.labelTimer.TabIndex = 9;
            this.labelTimer.Text = "label2";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(701, 111);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(16, 16);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIME LEFT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "SCORE";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2AnimateWindow1.Interval = 900;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(66, 15);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 13;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Voicerecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnPronounce);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnenable);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voicerecognition";
            this.Text = "Voicerecognition";
            this.Load += new System.EventHandler(this.Voicerecognition_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelShow;
        private Guna.UI2.WinForms.Guna2Button btnenable;
        private Guna.UI2.WinForms.Guna2Button btnDisable;
        private Guna.UI2.WinForms.Guna2Button btnPronounce;
        private Guna.UI2.WinForms.Guna2Button btnPlayAgain;
        private Guna.UI2.WinForms.Guna2Button btnstart;
        private Guna.UI2.WinForms.Guna2Button btnRestart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}