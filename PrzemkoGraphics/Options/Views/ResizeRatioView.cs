using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using PrzemkoGraphics.Options.Modifiers;

namespace PrzemkoGraphics.Options.Views
{
    public class ResizeRatioView : AbstractOptionView
    {
        protected TrackBar _trackBar;
        protected Label _label;
        protected ResizeRatio _resizeRatio;
        public ResizeRatioView(CheckBox checkBox, Panel panel, TrackBar trackBar, Label label)
            : base(new ResizeRatio(), checkBox, panel)
        {
            _trackBar = trackBar;
            _trackBar.ValueChanged += _trackBar_ValueChanged;
            _label = label;
            _resizeRatio = _option as ResizeRatio;
            _resizeRatio.Ratio = 100;
        }

        void _trackBar_ValueChanged(object sender, EventArgs e)
        {
            var value = _trackBar.Value;
            _label.Text = value.ToString();
            _resizeRatio.Ratio = value;
        }
    }
}
