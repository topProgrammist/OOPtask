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
        private Point a, b;

        public Line(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }
        public override void Draw(Graphics e)
        {
            e.DrawLine(getPen(), a, b);
        }

        public void setPoint(Point b)
        {
            this.b = b;
        }

        public void setPointA(Point b)
        {
            this.a = b;
        }
    }
}
