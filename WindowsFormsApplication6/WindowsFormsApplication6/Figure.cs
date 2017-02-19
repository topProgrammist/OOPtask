using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication6
{
    public abstract class Figure
    {
        private Color blackColor;
        private Pen blackPen;

        public Figure()
        {
            blackColor = Color.Black;
            Pen blackPen = new Pen(Color.Black, 3);
            this.blackPen = blackPen;
        }

        public Pen getPen()
        { 
            return blackPen;
        }
        public abstract void Draw(Graphics e);
    }
}
