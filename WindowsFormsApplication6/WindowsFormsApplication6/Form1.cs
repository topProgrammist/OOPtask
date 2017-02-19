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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            FigureList figureList = new FigureList(e.Graphics);
            figureList.figureAdd(new Ellipse(new Point(20, 20), 200, 100));
            figureList.figureAdd(new Circle(new Point(120, 120), 100));
            figureList.figureAdd(new Line(new Point(120, 220), new Point(220, 340)));
            figureList.figureAdd(new Triangle(new Point(60, 60), new Point(120, 120), new Point(180, 60)));
            figureList.figureAdd(new Rectangle(new Point(120, 220), 200, 100));
            figureList.figureAdd(new Square(new Point(420, 120), 100));
            figureList.drawAllFigures();
        }
    }
}
