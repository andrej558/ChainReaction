using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainReaction
{
    public class Circle
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public Timer timer { get; set; }
        public bool isDrawing { get; set; }
        public string Points { get; set; }
         
        public Circle(Point center, Color color, int radius,string points):this(color,radius) {
            Center = center;
            Points = points;
        }
        public Circle(Color color, int radius)
        {
            isDrawing = true;
            Color = color;
            Radius = radius;
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += timer1_tick;
            
        }
        public void timer1_tick(object sender, EventArgs e) {
            //timer to indicate lifespan of object
            isDrawing = false;
            timer.Stop();
        }
        public void Draw(Graphics g) { 
            Brush b = new SolidBrush(Color.FromArgb(128, Color));
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
            g.DrawString(Points, new Font("Arial", 13), new SolidBrush(Color.White), new Point(Center.X - 18, Center.Y - 8));
        }
        public void Move(Point Center) {
            this.Center = Center;
        }
    }
}
