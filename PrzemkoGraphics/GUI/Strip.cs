using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemkoGraphics.GUI
{
    public class Strip
    {
        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _stripStatusLabel;
        private ToolStripProgressBar _stripProgressBar;

        public Strip(StatusStrip statusStrip, ToolStripStatusLabel stripStatusLabel, ToolStripProgressBar stripProgressBar)
        {
            _statusStrip = statusStrip;
            _stripStatusLabel = stripStatusLabel;
            _stripProgressBar = stripProgressBar;
        }

        public string Text
        {
            get { return _stripStatusLabel.Text; }
            set { _stripStatusLabel.Text = value; }
        }
    }
}
