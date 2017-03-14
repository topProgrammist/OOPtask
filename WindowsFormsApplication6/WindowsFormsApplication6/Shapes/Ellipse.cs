using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public class Ellipse : Figure
    {
        private int width, height;
        private Point point;

        public Ellipse(Point point, int width, int height) : base()
        {
            this.point = point;
            this.width = width;
            this.height = height;
        }
        public override void Draw(Graphics e)
        {
            RectangleF rect = new RectangleF(point.X, point.Y, width, height);
            e.DrawEllipse(getPen(), rect);
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }
    }
}
