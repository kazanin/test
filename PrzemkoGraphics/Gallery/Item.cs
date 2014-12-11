using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrzemkoGraphics.Utils;

namespace PrzemkoGraphics.Gallery
{
    public class Item : IDisposable
    {
        public PictureBox _pictureBox = new PictureBox();
        private Size _size_pictureBox = new Size(170, 100);

        private Button _button_exit = new Button();
        private Size _size_button_exit = new Size(30, 30);


        public readonly Picture Picture;

        public Item(Picture picture)
        {
            Picture = picture;
            _pictureBox.Size = _size_pictureBox;
            _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _pictureBox.Image = Picture.Image;
            _pictureBox.BackColor = Color.Black;
            _pictureBox.Click += _pictureBox_Click;

            _button_exit.Size = _size_button_exit;
            _button_exit.Text = @"X";
            _button_exit.BackColor = Color.Beige;
            _button_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _button_exit.Click += _button_exit_Click;
            _pictureBox.Controls.Add(_button_exit);
        }

        public Image Image
        {
            get { return Picture.Image; }
        }

        public void Add(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Add(_pictureBox);
        }

        public void _pictureBox_Click(object sender, EventArgs e)
        {
            ItemService.Current = this;
        }

        public void _button_exit_Click(object sender, EventArgs e)
        {
            ItemService.Remove(this);
            Dispose();
        }

        public void Dispose()
        {
            _button_exit.Dispose();
            _pictureBox.Dispose();
        }
    }
}
