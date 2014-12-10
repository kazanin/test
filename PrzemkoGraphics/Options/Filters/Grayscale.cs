using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Imaging.Filters;

namespace PrzemkoGraphics.Options.Filters
{
    public class Grayscale : IOption
    {
        public string Name
        {
            get { return "Grayscale"; }
        }

        public Image Apply(Image image)
        {
            try
            {
                var filter = new AForge.Imaging.Filters.Grayscale(0.2125, 0.7154, 0.0721);
                return filter.Apply((Bitmap) image);
            }
            catch (Exception)
            {
                return image;
            }
        }
    }
}
