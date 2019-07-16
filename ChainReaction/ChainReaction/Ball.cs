using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainReaction
{
    public class Ball
    {   
       public static readonly int Radius = 20;

        static Random rnd=new Random();
        public Color color { get; set; }
        public Point position { get; set; }
        public int radius { get; private set; }

        private int dx;
        private int dy;
        public Ball(Point position) {
            this.position = position;
            
            this.color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            this.radius = Radius;
            StartMoving();
        }
        public void Draw(Graphics g) {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, position.X - radius, position.Y - radius, radius * 2, radius * 2);
            b.Dispose();
        }
        public bool Colide(Ball ball)
        {
            int dist = distance(position, ball.position);
            return (radius + ball.radius) * (radius + ball.radius) >= dist;
        }
        public bool Collide(Circle circle) {
            int dist = distance(position, circle.Center);
            return (radius + circle.Radius) * (radius + circle.Radius) >= dist;
        }
        private int distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X)
                + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }
        public void StartMoving() {
            dx = rnd.Next(-8,11); dy = rnd.Next(-8,11);
            if (dx == 0 && dy == 0) {
                StartMoving();
            } 
        }
        public void Move(int Width,int Height,int offsetX, int offsetY) {


            int new_X = position.X + dx;
            int new_Y = position.Y + dy;

            position = new Point(new_X,new_Y);
            

            if (new_Y < radius+offsetY) {
                //ball hits the roof
                if (dx == 0)
                {
                    //90 degrees
                    dx = rnd.Next(-1, 2);
                    dy = -dy;
                }
                else if (dx > 0 && dy < 0)
                {
                    // /
                    dy = -dy;
                }
                else if (dx < 0 && dy < 0)  {
                    // \
                    dy = -dy;
                }
            }
            else if (new_Y > (Height-radius)+offsetY) {
                //ball hits the floor
                if (dx == 0)
                {
                    //90 deg
                    dx = rnd.Next(-1, 2);
                    dy = -dy;
                }
                else if (dx > 0 && dy > 0)
                {
                    // \
                    dy = -dy;
                }
                else if (dx < 0 && dy > 0)  {
                    // /

                    dy = -dy;
                }
            }
            else if (new_X < (radius / 2)+offsetX) {
                //hitting the left wall
                if (dy < 0 && dx < 0)
                {
                    // \
                    //dy = -dy;
                    dx = -dx;
                }
                else if (dy > 0 && dx < 0)
                {
                    // /
                    dx = -dx;
                }
                else if (dy == 0 && dx < 0) {
                    dy = rnd.Next(-1, 2);
                }
            }
            else if (new_X > (Width-radius)+offsetX) {
                //hitting the right wall
                if (dx > 0 && dy < 0)
                {
                    //coming from down /
                    dx = -dx;
                }
                else if (dx > 0 && dy > 0)
                {
                    // \
                    dx = -dx;
                    //dy = -dy;
                }
                else if (dy == 0 && dx > 0)  {
                    // 90 angle
                    dy = rnd.Next(-1,2);
                    dx = -dx;
                }
            }
        }
    }
}
