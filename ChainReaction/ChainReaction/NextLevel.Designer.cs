namespace ChainReaction
{
    partial class NextLevel
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
            this.lblNo = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNextLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(230, 94);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(45, 29);
            this.lblNo.TabIndex = 7;
            this.lblNo.Text = "No";
            this.lblNo.Click += new System.EventHandler(this.LblNo_Click);
            this.lblNo.MouseEnter += new System.EventHandler(this.LblNo_MouseEnter);
            this.lblNo.MouseLeave += new System.EventHandler(this.LblNo_MouseLeave);
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.BackColor = System.Drawing.Color.Transparent;
            this.lblYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.ForeColor = System.Drawing.Color.White;
            this.lblYes.Location = new System.Drawing.Point(127, 94);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(55, 29);
            this.lblYes.TabIndex = 6;
            this.lblYes.Text = "Yes";
            this.lblYes.Click += new System.EventHandler(this.LblYes_Click);
            this.lblYes.MouseEnter += new System.EventHandler(this.LblYes_MouseEnter);
            this.lblYes.MouseLeave += new System.EventHandler(this.LblYes_MouseLeave);
            // 
            // lblNextLevel
            // 
            this.lblNextLevel.AutoSize = true;
            this.lblNextLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblNextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextLevel.ForeColor = System.Drawing.Color.White;
            this.lblNextLevel.Location = new System.Drawing.Point(71, 9);
            this.lblNextLevel.Name = "lblNextLevel";
            this.lblNextLevel.Size = new System.Drawing.Size(275, 31);
            this.lblNextLevel.TabIndex = 5;
            this.lblNextLevel.Text = "You win, Next Level ?";
            this.lblNextLevel.Click += new System.EventHandler(this.LblNextLevel_Click);
            // 
            // NextLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(407, 158);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.lblNextLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NextLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextLevel";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.NextLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNextLevel;
    }
}