﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class LineDrawer : Drawer
    {
        private bool mouseDown = false;
        Bitmap bmp, tempDraw;
        Pen pen = new Pen(Color.Black, 3);
        List<Point> points = new List<Point>();
        Line line;
        public LineDrawer(Bitmap bmp) 
        {
            this.bmp = bmp;  
        }

        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }
        public override void OnPaint(object sender, PaintEventArgs e)
        {
            points = line.getCoord();
            Point[] coord = new Point[2];
            coord = points.ToArray();
            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            temp.DrawLine(pen, coord[0], coord[1]);
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseDown(object sender, MouseEventArgs e)
        {
            line = new Line(new Point(e.X, e.Y), new Point(e.X, e.Y));
            tempDraw = (Bitmap)bmp.Clone();
            mouseDown = true;
        }

        public override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                line.setPoint(new Point(e.X, e.Y));
            }
        }

        public override void OnMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            bmp = (Bitmap)tempDraw.Clone();
            Bmp = bmp;
        }
        public void DrawLine()
        {
            
        //    figureList.drawAllFigures();
        }
    }
}
