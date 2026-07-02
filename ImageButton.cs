using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Logon_Options
{
    class ImageButton : Button
    {
        public Image NormalImage { get; set; }
        public Image HoverImage { get; set; }
        public Image PressedImage { get; set; }

        private bool down = false;
        private bool mouse = false;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouse = true;
            this.Image = HoverImage;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouse = false;
            if (!down) this.Image = NormalImage;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            down = true;
            this.Image = PressedImage;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            down = false;
            if (mouse) this.Image = HoverImage;
            else this.Image = NormalImage;
            this.Invalidate();
        }

        public ImageButton()
        {
            Image = NormalImage;
            this.Invalidate();
        }
    }
}
