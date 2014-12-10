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
            this.optionsList = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_invertcolors = new System.Windows.Forms.Panel();
            this.checkBox_invertcolors = new System.Windows.Forms.CheckBox();
            this.panel_sepia = new System.Windows.Forms.Panel();
            this.checkBox_sepia = new System.Windows.Forms.CheckBox();
            this.panel_grayscale = new System.Windows.Forms.Panel();
            this.checkBox_grayscale = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_modified = new System.Windows.Forms.PictureBox();
            this.pictureBox_current = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl_rightBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_optionslist.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_invertcolors.SuspendLayout();
            this.panel_sepia.SuspendLayout();
            this.panel_grayscale.SuspendLayout();
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
            this.previewToolStripMenuItem});
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
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.previewToolStripMenuItem.Text = "Preview";
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
            this.panel_optionslist.Controls.Add(this.optionsList);
            this.panel_optionslist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_optionslist.Location = new System.Drawing.Point(3, 513);
            this.panel_optionslist.Name = "panel_optionslist";
            this.panel_optionslist.Size = new System.Drawing.Size(238, 164);
            this.panel_optionslist.TabIndex = 5;
            // 
            // optionsList
            // 
            this.optionsList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optionsList.Dock = System.Windows.Forms.DockStyle.Left;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_modified
            // 
            this.pictureBox_modified.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_modified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_modified.Location = new System.Drawing.Point(508, 3);
            this.pictureBox_modified.Name = "pictureBox_modified";
            this.pictureBox_modified.Size = new System.Drawing.Size(501, 700);
            this.pictureBox_modified.TabIndex = 2;
            this.pictureBox_modified.TabStop = false;
            // 
            // pictureBox_current
            // 
            this.pictureBox_current.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(834, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(172, 206);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl_rightBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
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
    }
}

