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
    public partial class HighScores : Form
    {
        private FileReader dataReader;
        public HighScores()
        {
            InitializeComponent();
            dataReader = new FileReader();
            WriteHighScore();
        }
        public void WriteHighScore()
        {
            List<string> lastplayers = dataReader.getPlayers();  //gets last 5 players from database
            int[] offset_x = { 0, 223, 460, 628 };
            int[] offset_y = { 0, 54, 108, 162, 216 };
            int x = 197;
            int y = 141;

            for (int i = 0; i < lastplayers.Count(); i++) {
                string[] player = lastplayers[i].Split(',');
                for (int j = 0; j < player.Count(); j++)
                {
                    CreateLabel(player[j], new Point(x, y), offset_x[j], offset_y[i]);
                }
            }
        }
        public void CreateLabel(string title, Point location, int off_x, int off_y)
        {
            Label label = new Label();
            label.Text = title;
            label.Location = new Point(location.X+off_x,location.Y+off_y);
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.White;
            label.AutoSize = true;
            label.Visible = true;
            label.Font = new Font(new FontFamily("Microsoft Sans Serif"), 25f, FontStyle.Regular, GraphicsUnit.Pixel);
            Controls.Add(label);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {

        }
        private void HighScores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}
