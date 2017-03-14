using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public class Line : Figure
    {
        List<Point> points = new List<Point>();
        public Line(Point a, Point b)
        {
            points.Add(a);
            points.Add(b);
        }
        public override void Draw(Graphics e)
        {
       //     e.DrawLine(getPen(), a, b);
        }

        public void setPoint(Point b)
        {
            points.RemoveAt(1);
            points.Add(b);
        }

        public List<Point> getCoord()
        {
            return points;
        }

    }
}
