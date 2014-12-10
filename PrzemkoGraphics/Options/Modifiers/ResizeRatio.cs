using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace PrzemkoGraphics.Options.Modifiers
{
    public class ResizeRatio : IOption
    {
        public int Ratio { get; set; }
        public string Name
        {
            get { return "ResizeRatio"; }
        }

        public System.Drawing.Image Apply(System.Drawing.Image image)
        {
            int orgWidth = image.Width;
            int orgHeight = image.Height;
            int desireWidth = Convert.ToInt32(orgWidth * (Ratio * 0.01));
            int desireHeight = Convert.ToInt32(orgHeight * (Ratio * 0.01));

            var filter = new ResizeBicubic(desireWidth, desireHeight);
            return filter.Apply((Bitmap)image);
        }
    }
}
