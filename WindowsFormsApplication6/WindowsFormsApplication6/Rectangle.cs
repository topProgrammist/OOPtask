using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class Rectangle : Figure
    {
        private Point bot;
        private int width, height;
        public Rectangle(Point bot, int width, int height) 
        {
            this.bot = bot;
            this.width = width;
            this.height = height;
        }
        public override void Draw(Graphics e)
        {
            e.DrawRectangle(getPen(), bot.X, bot.Y, width, height);
        }
    }
}
