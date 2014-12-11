using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemkoGraphics.Options
{
    public class OptionsListView
    {
        private Panel _panel;
        private ListView _optionsList;
        private Button _buttonUp;
        private Button _buttonDown;

        public OptionsListView(Panel panel, ListView optionsList, Button buttonUp, Button buttonDown)
        {
            _panel = panel;
            _optionsList = optionsList;
            _buttonDown = buttonDown;
            _buttonUp = buttonUp;
            _panel.Controls.Add(_optionsList);

            _buttonDown.Click += _buttonDown_Click;
            _buttonUp.Click += _buttonUp_Click;
        }

        void _buttonUp_Click(object sender, EventArgs e)
        {
            if (_optionsList.SelectedItems.Count == 0)
                return;

            var item = _optionsList.SelectedItems[0];
            var index = item.Index;

            if (index != 0)
            {
                var option = OptionService.GetAt(index);
                OptionService.Remove(option);
                OptionService.AddAt(option, index - 1);
                _optionsList.Items[index - 1].Selected = true;
            }
        }

        void _buttonDown_Click(object sender, EventArgs e)
        {
            if (_optionsList.SelectedItems.Count == 0)
                return;

            var item = _optionsList.SelectedItems[0];
            var index = item.Index;

            if (index != _optionsList.Items.Count - 1)
            {
                var option = OptionService.GetAt(index);
                OptionService.Remove(option);
                OptionService.AddAt(option, index + 1);
                _optionsList.Items[index + 1].Selected = true;
            }
        }
    }
}
