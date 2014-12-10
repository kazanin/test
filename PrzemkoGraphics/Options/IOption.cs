using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemkoGraphics.Options
{
    public interface IOption
    {
        string Name { get; }
        Image Apply(Image image);
    }
}
