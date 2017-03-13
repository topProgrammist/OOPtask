using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class LineDrawer :  Form1
    {
        private Point a, b;
        private bool mouseDown = false;
        Graphics g, temp;
        FigureList figureList;
        Line line;
        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            a = new Point(e.X, e.Y);
            b = a;
            mouseDown = true;
            line = new Line(a, b);
            figureList.figureAdd(line);
        }

        public LineDrawer(Graphics g)
        {
            this.g = g;
            this.temp = g;
            //
            figureList = new FigureList(g);
            
      
        }
        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                //  g = temp;
                line.setPointA(b);
                b = new Point(e.X, e.Y);
                line.setPoint(b);
             //   Refresh();
                DrawLine();
            //    g.Dispose();
            }
          //  base.OnMouseMove(e);
        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }
        public void DrawLine()
        {
            
            figureList.drawAllFigures();
        }
    }
}
