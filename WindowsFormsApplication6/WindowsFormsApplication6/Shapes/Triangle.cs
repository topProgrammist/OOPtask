using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    public class Triangle : Figure
    {
        private Point[] Points;
        public Triangle(Point a, Point b, Point c)
        {
            this.Points = new Point[] { a, b, c };
        }

        public override void Draw(Graphics e)
        {
            e.DrawPolygon(getPen(), Points);
        }
    }
}
