using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using PrzemkoGraphics.Gallery;
using Image = System.Drawing.Image;

namespace PrzemkoGraphics.ComparisonPanel
{
    public class ModifiedView : AbstractView
    {
        public ModifiedView(PictureBox picturebox)
            : base(picturebox)
        {
        }

    }
}
