namespace PrzemkoGraphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_rightBar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_optionslist = new System.Windows.Forms.Panel();
            this.button_down = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.optionsList = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_invertcolors = new System.Windows.Forms.Panel();
            this.checkBox_invertcolors = new System.Windows.Forms.CheckBox();
            this.panel_sepia = new System.Windows.Forms.Panel();
            this.checkBox_sepia = new System.Windows.Forms.CheckBox();
            this.panel_grayscale = new System.Windows.Forms.Panel();
            this.checkBox_grayscale = new System.Windows.Forms.CheckBox();
            this.panel_resize = new System.Windows.Forms.Panel();
            this.label_resizeError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_resizeHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_resizeWidth = new System.Windows.Forms.TextBox();
            this.checkBox_resize = new System.Windows.Forms.CheckBox();
            this.panel_resizeratio = new System.Windows.Forms.Panel();
            this.label_resizeratio = new System.Windows.Forms.Label();
            this.trackBar_resizeratio = new System.Windows.Forms.TrackBar();
            this.checkBox_resizeratio = new System.Windows.Forms.CheckBox();
            this.pictureBox_modified = new System.Windows.Forms.PictureBox();
            this.pictureBox_current = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.clearGalleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl_rightBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_optionslist.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_invertcolors.SuspendLayout();
            this.panel_sepia.SuspendLayout();
            this.panel_grayscale.SuspendLayout();
            this.panel_resize.SuspendLayout();
            this.panel_resizeratio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_resizeratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_modified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_current)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.clearGalleryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Checked = true;
            this.previewToolStripMenuItem.CheckOnClick = true;
            this.previewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // tabControl_rightBar
            // 
            this.tabControl_rightBar.Controls.Add(this.tabPage1);
            this.tabControl_rightBar.Controls.Add(this.tabPage2);
            this.tabControl_rightBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl_rightBar.Location = new System.Drawing.Point(1012, 24);
            this.tabControl_rightBar.Multiline = true;
            this.tabControl_rightBar.Name = "tabControl_rightBar";
            this.tabControl_rightBar.SelectedIndex = 0;
            this.tabControl_rightBar.Size = new System.Drawing.Size(252, 706);
            this.tabControl_rightBar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_rightBar.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(244, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gallery";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 674);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_optionslist);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(244, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_optionslist
            // 
            this.panel_optionslist.Controls.Add(this.button_down);
            this.panel_optionslist.Controls.Add(this.button_up);
            this.panel_optionslist.Controls.Add(this.optionsList);
            this.panel_optionslist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_optionslist.Location = new System.Drawing.Point(3, 513);
            this.panel_optionslist.Name = "panel_optionslist";
            this.panel_optionslist.Size = new System.Drawing.Size(238, 164);
            this.panel_optionslist.TabIndex = 5;
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(196, 81);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(39, 78);
            this.button_down.TabIndex = 3;
            this.button_down.Text = "DOWN";
            this.button_down.UseVisualStyleBackColor = true;
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(196, 3);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(39, 72);
            this.button_up.TabIndex = 2;
            this.button_up.Text = "UP";
            this.button_up.UseVisualStyleBackColor = true;
            // 
            // optionsList
            // 
            this.optionsList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optionsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsList.HideSelection = false;
            this.optionsList.Location = new System.Drawing.Point(0, 0);
            this.optionsList.MultiSelect = false;
            this.optionsList.Name = "optionsList";
            this.optionsList.Size = new System.Drawing.Size(188, 164);
            this.optionsList.TabIndex = 1;
            this.optionsList.UseCompatibleStateImageBehavior = false;
            this.optionsList.View = System.Windows.Forms.View.List;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel_invertcolors);
            this.flowLayoutPanel2.Controls.Add(this.panel_sepia);
            this.flowLayoutPanel2.Controls.Add(this.panel_grayscale);
            this.flowLayoutPanel2.Controls.Add(this.panel_resize);
            this.flowLayoutPanel2.Controls.Add(this.panel_resizeratio);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(238, 498);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // panel_invertcolors
            // 
            this.panel_invertcolors.Controls.Add(this.checkBox_invertcolors);
            this.panel_invertcolors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_invertcolors.Location = new System.Drawing.Point(3, 3);
            this.panel_invertcolors.Name = "panel_invertcolors";
            this.panel_invertcolors.Size = new System.Drawing.Size(238, 29);
            this.panel_invertcolors.TabIndex = 3;
            // 
            // checkBox_invertcolors
            // 
            this.checkBox_invertcolors.AutoSize = true;
            this.checkBox_invertcolors.Location = new System.Drawing.Point(12, 3);
            this.checkBox_invertcolors.Name = "checkBox_invertcolors";
            this.checkBox_invertcolors.Size = new System.Drawing.Size(85, 17);
            this.checkBox_invertcolors.TabIndex = 0;
            this.checkBox_invertcolors.Text = "Invert Colors";
            this.checkBox_invertcolors.UseVisualStyleBackColor = true;
            // 
            // panel_sepia
            // 
            this.panel_sepia.Controls.Add(this.checkBox_sepia);
            this.panel_sepia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sepia.Location = new System.Drawing.Point(3, 38);
            this.panel_sepia.Name = "panel_sepia";
            this.panel_sepia.Size = new System.Drawing.Size(238, 29);
            this.panel_sepia.TabIndex = 2;
            // 
            // checkBox_sepia
            // 
            this.checkBox_sepia.AutoSize = true;
            this.checkBox_sepia.Location = new System.Drawing.Point(12, 3);
            this.checkBox_sepia.Name = "checkBox_sepia";
            this.checkBox_sepia.Size = new System.Drawing.Size(53, 17);
            this.checkBox_sepia.TabIndex = 0;
            this.checkBox_sepia.Text = "Sepia";
            this.checkBox_sepia.UseVisualStyleBackColor = true;
            // 
            // panel_grayscale
            // 
            this.panel_grayscale.Controls.Add(this.checkBox_grayscale);
            this.panel_grayscale.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_grayscale.Location = new System.Drawing.Point(3, 73);
            this.panel_grayscale.Name = "panel_grayscale";
            this.panel_grayscale.Size = new System.Drawing.Size(238, 29);
            this.panel_grayscale.TabIndex = 0;
            // 
            // checkBox_grayscale
            // 
            this.checkBox_grayscale.AutoSize = true;
            this.checkBox_grayscale.Location = new System.Drawing.Point(12, 3);
            this.checkBox_grayscale.Name = "checkBox_grayscale";
            this.checkBox_grayscale.Size = new System.Drawing.Size(73, 17);
            this.checkBox_grayscale.TabIndex = 0;
            this.checkBox_grayscale.Text = "Grayscale";
            this.checkBox_grayscale.UseVisualStyleBackColor = true;
            // 
            // panel_resize
            // 
            this.panel_resize.Controls.Add(this.label_resizeError);
            this.panel_resize.Controls.Add(this.label3);
            this.panel_resize.Controls.Add(this.label4);
            this.panel_resize.Controls.Add(this.textBox_resizeHeight);
            this.panel_resize.Controls.Add(this.label2);
            this.panel_resize.Controls.Add(this.label1);
            this.panel_resize.Controls.Add(this.textBox_resizeWidth);
            this.panel_resize.Controls.Add(this.checkBox_resize);
            this.panel_resize.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_resize.Location = new System.Drawing.Point(3, 108);
            this.panel_resize.Name = "panel_resize";
            this.panel_resize.Size = new System.Drawing.Size(238, 74);
            this.panel_resize.TabIndex = 4;
            // 
            // label_resizeError
            // 
            this.label_resizeError.AutoSize = true;
            this.label_resizeError.ForeColor = System.Drawing.Color.Red;
            this.label_resizeError.Location = new System.Drawing.Point(68, 4);
            this.label_resizeError.Name = "label_resizeError";
            this.label_resizeError.Size = new System.Drawing.Size(90, 13);
            this.label_resizeError.TabIndex = 7;
            this.label_resizeError.Text = "Invalid image size";
            this.label_resizeError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height";
            // 
            // textBox_resizeHeight
            // 
            this.textBox_resizeHeight.Location = new System.Drawing.Point(71, 41);
            this.textBox_resizeHeight.Name = "textBox_resizeHeight";
            this.textBox_resizeHeight.Size = new System.Drawing.Size(69, 20);
            this.textBox_resizeHeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "px";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // textBox_resizeWidth
            // 
            this.textBox_resizeWidth.Location = new System.Drawing.Point(71, 22);
            this.textBox_resizeWidth.Name = "textBox_resizeWidth";
            this.textBox_resizeWidth.Size = new System.Drawing.Size(69, 20);
            this.textBox_resizeWidth.TabIndex = 1;
            // 
            // checkBox_resize
            // 
            this.checkBox_resize.AutoSize = true;
            this.checkBox_resize.Location = new System.Drawing.Point(12, 3);
            this.checkBox_resize.Name = "checkBox_resize";
            this.checkBox_resize.Size = new System.Drawing.Size(58, 17);
            this.checkBox_resize.TabIndex = 0;
            this.checkBox_resize.Text = "Resize";
            this.checkBox_resize.UseVisualStyleBackColor = true;
            // 
            // panel_resizeratio
            // 
            this.panel_resizeratio.Controls.Add(this.label_resizeratio);
            this.panel_resizeratio.Controls.Add(this.trackBar_resizeratio);
            this.panel_resizeratio.Controls.Add(this.checkBox_resizeratio);
            this.panel_resizeratio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_resizeratio.Location = new System.Drawing.Point(3, 188);
            this.panel_resizeratio.Name = "panel_resizeratio";
            this.panel_resizeratio.Size = new System.Drawing.Size(238, 70);
            this.panel_resizeratio.TabIndex = 5;
            // 
            // label_resizeratio
            // 
            this.label_resizeratio.AutoSize = true;
            this.label_resizeratio.Location = new System.Drawing.Point(182, 36);
            this.label_resizeratio.Name = "label_resizeratio";
            this.label_resizeratio.Size = new System.Drawing.Size(25, 13);
            this.label_resizeratio.TabIndex = 2;
            this.label_resizeratio.Text = "100";
            // 
            // trackBar_resizeratio
            // 
            this.trackBar_resizeratio.Location = new System.Drawing.Point(60, 22);
            this.trackBar_resizeratio.Maximum = 100;
            this.trackBar_resizeratio.Minimum = 1;
            this.trackBar_resizeratio.Name = "trackBar_resizeratio";
            this.trackBar_resizeratio.Size = new System.Drawing.Size(104, 45);
            this.trackBar_resizeratio.TabIndex = 1;
            this.trackBar_resizeratio.Value = 100;
            // 
            // checkBox_resizeratio
            // 
            this.checkBox_resizeratio.AutoSize = true;
            this.checkBox_resizeratio.Location = new System.Drawing.Point(12, 3);
            this.checkBox_resizeratio.Name = "checkBox_resizeratio";
            this.checkBox_resizeratio.Size = new System.Drawing.Size(103, 17);
            this.checkBox_resizeratio.TabIndex = 0;
            this.checkBox_resizeratio.Text = "Resize with ratio";
            this.checkBox_resizeratio.UseVisualStyleBackColor = true;
            // 
            // pictureBox_modified
            // 
            this.pictureBox_modified.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox_modified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_modified.Location = new System.Drawing.Point(508, 3);
            this.pictureBox_modified.Name = "pictureBox_modified";
            this.pictureBox_modified.Size = new System.Drawing.Size(501, 700);
            this.pictureBox_modified.TabIndex = 2;
            this.pictureBox_modified.TabStop = false;
            // 
            // pictureBox_current
            // 
            this.pictureBox_current.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_current.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_current.Name = "pictureBox_current";
            this.pictureBox_current.Size = new System.Drawing.Size(499, 700);
            this.pictureBox_current.TabIndex = 3;
            this.pictureBox_current.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07174F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_current, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_modified, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 706);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 15);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // clearGalleryToolStripMenuItem
            // 
            this.clearGalleryToolStripMenuItem.Name = "clearGalleryToolStripMenuItem";
            this.clearGalleryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearGalleryToolStripMenuItem.Text = "Clear Gallery";
            this.clearGalleryToolStripMenuItem.Click += new System.EventHandler(this.clearGalleryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl_rightBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PrzemkoGraphics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_rightBar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_optionslist.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_invertcolors.ResumeLayout(false);
            this.panel_invertcolors.PerformLayout();
            this.panel_sepia.ResumeLayout(false);
            this.panel_sepia.PerformLayout();
            this.panel_grayscale.ResumeLayout(false);
            this.panel_grayscale.PerformLayout();
            this.panel_resize.ResumeLayout(false);
            this.panel_resize.PerformLayout();
            this.panel_resizeratio.ResumeLayout(false);
            this.panel_resizeratio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_resizeratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_modified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_current)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_rightBar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox_modified;
        private System.Windows.Forms.PictureBox pictureBox_current;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_grayscale;
        private System.Windows.Forms.CheckBox checkBox_grayscale;
        private System.Windows.Forms.ListView optionsList;
        private System.Windows.Forms.Panel panel_sepia;
        private System.Windows.Forms.CheckBox checkBox_sepia;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.Panel panel_invertcolors;
        private System.Windows.Forms.CheckBox checkBox_invertcolors;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel_optionslist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel_resize;
        private System.Windows.Forms.TextBox textBox_resizeWidth;
        private System.Windows.Forms.CheckBox checkBox_resize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_resizeHeight;
        private System.Windows.Forms.Label label_resizeError;
        private System.Windows.Forms.Panel panel_resizeratio;
        private System.Windows.Forms.Label label_resizeratio;
        private System.Windows.Forms.TrackBar trackBar_resizeratio;
        private System.Windows.Forms.CheckBox checkBox_resizeratio;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearGalleryToolStripMenuItem;
    }
}

