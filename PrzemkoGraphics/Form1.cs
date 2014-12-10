using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using PrzemkoGraphics.ComparisonPanel;
using PrzemkoGraphics.Gallery;
using PrzemkoGraphics.Options;
using PrzemkoGraphics.Options.Views;
using PrzemkoGraphics.Utils;

namespace PrzemkoGraphics
{
    public partial class Form1 : Form
    {
        private readonly CurrentView _currentView;
        private readonly ModifiedView _modifiedView;
        private readonly OptionsListView _optionsListView;

        private readonly GrayscaleView _grayscaleView;
        private readonly SepiaView _sepiaView;
        private readonly InvertcolorsView _invertcolorsView;
        private readonly ResizeView _resizeView;
        private readonly ResizeRatioView _resizeRatioView;
      
        public Form1()
        {
            InitializeComponent();

            _currentView = new CurrentView(pictureBox_current);
            _modifiedView = new ModifiedView(pictureBox_modified);
            _optionsListView = new OptionsListView(panel_optionslist, optionsList, button_up, button_down);
            
            _grayscaleView = new GrayscaleView(checkBox_grayscale, panel_grayscale);
            _sepiaView = new SepiaView(checkBox_sepia, panel_sepia);
            _invertcolorsView = new InvertcolorsView(checkBox_invertcolors, panel_invertcolors);
            _resizeView = new ResizeView(checkBox_resize, panel_resize, textBox_resizeWidth, textBox_resizeHeight, label_resizeError);
            _resizeRatioView = new ResizeRatioView(checkBox_resizeratio, panel_resizeratio, trackBar_resizeratio, label_resizeratio);

            ItemService.CurrentItemChanged += ItemService_CurrentItemChanged;
            ItemService.ItemRemoved += ItemService_ItemRemoved;
            OptionService.OptionChanged += ModifierService_ModifierChanged;
        }

        public void ItemService_CurrentItemChanged()
        {
            var current = ItemService.GetCurrent();
            _currentView.Image = current.Image;
            _modifiedView.Image = current.Image;

            if (previewToolStripMenuItem.Checked)
            {
                Refresh_modifiedView();
            }
        }

        public void ItemService_ItemRemoved()
        {
            if (ItemService.Items.Any())
            {
                SetFirstItemToViews();
            }
            else
            {
                _currentView.Image = null;
                _modifiedView.Image = null;
            }
        }

        public void ModifierService_ModifierChanged()
        {
            optionsList.Items.Clear();

            foreach (var option in OptionService.Options)
            {
                optionsList.Items.Add(option.Name);
            }

            if (previewToolStripMenuItem.Checked)
            {
                Refresh_modifiedView();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in openFileDialog1.FileNames)
                {
                    var item = ItemBuilder.Create(fileName);
                    ItemService.Add(item);             
                    item.Add(flowLayoutPanel1);
                }
                SetFirstItemToViews();

                if (previewToolStripMenuItem.Checked)
                {
                    Refresh_modifiedView();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = folderBrowserDialog1.SelectedPath;
                directory = directory ?? PgConstants.ChangedFilesPath;

                foreach (var item in ItemService.Items)
                {
                    var imageMod = OptionService.ApplyOptions(item.Image);
                    var fullPath = Path.Combine(directory, item.Picture.Name);

                    FilenameGenerator.Generate(ref fullPath);
                    imageMod.Save(fullPath, ImageFormat.Jpeg);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refresh_modifiedView()
        {
            var image = _currentView.Image;
            if (image != null)
            {
                image = OptionService.ApplyOptions(image);
                _modifiedView.Image = image;
            }
        }

        private void SetFirstItemToViews()
        {
            var firstItem = ItemService.Items[0];
            _currentView.Image = firstItem.Image;
            _modifiedView.Image = firstItem.Image;
            ItemService.SetCurrent(firstItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = OptionService.Options.Count().ToString();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewToolStripMenuItem.Checked)
            {
                Refresh_modifiedView();
            }
            else
            {
                _modifiedView.Image = _currentView.Image;
            }
        }

    }
}
