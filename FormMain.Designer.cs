namespace CopyBackup
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            TsbAddSource = new ToolStripButton();
            TsbDeleteSource = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            TsbAddDestination = new ToolStripButton();
            TsbDeleteDestination = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            TsbAddGroup = new ToolStripButton();
            TsbDeleteGroup = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbRun = new ToolStripButton();
            PanelSource = new Panel();
            ScSource = new SplitContainer();
            GbSourceList = new GroupBox();
            ListBoxSource = new ListBox();
            groupBox1 = new GroupBox();
            ListView = new ListView();
            ImageList = new ImageList(components);
            toolStrip2 = new ToolStrip();
            TsbUp = new ToolStripButton();
            PanelDestination = new Panel();
            ScDestination = new SplitContainer();
            GbDestinationList = new GroupBox();
            ListBoxDestination = new ListBox();
            GbDestinationGroup = new GroupBox();
            ListBoxDestinationGroup = new ListBox();
            FolderBrowserDialog = new FolderBrowserDialog();
            toolStrip1.SuspendLayout();
            PanelSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScSource).BeginInit();
            ScSource.Panel1.SuspendLayout();
            ScSource.Panel2.SuspendLayout();
            ScSource.SuspendLayout();
            GbSourceList.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip2.SuspendLayout();
            PanelDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScDestination).BeginInit();
            ScDestination.Panel1.SuspendLayout();
            ScDestination.Panel2.SuspendLayout();
            ScDestination.SuspendLayout();
            GbDestinationList.SuspendLayout();
            GbDestinationGroup.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, TsbAddSource, TsbDeleteSource, toolStripSeparator1, toolStripLabel2, TsbAddDestination, TsbDeleteDestination, toolStripSeparator2, toolStripLabel3, TsbAddGroup, TsbDeleteGroup, toolStripSeparator3, TsbRun });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(866, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(70, 22);
            toolStripLabel1.Text = "Source List: ";
            // 
            // TsbAddSource
            // 
            TsbAddSource.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbAddSource.Image = (Image)resources.GetObject("TsbAddSource.Image");
            TsbAddSource.ImageTransparentColor = Color.Magenta;
            TsbAddSource.Name = "TsbAddSource";
            TsbAddSource.Size = new Size(23, 22);
            TsbAddSource.Text = "Add";
            TsbAddSource.ToolTipText = "Add Source";
            TsbAddSource.Click += ButtonAddSourceFolder_Click;
            // 
            // TsbDeleteSource
            // 
            TsbDeleteSource.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbDeleteSource.Image = (Image)resources.GetObject("TsbDeleteSource.Image");
            TsbDeleteSource.ImageTransparentColor = Color.Magenta;
            TsbDeleteSource.Name = "TsbDeleteSource";
            TsbDeleteSource.Size = new Size(23, 22);
            TsbDeleteSource.Text = "Delete";
            TsbDeleteSource.ToolTipText = "Delete Source";
            TsbDeleteSource.Click += ButtonRemoveSourceFolder_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(91, 22);
            toolStripLabel2.Text = "Destination List:";
            // 
            // TsbAddDestination
            // 
            TsbAddDestination.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbAddDestination.Image = (Image)resources.GetObject("TsbAddDestination.Image");
            TsbAddDestination.ImageTransparentColor = Color.Magenta;
            TsbAddDestination.Name = "TsbAddDestination";
            TsbAddDestination.Size = new Size(23, 22);
            TsbAddDestination.Text = "Add Destination";
            TsbAddDestination.Click += ButtonAddDestinationFolder_Click;
            // 
            // TsbDeleteDestination
            // 
            TsbDeleteDestination.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbDeleteDestination.Image = (Image)resources.GetObject("TsbDeleteDestination.Image");
            TsbDeleteDestination.ImageTransparentColor = Color.Magenta;
            TsbDeleteDestination.Name = "TsbDeleteDestination";
            TsbDeleteDestination.Size = new Size(23, 22);
            TsbDeleteDestination.Text = "Delete Destination";
            TsbDeleteDestination.Click += ButtonRemoveDestinationFolder_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(109, 22);
            toolStripLabel3.Text = "Destination Group: ";
            // 
            // TsbAddGroup
            // 
            TsbAddGroup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbAddGroup.Image = (Image)resources.GetObject("TsbAddGroup.Image");
            TsbAddGroup.ImageTransparentColor = Color.Magenta;
            TsbAddGroup.Name = "TsbAddGroup";
            TsbAddGroup.Size = new Size(23, 22);
            TsbAddGroup.Text = "Add Destination Group";
            // 
            // TsbDeleteGroup
            // 
            TsbDeleteGroup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbDeleteGroup.Image = (Image)resources.GetObject("TsbDeleteGroup.Image");
            TsbDeleteGroup.ImageTransparentColor = Color.Magenta;
            TsbDeleteGroup.Name = "TsbDeleteGroup";
            TsbDeleteGroup.Size = new Size(23, 22);
            TsbDeleteGroup.Text = "toolStripButton2";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // TsbRun
            // 
            TsbRun.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbRun.Image = (Image)resources.GetObject("TsbRun.Image");
            TsbRun.ImageTransparentColor = Color.Magenta;
            TsbRun.Name = "TsbRun";
            TsbRun.Size = new Size(23, 22);
            TsbRun.Text = "Run Copy";
            TsbRun.Click += ButtonRunCopy_Click;
            // 
            // PanelSource
            // 
            PanelSource.Controls.Add(ScSource);
            PanelSource.Dock = DockStyle.Left;
            PanelSource.Location = new Point(0, 25);
            PanelSource.Name = "PanelSource";
            PanelSource.Size = new Size(667, 529);
            PanelSource.TabIndex = 2;
            // 
            // ScSource
            // 
            ScSource.Dock = DockStyle.Fill;
            ScSource.Location = new Point(0, 0);
            ScSource.Name = "ScSource";
            // 
            // ScSource.Panel1
            // 
            ScSource.Panel1.Controls.Add(GbSourceList);
            // 
            // ScSource.Panel2
            // 
            ScSource.Panel2.Controls.Add(groupBox1);
            ScSource.Size = new Size(667, 529);
            ScSource.SplitterDistance = 222;
            ScSource.TabIndex = 0;
            // 
            // GbSourceList
            // 
            GbSourceList.Controls.Add(ListBoxSource);
            GbSourceList.Dock = DockStyle.Fill;
            GbSourceList.Location = new Point(0, 0);
            GbSourceList.Name = "GbSourceList";
            GbSourceList.Size = new Size(222, 529);
            GbSourceList.TabIndex = 0;
            GbSourceList.TabStop = false;
            GbSourceList.Text = "Source List";
            // 
            // ListBoxSource
            // 
            ListBoxSource.Dock = DockStyle.Fill;
            ListBoxSource.FormattingEnabled = true;
            ListBoxSource.ItemHeight = 15;
            ListBoxSource.Location = new Point(3, 19);
            ListBoxSource.Name = "ListBoxSource";
            ListBoxSource.Size = new Size(216, 507);
            ListBoxSource.TabIndex = 0;
            ListBoxSource.Click += ListBoxSource_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListView);
            groupBox1.Controls.Add(toolStrip2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Explorer";
            // 
            // ListView
            // 
            ListView.Dock = DockStyle.Fill;
            ListView.LargeImageList = ImageList;
            ListView.Location = new Point(3, 44);
            ListView.Name = "ListView";
            ListView.Size = new Size(435, 482);
            ListView.TabIndex = 1;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.MouseDoubleClick += ListView_MouseDoubleClick;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth8Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "Up.png");
            ImageList.Images.SetKeyName(1, "File.png");
            ImageList.Images.SetKeyName(2, "Folder.png");
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { TsbUp });
            toolStrip2.Location = new Point(3, 19);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(435, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // TsbUp
            // 
            TsbUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsbUp.Image = (Image)resources.GetObject("TsbUp.Image");
            TsbUp.ImageTransparentColor = Color.Magenta;
            TsbUp.Name = "TsbUp";
            TsbUp.Size = new Size(23, 22);
            TsbUp.Text = "Up";
            TsbUp.Click += ButtonUp_Click;
            // 
            // PanelDestination
            // 
            PanelDestination.Controls.Add(ScDestination);
            PanelDestination.Dock = DockStyle.Right;
            PanelDestination.Location = new Point(666, 25);
            PanelDestination.Name = "PanelDestination";
            PanelDestination.Size = new Size(200, 529);
            PanelDestination.TabIndex = 0;
            // 
            // ScDestination
            // 
            ScDestination.Dock = DockStyle.Fill;
            ScDestination.Location = new Point(0, 0);
            ScDestination.Name = "ScDestination";
            ScDestination.Orientation = Orientation.Horizontal;
            // 
            // ScDestination.Panel1
            // 
            ScDestination.Panel1.Controls.Add(GbDestinationList);
            // 
            // ScDestination.Panel2
            // 
            ScDestination.Panel2.Controls.Add(GbDestinationGroup);
            ScDestination.Size = new Size(200, 529);
            ScDestination.SplitterDistance = 265;
            ScDestination.TabIndex = 0;
            // 
            // GbDestinationList
            // 
            GbDestinationList.Controls.Add(ListBoxDestination);
            GbDestinationList.Dock = DockStyle.Fill;
            GbDestinationList.Location = new Point(0, 0);
            GbDestinationList.Name = "GbDestinationList";
            GbDestinationList.Size = new Size(200, 265);
            GbDestinationList.TabIndex = 0;
            GbDestinationList.TabStop = false;
            GbDestinationList.Text = "Destination List";
            // 
            // ListBoxDestination
            // 
            ListBoxDestination.Dock = DockStyle.Fill;
            ListBoxDestination.FormattingEnabled = true;
            ListBoxDestination.ItemHeight = 15;
            ListBoxDestination.Location = new Point(3, 19);
            ListBoxDestination.Name = "ListBoxDestination";
            ListBoxDestination.Size = new Size(194, 243);
            ListBoxDestination.TabIndex = 0;
            // 
            // GbDestinationGroup
            // 
            GbDestinationGroup.Controls.Add(ListBoxDestinationGroup);
            GbDestinationGroup.Dock = DockStyle.Fill;
            GbDestinationGroup.Location = new Point(0, 0);
            GbDestinationGroup.Name = "GbDestinationGroup";
            GbDestinationGroup.Size = new Size(200, 260);
            GbDestinationGroup.TabIndex = 0;
            GbDestinationGroup.TabStop = false;
            GbDestinationGroup.Text = "Destination Group";
            // 
            // ListBoxDestinationGroup
            // 
            ListBoxDestinationGroup.Dock = DockStyle.Fill;
            ListBoxDestinationGroup.FormattingEnabled = true;
            ListBoxDestinationGroup.ItemHeight = 15;
            ListBoxDestinationGroup.Location = new Point(3, 19);
            ListBoxDestinationGroup.Name = "ListBoxDestinationGroup";
            ListBoxDestinationGroup.Size = new Size(194, 238);
            ListBoxDestinationGroup.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 554);
            Controls.Add(PanelDestination);
            Controls.Add(PanelSource);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Copy Backup";
            Load += FormMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            PanelSource.ResumeLayout(false);
            ScSource.Panel1.ResumeLayout(false);
            ScSource.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScSource).EndInit();
            ScSource.ResumeLayout(false);
            GbSourceList.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            PanelDestination.ResumeLayout(false);
            ScDestination.Panel1.ResumeLayout(false);
            ScDestination.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScDestination).EndInit();
            ScDestination.ResumeLayout(false);
            GbDestinationList.ResumeLayout(false);
            GbDestinationGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel PanelSource;
        private SplitContainer ScSource;
        private Panel PanelDestination;
        private SplitContainer ScDestination;
        private GroupBox GbDestinationList;
        private ListBox ListBoxDestination;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton TsbAddSource;
        private ToolStripButton TsbDeleteSource;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton TsbAddDestination;
        private ToolStripButton TsbDeleteDestination;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbRun;
        private GroupBox GbSourceList;
        private ListBox ListBoxSource;
        private GroupBox groupBox1;
        private ListView ListView;
        private ToolStrip toolStrip2;
        private ToolStripButton TsbUp;
        private GroupBox GbDestinationGroup;
        private ListBox ListBoxDestinationGroup;
        private ImageList ImageList;
        private FolderBrowserDialog FolderBrowserDialog;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton TsbAddGroup;
        private ToolStripButton TsbDeleteGroup;
        private ToolStripSeparator toolStripSeparator3;
    }
}