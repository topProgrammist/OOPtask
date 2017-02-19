using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class FigureList
    {
        private List<Figure> figureList = new List<Figure>();
        // private Graphics g;

        private Graphics g;

        public FigureList(Graphics g)
        {
            this.g = g;
        }
        public void figureAdd(Figure figure)
        {
            figureList.Add(figure);
        }

        public void drawAllFigures()
        {
            foreach (Figure figure in figureList)
            {
                figure.Draw(g);
            }
        }
    }
}
