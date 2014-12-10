using System.Windows.Forms;
using PrzemkoGraphics.Options.Filters;

namespace PrzemkoGraphics.Options.Views
{
    public class InvertcolorsView : AbstractOptionView
    {
        public InvertcolorsView(CheckBox checkBox, Panel panel)
            : base(new Invertcolors(), checkBox, panel)
        {
            
        }


    }
}
