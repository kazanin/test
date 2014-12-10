using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace PrzemkoGraphics.Options.Filters
{
    public class Invertcolors : IOption
    {
        public string Name
        {
            get { return "InvertColors"; }
        }

        public System.Drawing.Image Apply(System.Drawing.Image image)
        {
            try
            {
                var filter = new Invert();
                return filter.Apply((Bitmap)image);
            }
            catch (Exception)
            {
                return image;
            }
        }
    }
}
