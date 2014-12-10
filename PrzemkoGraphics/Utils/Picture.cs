using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrzemkoGraphics.Utils
{
    public class Picture
    {
        public readonly string Path;
        public readonly string Name;
        public readonly string Extension;
        private readonly Image _image;

        public Picture(Image image, string path)
        {
            this._image = image;
            this.Path = path;
            Name = System.IO.Path.GetFileName(path);
            Extension = System.IO.Path.GetExtension(path);
        }

        public int Width
        {
            get { return _image.Width; }
        }

        public int Height
        {
            get { return _image.Height; }
        }

        public Image Image
        {
            get { return _image; }
        }
    }
}
