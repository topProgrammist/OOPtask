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
        private Pen blackPen = new Pen(Color.Black, 3);

        public Pen getPen()
        { 
            return blackPen;
        }
        public abstract void Draw(Graphics e);
    }
}
