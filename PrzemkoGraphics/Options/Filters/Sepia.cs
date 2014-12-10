using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrzemkoGraphics.Options.Filters
{
    public class Sepia : IOption
    {
        public string Name
        {
            get { return "Sepia"; }
        }

        public Image Apply(Image image)
        {
            try
            {
                var filter = new AForge.Imaging.Filters.Sepia();
                return filter.Apply((Bitmap)image);
            }
            catch (Exception)
            {
                return image;
            }

        }
    }
}
