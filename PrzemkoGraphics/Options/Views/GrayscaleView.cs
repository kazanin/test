using System.Windows.Forms;
using PrzemkoGraphics.Options.Filters;

namespace PrzemkoGraphics.Options.Views
{
    public class GrayscaleView : AbstractOptionView
    {
        public GrayscaleView(CheckBox checkBox, Panel panel) 
            : base(new Grayscale(), checkBox, panel)
        {
            
        }


    }
}
