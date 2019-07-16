using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainReaction
{
    public class BallsDoc
    {
        public List<Ball> balls { get; set; }

        public BallsDoc() {
            balls = new List<Ball>();
        }
        /// <summary>
        ///Add the ball to the list if it does not collide with other balls. 
        /// </summary>
        /// <param name="ball"></param>
        /// <returns></returns>
        public bool TryAdd(Ball ball) {
            //adding ball to list
            foreach (Ball b in balls) {
                if (b.Colide(ball)) {
                    return false;
                }
            }
            balls.Add(ball);
            return true;
        }
        public void Draw(Graphics g) {
            foreach (Ball b in balls) {
                b.Draw(g);
            }
        }
        public void Move(int Width, int Height,int offsetX, int offsetY) {
            foreach (Ball b in balls) {
                b.Move(Width,Height,offsetX,offsetY);
            }
        }
       
    }
}
