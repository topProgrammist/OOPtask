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
        public Form1()
        {
            InitializeComponent();
            Graphics g = PaintPanel.CreateGraphics();
            figureList = new FigureList(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = PaintPanel.CreateGraphics();
            LineDrawer l1 = new LineDrawer(g);
            //   PaintPanel.MouseDown += new MouseEventHandler(l1);
            PaintPanel.MouseDown += new MouseEventHandler(l1.OnMouseDown);
            PaintPanel.MouseMove += new MouseEventHandler(l1.OnMouseMove);
            PaintPanel.MouseUp += new MouseEventHandler(l1.OnMouseUp);
        }
    }
}
