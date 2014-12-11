using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace PrzemkoGraphics.Options.Modifiers
{
    public class Resize : IOption
    {
        private const int ValidMinSize = 1;
        private const int ValidMaxSize = 3000;
        public int Width { get; set; }
        public int Height { get; set; }

        public string Name
        {
            get { return "Resize(Crop)"; }
        }

        public System.Drawing.Image Apply(System.Drawing.Image image)
        {
            int orgWidth = image.Width;
            int orgHeight = image.Height;
            

            if (ValidSize)
            {
                int width = Width;
                int height = Height;
                int resultWidth = orgWidth - width;
                int resultHeight = orgHeight - height;

                var filter = new Crop(new Rectangle(resultWidth / 2, resultHeight / 2, width, height));
                return filter.Apply((Bitmap) image);
            }

            return image;
        }

        private bool ValidSize
        {
            get
            {
                var width = Width;
                var height = Height;

                if (Enumerable.Range(ValidMinSize, ValidMaxSize).Contains(width)
                    && Enumerable.Range(ValidMinSize, ValidMaxSize).Contains(height))
                {
                    return true;
                }

                return false;
            }
        }

    }
}
