using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrzemkoGraphics.Gallery;

namespace PrzemkoGraphics.ComparisonPanel
{
    public abstract class AbstractView
    {
        protected PictureBox _pictureBox;

        protected AbstractView(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public virtual Image Image
        {
            get { return _pictureBox.Image; }
            set { _pictureBox.Image = value; }
        }

    }
}
