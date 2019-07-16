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
    public partial class Form1 : Form
    {
        public Game game;
        private Timer timer;
        private static int pointsGame = 0;
        private static int totalPoints = 0;
        private static int level = 1;
        private static int ballsToCollectRound;
        private static int totalBallsRound;
        private static int collectedBallsRound=0;
        public static bool isDrawing = true;

        public Form1(Player player)
        {
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.WorkingArea.Size.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Size.Height;
            game = new Game(this.Width, this.Height, this,player);
            Cursor.Position = new Point(Width,Height/2);
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += timer1_tick;
            timer.Start();
            InitializeComponent();
            
        }
        ///<summary>
        ///Method called every 1ms to Invalidate the form.
        ///</summary>
        private void timer1_tick(object sender, EventArgs e) {
            if (!isDrawing) {
                return;
            }
            game.Move();
                txtLevelPoints.Text = pointsGame.ToString();
                txtTotalPoints.Text = totalPoints.ToString();
                txtLevel.Text = level.ToString();
            txtToCollect.Text = "Collect " + ballsToCollectRound + " out of " + totalBallsRound+" balls ";
            txtCollected.Text = collectedBallsRound + "/" + totalBallsRound+" balls";
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        ///<summary>
        ///Draws the game and player stats on the form.
        ///</summary>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }
        ///<summary>
        ///Moves the circle tied to the cursor.
        ///</summary>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < game.position.Y||e.Y>game.height+game.position.Y||
                e.X<game.position.X||e.X>game.width+game.position.X)  {
                return;
            }
            game.MoveCircle(e.Location);
        }
        ///<summary>
        ///Clicks to position the circle.
        ///</summary>
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Y < game.position.Y||e.Y>game.height+game.position.Y||
                e.X<game.position.X||e.X>game.width+game.position.X)  {
                return;
            }
            game.Click();
        }
        public static void setTotalBallsRound(int total) {
            totalBallsRound = total;
        }
        public static void BallsToCollectRound(int ammount) {
            ballsToCollectRound = ammount;
        }
        public static void UpdatePoints(int points) {
           
            pointsGame += points;
            totalPoints += points;
        }
        public static void SetCollectedBallsRound(int balls) {
            collectedBallsRound = balls;
        }
        public static void setPointsGame(int points) {
            pointsGame = points;
        }
        public static void ResetScore() {
            pointsGame = totalPoints = 0;
        }
        public static void UpdateLevel(int lvl) {
            level = lvl;
        }
        public static void setLevelTotalPoints(int points) {
            ballsToCollectRound = totalBallsRound = totalPoints = points;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
