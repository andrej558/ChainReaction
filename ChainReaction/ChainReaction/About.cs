﻿using System;
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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}
