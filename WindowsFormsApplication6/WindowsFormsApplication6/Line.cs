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
        private List<Point> Points = new List<Point>();

        public Line(Point a, Point b)
        {
            Points.Add(a);
            Points.Add(b);
        }

        public void addPoint(Point point)
        {
            Points.Add(point);
        }
    //    public setPoint(int x1, int y1, int x2, int y2)
        public override void Draw(Graphics e)
        {
            e.DrawLines(getPen(), Points.ToArray<Point>());
        }
    }
}
