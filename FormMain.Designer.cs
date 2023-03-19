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
            toolStrip = new ToolStrip();
            btnAddBackup = new ToolStripButton();
            btnDeleteBackup = new ToolStripButton();
            btnEditBackup = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRun = new ToolStripButton();
            groupBoxDestinations = new GroupBox();
            listBoxDestinations = new ListBox();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            splitContainer = new SplitContainer();
            groupBoxBackup = new GroupBox();
            listBoxBackups = new ListBox();
            panelBackupDestination = new Panel();
            panelListView = new Panel();
            groupBoxListView = new GroupBox();
            listView = new ListView();
            imageList = new ImageList(components);
            toolStrip.SuspendLayout();
            groupBoxDestinations.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBoxBackup.SuspendLayout();
            panelBackupDestination.SuspendLayout();
            panelListView.SuspendLayout();
            groupBoxListView.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { btnAddBackup, btnDeleteBackup, btnEditBackup, toolStripSeparator1, btnRun });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(938, 25);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "Run Backup";
            // 
            // btnAddBackup
            // 
            btnAddBackup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddBackup.Image = Properties.Resources.Add;
            btnAddBackup.ImageTransparentColor = Color.Magenta;
            btnAddBackup.Name = "btnAddBackup";
            btnAddBackup.Size = new Size(23, 22);
            btnAddBackup.Text = "Add Backup";
            btnAddBackup.Click += BtnAddBackup_Click;
            // 
            // btnDeleteBackup
            // 
            btnDeleteBackup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteBackup.Image = Properties.Resources.Remove;
            btnDeleteBackup.ImageTransparentColor = Color.Magenta;
            btnDeleteBackup.Name = "btnDeleteBackup";
            btnDeleteBackup.Size = new Size(23, 22);
            btnDeleteBackup.Text = "Delete Backup";
            btnDeleteBackup.Click += BtnDeleteBackup_Click;
            // 
            // btnEditBackup
            // 
            btnEditBackup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditBackup.Image = Properties.Resources.Edit;
            btnEditBackup.ImageTransparentColor = Color.Magenta;
            btnEditBackup.Name = "btnEditBackup";
            btnEditBackup.Size = new Size(23, 22);
            btnEditBackup.Text = "Edit Backup";
            btnEditBackup.Click += BtnEditBackup_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnRun
            // 
            btnRun.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRun.Image = Properties.Resources.Start;
            btnRun.ImageTransparentColor = Color.Magenta;
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(23, 22);
            btnRun.Text = "Run Backup";
            btnRun.Click += BtnRun_Click;
            // 
            // groupBoxDestinations
            // 
            groupBoxDestinations.Controls.Add(listBoxDestinations);
            groupBoxDestinations.Dock = DockStyle.Fill;
            groupBoxDestinations.Location = new Point(0, 0);
            groupBoxDestinations.Name = "groupBoxDestinations";
            groupBoxDestinations.Size = new Size(686, 135);
            groupBoxDestinations.TabIndex = 1;
            groupBoxDestinations.TabStop = false;
            groupBoxDestinations.Text = "Backup Destinations";
            // 
            // listBoxDestinations
            // 
            listBoxDestinations.BackColor = SystemColors.WindowFrame;
            listBoxDestinations.Dock = DockStyle.Fill;
            listBoxDestinations.ForeColor = SystemColors.Window;
            listBoxDestinations.FormattingEnabled = true;
            listBoxDestinations.ItemHeight = 15;
            listBoxDestinations.Location = new Point(3, 19);
            listBoxDestinations.Name = "listBoxDestinations";
            listBoxDestinations.SelectionMode = SelectionMode.None;
            listBoxDestinations.Size = new Size(680, 113);
            listBoxDestinations.Sorted = true;
            listBoxDestinations.TabIndex = 0;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 532);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(938, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(923, 17);
            lblStatus.Spring = true;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 25);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(groupBoxBackup);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelBackupDestination);
            splitContainer.Panel2.Controls.Add(panelListView);
            splitContainer.Size = new Size(938, 507);
            splitContainer.SplitterDistance = 248;
            splitContainer.TabIndex = 3;
            // 
            // groupBoxBackup
            // 
            groupBoxBackup.Controls.Add(listBoxBackups);
            groupBoxBackup.Dock = DockStyle.Fill;
            groupBoxBackup.Location = new Point(0, 0);
            groupBoxBackup.Name = "groupBoxBackup";
            groupBoxBackup.Size = new Size(248, 507);
            groupBoxBackup.TabIndex = 0;
            groupBoxBackup.TabStop = false;
            groupBoxBackup.Text = "Backups";
            // 
            // listBoxBackups
            // 
            listBoxBackups.Dock = DockStyle.Fill;
            listBoxBackups.FormattingEnabled = true;
            listBoxBackups.ItemHeight = 15;
            listBoxBackups.Location = new Point(3, 19);
            listBoxBackups.Name = "listBoxBackups";
            listBoxBackups.Size = new Size(242, 485);
            listBoxBackups.Sorted = true;
            listBoxBackups.TabIndex = 0;
            listBoxBackups.SelectedIndexChanged += ListBoxBackups_SelectedIndexChanged;
            // 
            // panelBackupDestination
            // 
            panelBackupDestination.Controls.Add(groupBoxDestinations);
            panelBackupDestination.Dock = DockStyle.Bottom;
            panelBackupDestination.Location = new Point(0, 372);
            panelBackupDestination.Name = "panelBackupDestination";
            panelBackupDestination.Size = new Size(686, 135);
            panelBackupDestination.TabIndex = 3;
            // 
            // panelListView
            // 
            panelListView.Controls.Add(groupBoxListView);
            panelListView.Dock = DockStyle.Top;
            panelListView.Location = new Point(0, 0);
            panelListView.Name = "panelListView";
            panelListView.Size = new Size(686, 366);
            panelListView.TabIndex = 2;
            // 
            // groupBoxListView
            // 
            groupBoxListView.Controls.Add(listView);
            groupBoxListView.Dock = DockStyle.Fill;
            groupBoxListView.Location = new Point(0, 0);
            groupBoxListView.Name = "groupBoxListView";
            groupBoxListView.Size = new Size(686, 366);
            groupBoxListView.TabIndex = 0;
            groupBoxListView.TabStop = false;
            groupBoxListView.Text = "Backup Items";
            // 
            // listView
            // 
            listView.Dock = DockStyle.Fill;
            listView.LargeImageList = imageList;
            listView.Location = new Point(3, 19);
            listView.Name = "listView";
            listView.Size = new Size(680, 344);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "File.png");
            imageList.Images.SetKeyName(1, "Folder.png");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 554);
            Controls.Add(splitContainer);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Copy Backup";
            Load += FormMain_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBoxDestinations.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            groupBoxBackup.ResumeLayout(false);
            panelBackupDestination.ResumeLayout(false);
            panelListView.ResumeLayout(false);
            groupBoxListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton btnAddBackup;
        private ToolStripButton btnDeleteBackup;
        private ToolStripButton btnEditBackup;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnRun;
        private GroupBox groupBoxDestinations;
        private ListBox listBoxDestinations;
        private StatusStrip statusStrip;
        private SplitContainer splitContainer;
        private GroupBox groupBoxBackup;
        private ListBox listBoxBackups;
        private GroupBox groupBoxListView;
        private ToolStripStatusLabel lblStatus;
        private ImageList imageList;
        private Panel panelBackupDestination;
        private Panel panelListView;
        private ListView listView;
    }
}