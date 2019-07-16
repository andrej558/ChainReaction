using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainReaction
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void LblPlay_Click(object sender, EventArgs e)
        {
            EnterName enterName = new EnterName();
            
            if (enterName.ShowDialog() == DialogResult.OK) {

                Player p1 = new Player(enterName.tbName.Text, DateTime.Now, 0, 0);
                
                Form1 f1 = new Form1(p1);

                this.Hide();
                f1.ShowDialog();
            } 
        }
        private void LblExit_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit(this);
            
            exit.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void LblAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void LblHighScores_Click(object sender, EventArgs e)
        {
            HighScores hs = new HighScores();
            hs.ShowDialog();
        }
        private void LblPlay_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblPlay.ForeColor = Color.Yellow;
        }
        private void LblPlay_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblPlay.ForeColor = Color.White;
        }
        private void LblHighScores_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblHighScores.ForeColor = Color.Yellow;
        }

        private void LblHighScores_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblHighScores.ForeColor = Color.White;
        }

        private void LblAbout_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblAbout.ForeColor = Color.Yellow;
        }

        private void LblAbout_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblAbout.ForeColor = Color.White;
        }

        private void LblExit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblExit.ForeColor = Color.Yellow;
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblExit.ForeColor = Color.White;
        }
    }
}
