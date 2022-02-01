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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonAddSourceFolder = new System.Windows.Forms.Button();
            this.ListBoxSource = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonRemoveSourceItem = new System.Windows.Forms.Button();
            this.ListBoxDestination = new System.Windows.Forms.ListBox();
            this.ButtonAddDestinationFolder = new System.Windows.Forms.Button();
            this.ButtonRemoveDestinationItem = new System.Windows.Forms.Button();
            this.ButtonRunCopy = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAddSourceFolder
            // 
            this.ButtonAddSourceFolder.Location = new System.Drawing.Point(12, 519);
            this.ButtonAddSourceFolder.Name = "ButtonAddSourceFolder";
            this.ButtonAddSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddSourceFolder.TabIndex = 0;
            this.ButtonAddSourceFolder.Text = "Add";
            this.ButtonAddSourceFolder.UseVisualStyleBackColor = true;
            this.ButtonAddSourceFolder.Click += new System.EventHandler(this.ButtonAddSourceFolder_Click);
            // 
            // ListBoxSource
            // 
            this.ListBoxSource.FormattingEnabled = true;
            this.ListBoxSource.ItemHeight = 15;
            this.ListBoxSource.Location = new System.Drawing.Point(12, 27);
            this.ListBoxSource.Name = "ListBoxSource";
            this.ListBoxSource.Size = new System.Drawing.Size(156, 484);
            this.ListBoxSource.TabIndex = 1;
            this.ListBoxSource.SelectedIndexChanged += new System.EventHandler(this.ListBoxSource_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Items";
            // 
            // ButtonRemoveSourceItem
            // 
            this.ButtonRemoveSourceItem.Location = new System.Drawing.Point(93, 519);
            this.ButtonRemoveSourceItem.Name = "ButtonRemoveSourceItem";
            this.ButtonRemoveSourceItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemoveSourceItem.TabIndex = 4;
            this.ButtonRemoveSourceItem.Text = "Remove";
            this.ButtonRemoveSourceItem.UseVisualStyleBackColor = true;
            this.ButtonRemoveSourceItem.Click += new System.EventHandler(this.ButtonRemoveSourceItem_Click);
            // 
            // ListBoxDestination
            // 
            this.ListBoxDestination.FormattingEnabled = true;
            this.ListBoxDestination.ItemHeight = 15;
            this.ListBoxDestination.Location = new System.Drawing.Point(631, 27);
            this.ListBoxDestination.Name = "ListBoxDestination";
            this.ListBoxDestination.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxDestination.Size = new System.Drawing.Size(156, 484);
            this.ListBoxDestination.TabIndex = 5;
            // 
            // ButtonAddDestinationFolder
            // 
            this.ButtonAddDestinationFolder.Location = new System.Drawing.Point(631, 519);
            this.ButtonAddDestinationFolder.Name = "ButtonAddDestinationFolder";
            this.ButtonAddDestinationFolder.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddDestinationFolder.TabIndex = 6;
            this.ButtonAddDestinationFolder.Text = "Add";
            this.ButtonAddDestinationFolder.UseVisualStyleBackColor = true;
            this.ButtonAddDestinationFolder.Click += new System.EventHandler(this.ButtonAddDestinationFolder_Click);
            // 
            // ButtonRemoveDestinationItem
            // 
            this.ButtonRemoveDestinationItem.Location = new System.Drawing.Point(712, 519);
            this.ButtonRemoveDestinationItem.Name = "ButtonRemoveDestinationItem";
            this.ButtonRemoveDestinationItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemoveDestinationItem.TabIndex = 7;
            this.ButtonRemoveDestinationItem.Text = "Remove";
            this.ButtonRemoveDestinationItem.UseVisualStyleBackColor = true;
            this.ButtonRemoveDestinationItem.Click += new System.EventHandler(this.ButtonRemoveDestinationItem_Click);
            // 
            // ButtonRunCopy
            // 
            this.ButtonRunCopy.Location = new System.Drawing.Point(550, 519);
            this.ButtonRunCopy.Name = "ButtonRunCopy";
            this.ButtonRunCopy.Size = new System.Drawing.Size(75, 23);
            this.ButtonRunCopy.TabIndex = 8;
            this.ButtonRunCopy.Text = "Copy";
            this.ButtonRunCopy.UseVisualStyleBackColor = true;
            this.ButtonRunCopy.Click += new System.EventHandler(this.ButtonRunCopy_Click);
            // 
            // ListView
            // 
            this.ListView.LargeImageList = this.ImageList;
            this.ListView.Location = new System.Drawing.Point(174, 27);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(451, 484);
            this.ListView.TabIndex = 9;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Folder-64.ico");
            this.ImageList.Images.SetKeyName(1, "File-64.ico");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Source Items";
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(174, 519);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(75, 23);
            this.ButtonUp.TabIndex = 11;
            this.ButtonUp.Text = "Up";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Destination Items";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.ButtonRunCopy);
            this.Controls.Add(this.ButtonRemoveDestinationItem);
            this.Controls.Add(this.ButtonAddDestinationFolder);
            this.Controls.Add(this.ListBoxDestination);
            this.Controls.Add(this.ButtonRemoveSourceItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxSource);
            this.Controls.Add(this.ButtonAddSourceFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Backup";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonAddSourceFolder;
        private ListBox ListBoxSource;
        private Label label1;
        private FolderBrowserDialog FolderBrowserDialog;
        private Button ButtonRemoveSourceItem;
        private ListBox ListBoxDestination;
        private Button ButtonAddDestinationFolder;
        private Button ButtonRemoveDestinationItem;
        private Button ButtonRunCopy;
        private ListView ListView;
        private ImageList ImageList;
        private Label label2;
        private Button ButtonUp;
        private Label label3;
    }
}