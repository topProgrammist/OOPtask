using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class Polygon : Figure
    {
        private List<Point> points = new List<Point>();
        private Point[] pointsArr = new Point[] { new Point(0,0), new Point(0, 0) , new Point(0, 0) , new Point(0, 0) };
        public void setPoint(Point p, int place)
        {
            pointsArr.SetValue(p, place);
        }
        public override void Draw(Graphics e)
        {
            e.DrawPolygon(getPen(), pointsArr);
        }
    }
}
