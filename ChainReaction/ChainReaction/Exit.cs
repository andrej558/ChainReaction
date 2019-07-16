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
    public partial class Exit : Form
    {
        public Form MainMenu { get; set; }
        public Exit(Form MainMenu)
        {
            this.MainMenu = MainMenu;
            InitializeComponent();
        }
        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void LblYes_Click(object sender, EventArgs e)
        {
            MainMenu.Close();
            this.Close();
        }

        private void LblNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblYes_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblYes.ForeColor = Color.Yellow;
        }

        private void LblYes_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblYes.ForeColor = Color.White;
        }

        private void LblNo_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblNo.ForeColor = Color.Yellow;
        }

        private void LblNo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblNo.ForeColor = Color.White;
        }
    }
}
