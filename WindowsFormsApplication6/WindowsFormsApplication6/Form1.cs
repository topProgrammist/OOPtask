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
        public Bitmap bmp;
        bool down = false;
        MouseEventHandler[] mouse = new MouseEventHandler[3];
        PaintEventHandler paint;
        LineDrawer line;
        RectangleDrawer rectangle;
        SquareDrawer square;
        TriangleDrawer triangle;
        EllipseDrawer ellipse;
        CircleDrawer circle;
        public int keks;
        Drawer figure;
        public Form1()
        {
            InitializeComponent();
            Graphics g = PaintPanel.CreateGraphics();
            DoubleBuffered = true;
            bmp = new Bitmap(PaintPanel.Width, PaintPanel.Height);
            line = new LineDrawer(bmp);
            rectangle = new RectangleDrawer(bmp);
            square = new SquareDrawer(bmp);
            triangle = new TriangleDrawer(bmp);
            ellipse = new EllipseDrawer(bmp);
            circle = new CircleDrawer(bmp);
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
            PaintPanel.MouseDown += mouse[0];
            PaintPanel.MouseMove += mouse[1];
            PaintPanel.MouseUp += mouse[2];
            PaintPanel.Paint += paint;
        }

        private void changeHandlers(MouseEventHandler mouseDown, MouseEventHandler mouseMove, MouseEventHandler mouseUp, PaintEventHandler paint)
        {
            mouse[0] = mouseDown;
            mouse[1] = mouseMove;
            mouse[2] = mouseUp;
            this.paint = paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (figure != null)
                bmp = figure.Bmp;
            figure = line;
            line.setBmp(bmp);
            deleteHandlers();
            changeHandlers(line.OnMouseDown, line.OnMouseMove, line.OnMouseUp, line.OnPaint);
            addHandlers();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (figure != null)
                bmp = figure.Bmp;
            figure = triangle;
            triangle.setBmp(bmp);
            deleteHandlers();
            changeHandlers(triangle.OnMouseDown, triangle.OnMouseMove, triangle.OnMouseUp, triangle.OnPaint);
            addHandlers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (figure != null)
                bmp = figure.Bmp;
            figure = rectangle;
            rectangle.setBmp(bmp);
            deleteHandlers();
            changeHandlers(rectangle.OnMouseDown, rectangle.OnMouseMove, rectangle.OnMouseUp, rectangle.OnPaint);
            addHandlers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (figure != null)
                bmp = figure.Bmp;
            figure = square;
            square.setBmp(bmp);
            deleteHandlers();
            changeHandlers(square.OnMouseDown, square.OnMouseMove, square.OnMouseUp, square.OnPaint);
            addHandlers();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (figure != null)
                bmp = figure.Bmp;
            figure = ellipse;
            ellipse.setBmp(bmp);
            deleteHandlers();
            changeHandlers(ellipse.OnMouseDown, ellipse.OnMouseMove, ellipse.OnMouseUp, ellipse.OnPaint);
            addHandlers();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (figure != null)
                bmp = figure.Bmp;
            figure = circle;
            circle.setBmp(bmp);
            deleteHandlers();
            changeHandlers(circle.OnMouseDown, circle.OnMouseMove, circle.OnMouseUp, circle.OnPaint);
            addHandlers();
        }
    }
}
