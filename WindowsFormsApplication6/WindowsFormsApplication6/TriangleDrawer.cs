using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class TriangleDrawer : Drawer
    {
        private bool mouseDown = false;
        Bitmap bmp, tempDraw;
        Pen pen = new Pen(Color.Black, 3);
        List<Point> points = new List<Point>();
        Triangle trinagle;
        public TriangleDrawer(Bitmap bmp) 
        {
            this.bmp = bmp;
        }

        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }
        public override void OnPaint(object sender, PaintEventArgs e)
        {
            Point[] points = trinagle.getPoints();
            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            temp.DrawPolygon(trinagle.getPen(), points);
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseDown(object sender, MouseEventArgs e)
        {
            trinagle = new Triangle(new Point(e.X, e.Y), new Point(e.X, e.Y), new Point(e.X, e.Y));
            mouseDown = true;
        }

        public Bitmap getBmp()
        {
            return bmp;
        }
        public override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = trinagle.getMainPoint();
                trinagle.setPoint(2, new Point(e.X, e.Y));
                trinagle.setPoint(1, new Point(e.X - 2*(e.X - p.X), e.Y));
            }
        }

        public override void OnMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            bmp = (Bitmap)tempDraw.Clone();
            Bmp = bmp;
        }
    }
}
