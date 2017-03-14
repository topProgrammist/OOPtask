using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    abstract class Drawer : Panel
    {
        private MouseEventHandler mouseMove, mouseDown, mouseUp;
        private PaintEventHandler paint;
        private bool down;
        
        public abstract void OnPaint(Object sender, PaintEventArgs e);
        public abstract void OnMouseMove(Object sender, MouseEventArgs e);
        public abstract void OnMouseUp(Object sender, MouseEventArgs e);
        public abstract void OnMouseDown(Object sender, MouseEventArgs e);

        public bool Down
        {
            get { return down; }
            set { down = value; }
        }

        public MouseEventHandler MouseMoveEventHandler
        {
            get { return mouseMove; }
            set { mouseMove = value; }
        }
        public MouseEventHandler getMouseDownEventHandler
        {
            get { return mouseDown; }
            set { mouseDown = value; }
        }
        public MouseEventHandler getMouseUpEventHandler
        {
            get { return mouseUp; }
            set { mouseUp = value; }
        }
        public PaintEventHandler getPaintEventHandler
        {
            get { return paint; }
            set { paint = value; }
        }
    }
}
