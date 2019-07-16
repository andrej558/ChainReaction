using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ChainReaction
{
    public class Game
    {
        public int width { get; private set; }
        public int height { get; private set; }
        public Point position { get; private set; }
        public BallsDoc ballsDoc { get; private set; }
        public CirclesDoc circlesDoc { get; private set; }
        public Random rand { get; private set; }
        public Circle circle { get; set; }
        public bool isClicked { get; set; }
        public Timer timer2 { get; set; }
        public Form myForm { get; private set; }
        public int level { get; private set; }
        public int pointsLevel { get; private set; }
        public Pen pen { get; set; }
        public Dictionary<int, int> RequiredPoints { get; set; }
        public bool isMoving { get; private set; }
        public Player player { get; set; }
        public Timer timer3 { get; set; }
        public Timer timer4 { get; set; }
        public int ballsCollectedRound { get; private set; }

        public Game(int Width, int Height, Form form, Player Player) {
            rand = new Random();
            //this.width = Width*2+90;
            this.width = Width-38;
            this.height = Height-96;
            position = new Point(19,14);
            myForm = form;
            player = Player;
            pen = new Pen(Color.Gray);
            RequiredPoints = new Dictionary<int, int>() {
                {1,200 }, {2,300}, {3,500}, {4,800}, {5,1200}, { 6,2000}
            };
            NewGame();
        }
        public void NewGame() {
            //starts new game from level 1
            Reset();
            StartLevel();
        }
        public void Reset()
        {
            timer4 = new Timer();
            timer4.Interval = 1000;
            timer4.Tick += timer4_tick;

            pointsLevel = 0;
            level = 1;
            Form1.UpdateLevel(1);
            Form1.ResetScore();
        }
        public void StartLevel() {
            //starts the level
            ballsCollectedRound = 0;
            Form1.SetCollectedBallsRound(ballsCollectedRound);
            pointsLevel = 0;
            Form1.setPointsGame(pointsLevel);
            circle = new Circle(Color.Gray, 60);  //circle that follows cursor

            ballsDoc = new BallsDoc();
            circlesDoc = new CirclesDoc();
            Form1.isDrawing = true;

            timer2 = new Timer();     
            timer2.Interval = 1;
            timer2.Tick += timer2_tick;

            timer3 = new Timer();
            timer3.Interval = 1;
            timer3.Tick += timer3_tick;

            if (level == 1)
            {
                GenerateBalls(5);
            }
            else if (level == 2)
            {
                GenerateBalls(10);
            }
            else if (level == 3)
            {
                GenerateBalls(20);
            }
            else if (level == 4)
            {
                GenerateBalls(25);
            }
            else if (level == 5)
            {
                GenerateBalls(30);
            }
            else if (level == 6) {
                GenerateBalls(40);
            }
            else
            {
                Form1.setLevelTotalPoints(0);
                Form1.SetCollectedBallsRound(0);
                //end of game
                circle = null;
                SavePlayer();
                YouWin uWin = new YouWin();
                if (uWin.ShowDialog() == DialogResult.Yes)
                {
                    NewGame();
                }
                else {
                    EndGame();
                }
                return;
            }
            Form1.BallsToCollectRound(RequiredPoints[level]/100);
            Form1.setTotalBallsRound(ballsDoc.balls.Count);

            isMoving = true;
            isClicked = false;
            
            timer4.Start();
        }
        public void timer2_tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ballsDoc.balls.Count; i++)
            {
                for (int j = 0; j < circlesDoc.circles.Count; j++)
                {
                    if (i >= ballsDoc.balls.Count || j >= circlesDoc.circles.Count) {
                        //to avoid index exception
                        continue;
                    } 
                    if (ballsDoc.balls.ElementAt(i).Collide(circlesDoc.circles.ElementAt(j)))
                    {
                        Circle circle = new Circle(ballsDoc.balls.ElementAt(i).position,
                            ballsDoc.balls.ElementAt(i).color, 60, "100");
                        circlesDoc.circles.Add(circle);
                        ballsDoc.balls.RemoveAt(i);
                        player.addPoints(Int32.Parse(circle.Points));
                        circle.timer.Start();
                        AddPoints(Int32.Parse(circle.Points));
                        ballsCollectedRound++;
                        Form1.SetCollectedBallsRound(ballsCollectedRound);
                    }
                }
            }
        }
        /// <summary>
        /// If circle cannot be drawn it is removed from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer3_tick(object sender, EventArgs e) {
            for (int i = 0; i < circlesDoc.circles.Count; i++)
            {
                if (circlesDoc.circles.ElementAt(i).isDrawing == false) {
                    circlesDoc.circles.RemoveAt(i);
                }
            }
            if (circlesDoc.circles.Count == 0)
            {
                EndLevel();
            }
        }
        /// <summary>
        ///Method called every second player plays the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer4_tick(object sender, EventArgs e){
            player.addSecond();
        }
            public void EndLevel() {

            timer2.Dispose();
            timer3.Dispose();
            timer4.Stop();
            
            Form1.isDrawing = false;
            int neededPoints = RequiredPoints[level];
            if (pointsLevel >= neededPoints)
            {
                NextLevel nextLevel = new NextLevel();

                if (nextLevel.ShowDialog() == DialogResult.Yes)
                {
                    level++;

                    StartLevel();
                }
                else {
                    EndGame();
                }
            }
            else {
                GameOver gameOver = new GameOver();
                if (gameOver.ShowDialog() == DialogResult.Yes)
                {
                    NewGame();
                }
                else {
                    EndGame();
                }
            }
            Form1.UpdateLevel(level);
        }

        public void SavePlayer() {
            GameManager.SavePlayer(player);
        }
        public void EndGame() {
            
            myForm.Close();
            myForm.Dispose();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
        public void AddPoints(int points) {
            pointsLevel +=points;
            Form1.UpdatePoints(points);
        }
        private void GenerateBalls(int howMany) {
            int i = 0;
            while (i < howMany)
            {
                //trying to add ball in ballsDoc
                Point position = new Point(rand.Next(Ball.Radius * 2, width - Ball.Radius)+this.position.X,
                    rand.Next(Ball.Radius * 2, height-Ball.Radius)+this.position.Y);
                Ball ball = new Ball(position);
                if (ballsDoc.TryAdd(ball))
                {
                    i++;
                }
            }
        }
        /// <summary>
        /// Draws the map, the balls and circles
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g) {
            if (circle != null) {
                circle.Draw(g);
            }
            DrawTerrain(pen, g);
            ballsDoc.Draw(g);
            circlesDoc.Draw(g);
        }
        private void DrawTerrain(Pen pen,Graphics g) {
            g.DrawLine(pen, position.X, position.Y, width+position.X, position.Y); //horizontal top line
            g.DrawLine(pen, position.X, height+position.Y, width+position.X, height+position.Y); //horizontal bottom line
            g.DrawLine(pen, position.X, position.Y, position.X, height+position.Y); //vertical left line
            g.DrawLine(pen, width+position.X, position.Y, width+position.X, height+position.Y); //vertical right line
            for (int i = position.X; i < width+position.X; i += 45)
            {
                //vertical lines
                g.DrawLine(pen, i, position.Y, i, height+position.Y);
            }
            for (int i = position.Y; i < height+position.Y; i += 45)
            {
                //horizontal lines
                g.DrawLine(pen, position.X, i, width+position.X, i);
            }
            g.FillRegion(new SolidBrush(Color.FromArgb(64,255,165,0)), new Region(new Rectangle(position, new Size(width, height))));
        }
        /// <summary>
        /// Moves balls around terrain
        /// </summary>
        public void Move() {
            ballsDoc.Move(width,height,position.X,position.Y);
        }
        public void MoveCircle(Point loc)
        {
            if (isClicked) return;
            circle.Move(loc);
        }
        public void Click() {
            if (!isClicked) {
                isClicked = true;
                circle.Color = Color.Red;
                circlesDoc.circles.Add(circle);
                circle = null;
                circlesDoc.circles.ElementAt(0).timer.Start();
                timer2.Start();
                timer3.Start();
            }
        }
    }
}
