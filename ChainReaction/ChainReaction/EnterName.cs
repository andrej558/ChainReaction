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
    public partial class EnterName : Form
    {
        public EnterName()
        {
            InitializeComponent();
        }

        private void EnterName_Load(object sender, EventArgs e)
        {

        }
        private void BtnEnterName_Click(object sender, EventArgs e)
        {
            CheckValidName();
        }

        private void EnterName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                CheckValidName();
            }
        }
        private void CheckValidName() {
            //TODO: Name must contain at least one letter and no special characters
            if (tbName.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void TbName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                CheckValidName();
            }   
        }
    }
}
