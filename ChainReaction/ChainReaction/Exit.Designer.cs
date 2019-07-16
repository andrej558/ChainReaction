namespace ChainReaction
{
    partial class Exit
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
            this.lblAreYouSure = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAreYouSure
            // 
            this.lblAreYouSure.AutoSize = true;
            this.lblAreYouSure.BackColor = System.Drawing.Color.Transparent;
            this.lblAreYouSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouSure.ForeColor = System.Drawing.Color.White;
            this.lblAreYouSure.Location = new System.Drawing.Point(18, 9);
            this.lblAreYouSure.Name = "lblAreYouSure";
            this.lblAreYouSure.Size = new System.Drawing.Size(377, 31);
            this.lblAreYouSure.TabIndex = 0;
            this.lblAreYouSure.Text = "Are you sure you want to exit?";
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.BackColor = System.Drawing.Color.Transparent;
            this.lblYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.ForeColor = System.Drawing.Color.White;
            this.lblYes.Location = new System.Drawing.Point(134, 89);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(55, 29);
            this.lblYes.TabIndex = 1;
            this.lblYes.Text = "Yes";
            this.lblYes.Click += new System.EventHandler(this.LblYes_Click);
            this.lblYes.MouseEnter += new System.EventHandler(this.LblYes_MouseEnter);
            this.lblYes.MouseLeave += new System.EventHandler(this.LblYes_MouseLeave);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(223, 89);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(45, 29);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = "No";
            this.lblNo.Click += new System.EventHandler(this.LblNo_Click);
            this.lblNo.MouseEnter += new System.EventHandler(this.LblNo_MouseEnter);
            this.lblNo.MouseLeave += new System.EventHandler(this.LblNo_MouseLeave);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChainReaction.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(407, 158);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.lblAreYouSure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.Load += new System.EventHandler(this.Exit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAreYouSure;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
    }
}