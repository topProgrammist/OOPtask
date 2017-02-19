using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    public class Triangle : Line
    {
        private Point c;
        public Triangle(Point a, Point b, Point c) : base(a, b) 
        {
            this.c = c;
            addPoint(c);
            addPoint(a);
        }

        public override void Draw(Graphics e)
        {
            base.Draw(e);
        }
    }
}
