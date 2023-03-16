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
            ListBoxSource = new ListBox();
            FolderBrowserDialog = new FolderBrowserDialog();
            ListBoxDestination = new ListBox();
            ListView = new ListView();
            ImageList = new ImageList(components);
            panel1 = new Panel();
            ButtonAddSourceFolder = new Button();
            ButtonRemoveSourceFolder = new Button();
            ToolTip = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            panel2 = new Panel();
            panel3 = new Panel();
            ButtonAddDestinationFolder = new Button();
            ButtonRemoveDestinationItem = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel8 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel9 = new Panel();
            ButtonUp = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxSource
            // 
            ListBoxSource.Dock = DockStyle.Fill;
            ListBoxSource.FormattingEnabled = true;
            ListBoxSource.ItemHeight = 15;
            ListBoxSource.Location = new Point(0, 0);
            ListBoxSource.Name = "ListBoxSource";
            ListBoxSource.Size = new Size(200, 506);
            ListBoxSource.TabIndex = 1;
            ListBoxSource.SelectedIndexChanged += ListBoxSource_SelectedIndexChanged;
            // 
            // ListBoxDestination
            // 
            ListBoxDestination.Dock = DockStyle.Fill;
            ListBoxDestination.FormattingEnabled = true;
            ListBoxDestination.ItemHeight = 15;
            ListBoxDestination.Location = new Point(0, 0);
            ListBoxDestination.Name = "ListBoxDestination";
            ListBoxDestination.SelectionMode = SelectionMode.MultiSimple;
            ListBoxDestination.Size = new Size(200, 506);
            ListBoxDestination.TabIndex = 5;
            // 
            // ListView
            // 
            ListView.Dock = DockStyle.Fill;
            ListView.LargeImageList = ImageList;
            ListView.Location = new Point(0, 0);
            ListView.Name = "ListView";
            ListView.Size = new Size(400, 506);
            ListView.TabIndex = 9;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.MouseDoubleClick += ListView_MouseDoubleClick;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth8Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "Folder-64.ico");
            ImageList.Images.SetKeyName(1, "File-64.ico");
            ImageList.Images.SetKeyName(2, "Add.png");
            ImageList.Images.SetKeyName(3, "Remove.png");
            ImageList.Images.SetKeyName(4, "Up.ico");
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(statusStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 554);
            panel1.TabIndex = 17;
            // 
            // ButtonAddSourceFolder
            // 
            ButtonAddSourceFolder.BackgroundImageLayout = ImageLayout.Center;
            ButtonAddSourceFolder.FlatAppearance.BorderColor = SystemColors.ControlDark;
            ButtonAddSourceFolder.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            ButtonAddSourceFolder.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ButtonAddSourceFolder.FlatStyle = FlatStyle.Flat;
            ButtonAddSourceFolder.ImageIndex = 2;
            ButtonAddSourceFolder.ImageList = ImageList;
            ButtonAddSourceFolder.Location = new Point(3, 3);
            ButtonAddSourceFolder.Name = "ButtonAddSourceFolder";
            ButtonAddSourceFolder.Size = new Size(24, 23);
            ButtonAddSourceFolder.TabIndex = 10;
            ToolTip.SetToolTip(ButtonAddSourceFolder, "Add source folder");
            ButtonAddSourceFolder.UseVisualStyleBackColor = true;
            ButtonAddSourceFolder.Click += ButtonAddSourceFolder_Click;
            // 
            // ButtonRemoveSourceFolder
            // 
            ButtonRemoveSourceFolder.BackgroundImageLayout = ImageLayout.Center;
            ButtonRemoveSourceFolder.FlatAppearance.BorderColor = SystemColors.ControlDark;
            ButtonRemoveSourceFolder.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            ButtonRemoveSourceFolder.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ButtonRemoveSourceFolder.FlatStyle = FlatStyle.Flat;
            ButtonRemoveSourceFolder.ImageIndex = 3;
            ButtonRemoveSourceFolder.ImageList = ImageList;
            ButtonRemoveSourceFolder.Location = new Point(33, 3);
            ButtonRemoveSourceFolder.Name = "ButtonRemoveSourceFolder";
            ButtonRemoveSourceFolder.Size = new Size(24, 26);
            ButtonRemoveSourceFolder.TabIndex = 11;
            ToolTip.SetToolTip(ButtonRemoveSourceFolder, "Remove source folder");
            ButtonRemoveSourceFolder.UseVisualStyleBackColor = true;
            ButtonRemoveSourceFolder.Click += ButtonRemoveSourceFolder_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 532);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 532);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(600, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 532);
            panel3.TabIndex = 14;
            // 
            // ButtonAddDestinationFolder
            // 
            ButtonAddDestinationFolder.BackgroundImageLayout = ImageLayout.Center;
            ButtonAddDestinationFolder.FlatAppearance.BorderColor = SystemColors.ControlDark;
            ButtonAddDestinationFolder.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            ButtonAddDestinationFolder.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ButtonAddDestinationFolder.FlatStyle = FlatStyle.Flat;
            ButtonAddDestinationFolder.ImageIndex = 2;
            ButtonAddDestinationFolder.ImageList = ImageList;
            ButtonAddDestinationFolder.Location = new Point(3, 3);
            ButtonAddDestinationFolder.Name = "ButtonAddDestinationFolder";
            ButtonAddDestinationFolder.Size = new Size(24, 23);
            ButtonAddDestinationFolder.TabIndex = 12;
            ToolTip.SetToolTip(ButtonAddDestinationFolder, "Add destination folder");
            ButtonAddDestinationFolder.UseVisualStyleBackColor = true;
            ButtonAddDestinationFolder.Click += ButtonAddDestinationFolder_Click;
            // 
            // ButtonRemoveDestinationItem
            // 
            ButtonRemoveDestinationItem.BackgroundImageLayout = ImageLayout.Center;
            ButtonRemoveDestinationItem.FlatAppearance.BorderColor = SystemColors.ControlDark;
            ButtonRemoveDestinationItem.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            ButtonRemoveDestinationItem.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ButtonRemoveDestinationItem.FlatStyle = FlatStyle.Flat;
            ButtonRemoveDestinationItem.ImageIndex = 3;
            ButtonRemoveDestinationItem.ImageList = ImageList;
            ButtonRemoveDestinationItem.Location = new Point(33, 3);
            ButtonRemoveDestinationItem.Name = "ButtonRemoveDestinationItem";
            ButtonRemoveDestinationItem.Size = new Size(24, 23);
            ButtonRemoveDestinationItem.TabIndex = 13;
            ToolTip.SetToolTip(ButtonRemoveDestinationItem, "Remove destination folder");
            ButtonRemoveDestinationItem.UseVisualStyleBackColor = true;
            ButtonRemoveDestinationItem.Click += ButtonRemoveDestinationItem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 26);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(ListBoxDestination);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 506);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 26);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(ListBoxSource);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 506);
            panel7.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ButtonAddDestinationFolder);
            flowLayoutPanel1.Controls.Add(ButtonRemoveDestinationItem);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 26);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(ButtonAddSourceFolder);
            flowLayoutPanel2.Controls.Add(ButtonRemoveSourceFolder);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 26);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(flowLayoutPanel3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(200, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(400, 532);
            panel8.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(ButtonUp);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(400, 26);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(ListView);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 26);
            panel9.Name = "panel9";
            panel9.Size = new Size(400, 506);
            panel9.TabIndex = 16;
            // 
            // ButtonUp
            // 
            ButtonUp.BackgroundImageLayout = ImageLayout.Center;
            ButtonUp.FlatAppearance.BorderColor = SystemColors.ControlDark;
            ButtonUp.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            ButtonUp.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ButtonUp.FlatStyle = FlatStyle.Flat;
            ButtonUp.ImageIndex = 4;
            ButtonUp.ImageList = ImageList;
            ButtonUp.Location = new Point(3, 3);
            ButtonUp.Name = "ButtonUp";
            ButtonUp.Size = new Size(24, 23);
            ButtonUp.TabIndex = 12;
            ToolTip.SetToolTip(ButtonUp, "Up");
            ButtonUp.UseVisualStyleBackColor = true;
            ButtonUp.Click += ButtonUp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Copy Backup";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox ListBoxSource;
        private FolderBrowserDialog FolderBrowserDialog;
        private ListBox ListBoxDestination;
        private ListView ListView;
        private ImageList ImageList;
        private Panel panel1;
        private Button ButtonAddSourceFolder;
        private ToolTip ToolTip;
        private Button ButtonRemoveSourceFolder;
        private Panel panel8;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button ButtonUp;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ButtonAddDestinationFolder;
        private Button ButtonRemoveDestinationItem;
        private Panel panel2;
        private Panel panel7;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel2;
        private StatusStrip statusStrip1;
    }
}