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
        //    _optionsList.AllowDrop = true;
          //  _optionsList.DragDrop += new DragEventHandler(_optionsList_DragDrop);
          //  _optionsList.DragEnter += new DragEventHandler(_optionsList_DragEnter);
           // _optionsList.MouseDown += new MouseEventHandler(_optionsList_MouseDown);
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

        private void _optionsList_MouseDown(object sender, MouseEventArgs e)
        {
            var item = _optionsList.GetItemAt(e.X, e.Y);
            if (item == null)
                return;
            _optionsList.DoDragDrop(item, DragDropEffects.Move);
        }

        private void _optionsList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void _optionsList_DragDrop(object sender, DragEventArgs e)
        {
            //var item2 = _optionsList.GetItemAt(e.X, e.Y);
            //if (item2 == null)
            //    return;
            //int index = item2.Index - 1;

            var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            _optionsList.Items.Remove(item);
        //    _optionsList.Items.Insert(index, item.Text);
        }
    }
}
