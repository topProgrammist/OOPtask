using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public class Circle : Ellipse
    {
        public Circle(Point center, int radius) : base(new Point(center.X - radius, center.Y - radius), 2*radius, 2*radius)
        {
        }
    }
}
