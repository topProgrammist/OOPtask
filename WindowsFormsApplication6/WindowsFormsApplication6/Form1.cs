using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        FigureList figureList;
        Bitmap bmp;
        bool down = false;
        Graphics g;
        MouseEventHandler[] mouse = new MouseEventHandler[3];
        PaintEventHandler paint;
        public Form1()
        {
            InitializeComponent();
            Graphics g = PaintPanel.CreateGraphics();
            DoubleBuffered = true;
      //      this.ResizeRedraw = true;
            bmp = new Bitmap(PaintPanel.Width, PaintPanel.Height);
        }

        private void deleteHandlers()
        {
            if (mouse[0] != null)
            {
                PaintPanel.MouseDown -= mouse[0];
                PaintPanel.MouseMove -= mouse[1];
                PaintPanel.MouseUp -= mouse[2];
                PaintPanel.Paint -= paint;
            }
        }

        private void addHandlers()
        {
            PaintPanel.MouseDown += new MouseEventHandler(mouse[0]);
            PaintPanel.MouseMove += new MouseEventHandler(mouse[1]);
            PaintPanel.MouseUp += new MouseEventHandler(mouse[2]);
            PaintPanel.Paint += new PaintEventHandler(paint);
        }

        private void changeHandlers(MouseEventHandler mouseDown, MouseEventHandler mouseMove, MouseEventHandler mouseUp, PaintEventHandler paint)
        {
            mouse[0] = mouseDown;
            mouse[1] = mouseMove;
            mouse[2] = mouseUp;
            this.paint = paint;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LineDrawer l1 = new LineDrawer(bmp);
            PaintPanel.MouseDown += new MouseEventHandler(l1.OnMouseDown);
            PaintPanel.MouseMove += new MouseEventHandler(l1.OnMouseMove);
            PaintPanel.MouseUp += new MouseEventHandler(l1.OnMouseUp);
            PaintPanel.Paint += new PaintEventHandler(l1.OnPaint);
            l1.MouseMoveEventHandler = l1.OnMouseMove;
         //   PaintPanel.Paint -= l1.OnPaint;
            MouseEventHandler mouse = l1.OnMouseDown;
        //    PaintPanel.MouseDoubleClick -= mouse;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
       //     bmp = new Bitmap(PaintPanel.Height, this.ClientRectangle.Height);
        }

        private void PaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
            bmp = new Bitmap(PaintPanel.Width, PaintPanel.Height);
        }


        private void PaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
        }

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (down)
            {
                PaintPanel.Refresh();
                PaintPanel.Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TriangleDrawer tr = new TriangleDrawer(bmp);
            deleteHandlers();
            changeHandlers(tr.OnMouseDown,tr.OnMouseMove, tr.OnMouseUp, tr.OnPaint);
            addHandlers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RectangleDrawer rec = new RectangleDrawer(bmp);
            PaintPanel.MouseDown += new MouseEventHandler(rec.OnMouseDown);
            PaintPanel.MouseMove += new MouseEventHandler(rec.OnMouseMove);
            PaintPanel.MouseUp += new MouseEventHandler(rec.OnMouseUp);
            PaintPanel.Paint += new PaintEventHandler(rec.OnPaint);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SquareDrawer sqr = new SquareDrawer(bmp);
            PaintPanel.MouseDown += new MouseEventHandler(sqr.OnMouseDown);
            PaintPanel.MouseMove += new MouseEventHandler(sqr.OnMouseMove);
            PaintPanel.MouseUp += new MouseEventHandler(sqr.OnMouseUp);
            PaintPanel.Paint += new PaintEventHandler(sqr.OnPaint);
        }
    }
}
