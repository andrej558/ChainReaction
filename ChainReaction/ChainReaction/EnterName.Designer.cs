namespace ChainReaction
{
    partial class EnterName
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnEnterName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.ForeColor = System.Drawing.Color.White;
            this.lblEnterName.Location = new System.Drawing.Point(103, 9);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(207, 31);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter Nickname";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.OldLace;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(12, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(383, 38);
            this.tbName.TabIndex = 1;
            this.tbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbName_KeyUp);
            // 
            // btnEnterName
            // 
            this.btnEnterName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEnterName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterName.ForeColor = System.Drawing.Color.White;
            this.btnEnterName.Location = new System.Drawing.Point(12, 129);
            this.btnEnterName.Name = "btnEnterName";
            this.btnEnterName.Size = new System.Drawing.Size(383, 41);
            this.btnEnterName.TabIndex = 2;
            this.btnEnterName.Text = "OK";
            this.btnEnterName.UseVisualStyleBackColor = false;
            this.btnEnterName.Click += new System.EventHandler(this.BtnEnterName_Click);
            // 
            // EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChainReaction.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(407, 187);
            this.Controls.Add(this.btnEnterName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblEnterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterName";
            this.Load += new System.EventHandler(this.EnterName_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterName_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnEnterName;
    }
}