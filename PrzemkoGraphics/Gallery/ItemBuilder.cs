using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrzemkoGraphics.Utils;

namespace PrzemkoGraphics.Gallery
{
    public static class ItemBuilder
    {
        public static Item Create(string fileName)
        {
            Image loadedImage = Image.FromFile(fileName);
            var picture = new Picture(loadedImage, fileName);
            return new Item(picture);
        }
    }
}
