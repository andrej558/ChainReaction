namespace ChainReaction
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chain Reaction";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(225, 106);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(98, 46);
            this.lblPlay.TabIndex = 0;
            this.lblPlay.Text = "Play";
            this.lblPlay.Click += new System.EventHandler(this.LblPlay_Click);
            this.lblPlay.MouseEnter += new System.EventHandler(this.LblPlay_MouseEnter);
            this.lblPlay.MouseLeave += new System.EventHandler(this.LblPlay_MouseLeave);
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.ForeColor = System.Drawing.Color.White;
            this.lblHighScores.Location = new System.Drawing.Point(156, 203);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(239, 46);
            this.lblHighScores.TabIndex = 1;
            this.lblHighScores.Text = "High Scores";
            this.lblHighScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScores.Click += new System.EventHandler(this.LblHighScores_Click);
            this.lblHighScores.MouseEnter += new System.EventHandler(this.LblHighScores_MouseEnter);
            this.lblHighScores.MouseLeave += new System.EventHandler(this.LblHighScores_MouseLeave);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(225, 397);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(88, 46);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.LblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.LblExit_MouseLeave);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(212, 300);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(125, 46);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            this.lblAbout.MouseEnter += new System.EventHandler(this.LblAbout_MouseEnter);
            this.lblAbout.MouseLeave += new System.EventHandler(this.LblAbout_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChainReaction.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(534, 485);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chain Reaction";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblAbout;
    }
}