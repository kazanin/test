using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemkoGraphics.Options
{
    public abstract class AbstractOptionView
    {
        protected IOption _option;
        protected Panel _panel;
        protected CheckBox _checkBox;

        protected AbstractOptionView(IOption option, CheckBox checkBox, Panel panel)
        {
            _option = option;
            _checkBox = checkBox;
            _panel = panel;
            _panel.Controls.Add(_checkBox);
            _checkBox.CheckedChanged += _checkBox_CheckedChanged;
        }

        public void _checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkBox.Checked)
            {
                OptionService.Add(_option);
            }
            else
            {
                OptionService.Remove(_option);
            }
        }
    }
}
