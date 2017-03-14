using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class RectangleDrawer : Drawer
    {
        Bitmap bmp, tempDraw;
        Pen pen = new Pen(Color.Black, 3);
        List<Point> points = new List<Point>();
        public Rectangle rectangle;
        Point mainPoint;
        public RectangleDrawer(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public RectangleDrawer(Bitmap bmp, Rectangle rectangle)
        {
            this.bmp = bmp;
            this.rectangle = rectangle;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {
            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            temp.DrawRectangle(rectangle.getPen(), mainPoint.X, mainPoint.Y, rectangle.Width, rectangle.Height);
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseDown(object sender, MouseEventArgs e)
        {
            mainPoint = new Point(e.X, e.Y);
            rectangle = new Rectangle(mainPoint, 0, 0);
            Down = true;
        }

        public override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (Down)
            {
                  rectangle.Width = e.X - mainPoint.X;
                  rectangle.Height = e.Y - mainPoint.Y;
            }
        }

        public override void OnMouseUp(object sender, MouseEventArgs e)
        {
            Down = false;
            bmp = (Bitmap)tempDraw.Clone();
        }
    }
}
