using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    abstract class Drawer : Panel
    {
        private bool down;
        private Bitmap bmp;
        public abstract void OnPaint(Object sender, PaintEventArgs e);
        public abstract void OnMouseMove(Object sender, MouseEventArgs e);
        public abstract void OnMouseUp(Object sender, MouseEventArgs e);
        public abstract void OnMouseDown(Object sender, MouseEventArgs e);

        public bool Down
        {
            get { return down; }
            set { down = value; }
        }

        public Bitmap Bmp
        {
            get { return bmp; }
            set { bmp = value; }
        }
    }
}
