namespace ChainReaction
{
    public partial class Form1
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLevelPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTotalPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtToCollect = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCollected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(170, 37);
            this.toolStripStatusLabel1.Text = "Level Points:";
            // 
            // txtLevelPoints
            // 
            this.txtLevelPoints.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtLevelPoints.Name = "txtLevelPoints";
            this.txtLevelPoints.Size = new System.Drawing.Size(32, 37);
            this.txtLevelPoints.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(166, 37);
            this.toolStripStatusLabel2.Text = "Total Points: ";
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.Size = new System.Drawing.Size(32, 37);
            this.txtTotalPoints.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 37);
            this.toolStripStatusLabel3.Text = "Level:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial Black", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtLevelPoints,
            this.toolStripStatusLabel2,
            this.txtTotalPoints,
            this.toolStripStatusLabel3,
            this.txtLevel,
            this.txtToCollect,
            this.txtCollected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(32, 37);
            this.txtLevel.Text = "0";
            // 
            // txtToCollect
            // 
            this.txtToCollect.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtToCollect.Name = "txtToCollect";
            this.txtToCollect.Size = new System.Drawing.Size(23, 37);
            this.txtToCollect.Text = ".";
            // 
            // txtCollected
            // 
            this.txtCollected.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtCollected.Name = "txtCollected";
            this.txtCollected.Size = new System.Drawing.Size(23, 37);
            this.txtCollected.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(926, 505);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Chain Reaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtLevelPoints;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtTotalPoints;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtLevel;
        private System.Windows.Forms.ToolStripStatusLabel txtToCollect;
        private System.Windows.Forms.ToolStripStatusLabel txtCollected;
    }
}

