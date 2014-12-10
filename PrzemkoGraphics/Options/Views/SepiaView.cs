using System.Windows.Forms;
using PrzemkoGraphics.Options.Filters;

namespace PrzemkoGraphics.Options.Views
{
    public class SepiaView : AbstractOptionView
    {
        public SepiaView(CheckBox checkBox, Panel panel)
            : base(new Sepia(), checkBox, panel)
        {
            
        }


    }
}
