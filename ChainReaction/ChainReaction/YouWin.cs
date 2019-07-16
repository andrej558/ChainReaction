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
    public partial class YouWin : Form
    {
        public YouWin()
        {
            InitializeComponent();
        }

        private void LblYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void LblNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
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

        private void YouWin_Load(object sender, EventArgs e)
        {

        }
    }
}
