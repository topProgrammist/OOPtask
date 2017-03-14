using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class EllipseDrawer : Drawer
    {
        Bitmap bmp, tempDraw;
        Pen pen = new Pen(Color.Black, 3);
        List<Point> points = new List<Point>();
        public Ellipse ellipse;
        Point mainPoint;
        public EllipseDrawer(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }
        public EllipseDrawer(Bitmap bmp, Ellipse ellipse)
        {
            this.bmp = bmp;
            this.ellipse = ellipse;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {
            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            temp.DrawEllipse(ellipse.getPen(), mainPoint.X, mainPoint.Y, ellipse.Width, ellipse.Height);
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseDown(object sender, MouseEventArgs e)
        {
            mainPoint = new Point(e.X, e.Y);
            ellipse = new Ellipse(mainPoint, 0, 0);
            Down = true;
        }

        public override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (Down)
            {
                ellipse.Width = e.X - mainPoint.X;
                ellipse.Height = e.Y - mainPoint.Y;
            }
        }

        public override void OnMouseUp(object sender, MouseEventArgs e)
        {
            Down = false;
            bmp = (Bitmap)tempDraw.Clone();
            Bmp = bmp;
        }
    }
}
