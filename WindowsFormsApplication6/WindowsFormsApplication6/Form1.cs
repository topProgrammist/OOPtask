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
            figureList.figureAdd(new Ellipse(new Point(20, 20), 220, 100));
            figureList.figureAdd(new Circle(new Point(300, 70), 50));
            figureList.figureAdd(new Line(new Point(360, 180), new Point(450, 280)));
            figureList.figureAdd(new Triangle(new Point(380, 70), new Point(450, 120), new Point(520, 70)));
            figureList.figureAdd(new Rectangle(new Point(20, 180), 200, 100));
            figureList.figureAdd(new Square(new Point(240, 180), 100));
            figureList.drawAllFigures();
        }
    }
}
