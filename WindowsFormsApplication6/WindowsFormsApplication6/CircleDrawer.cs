using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class CircleDrawer : EllipseDrawer
    {
        Bitmap bmp;
        public CircleDrawer(Bitmap bmp): base(bmp)
        {
            this.bmp = bmp;
            //     sqr = new Square(new Point(0,0),0,0);
            //    rectangle = new Rectangle(new Point(0, 0), 0, 0);
        }
        public override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (Down)
            {
                Point p = ellipse.Point;
                ellipse.Width = e.X - p.X;
                ellipse.Height = ellipse.Width;
            }
        }
    }

}
