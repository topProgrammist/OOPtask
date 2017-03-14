using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class SquareDrawer : RectangleDrawer
    {
        Bitmap bmp;
        //Rectangle rectangle;
        Square sqr;
     //   Rectangle rectangle;
        public SquareDrawer(Bitmap bmp): base(bmp)
        {
            this.bmp = bmp;
            //     sqr = new Square(new Point(0,0),0,0);
        //    rectangle = new Rectangle(new Point(0, 0), 0, 0);
        }

        public override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (Down)
            {
                Point p = rectangle.Bot;
                rectangle.Width = e.X - p.X;

                // rectangle.Height = rectangle.Width;
                rectangle.Height = rectangle.Width;
             //   base.On
            }
        }
    }
}
