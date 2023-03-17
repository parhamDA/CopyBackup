namespace CopyBackup.Forms
{
    partial class FormCreateBackup
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
            label1 = new Label();
            tbBackupName = new TextBox();
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            btnAddSource = new ToolStripButton();
            btnDeleteSource = new ToolStripButton();
            panel1 = new Panel();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            listBox2 = new ListBox();
            toolStrip2 = new ToolStrip();
            btnAddDestination = new ToolStripButton();
            btnDeleteDestination = new ToolStripButton();
            btnSave = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Backup Name";
            // 
            // tbBackupName
            // 
            tbBackupName.Location = new Point(99, 6);
            tbBackupName.MaxLength = 50;
            tbBackupName.Name = "tbBackupName";
            tbBackupName.Size = new Size(317, 23);
            tbBackupName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Location = new Point(13, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 284);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source Items";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddSource, btnDeleteSource });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(194, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddSource
            // 
            btnAddSource.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddSource.Image = Properties.Resources.Add;
            btnAddSource.ImageTransparentColor = Color.Magenta;
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(23, 22);
            btnAddSource.Text = "Add Source";
            // 
            // btnDeleteSource
            // 
            btnDeleteSource.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteSource.Image = Properties.Resources.Remove;
            btnDeleteSource.ImageTransparentColor = Color.Magenta;
            btnDeleteSource.Name = "btnDeleteSource";
            btnDeleteSource.Size = new Size(23, 22);
            btnDeleteSource.Text = "Delete Source";
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 237);
            panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 237);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(toolStrip2);
            groupBox2.Location = new Point(219, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 284);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Destination Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(listBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 237);
            panel2.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(0, 0);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(194, 237);
            listBox2.TabIndex = 0;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAddDestination, btnDeleteDestination });
            toolStrip2.Location = new Point(3, 19);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(194, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAddDestination
            // 
            btnAddDestination.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddDestination.Image = Properties.Resources.Add;
            btnAddDestination.ImageTransparentColor = Color.Magenta;
            btnAddDestination.Name = "btnAddDestination";
            btnAddDestination.Size = new Size(23, 22);
            btnAddDestination.Text = "Add Destination";
            // 
            // btnDeleteDestination
            // 
            btnDeleteDestination.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteDestination.Image = Properties.Resources.Remove;
            btnDeleteDestination.ImageTransparentColor = Color.Magenta;
            btnDeleteDestination.Name = "btnDeleteDestination";
            btnDeleteDestination.Size = new Size(23, 22);
            btnDeleteDestination.Text = "Delete Destination";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(18, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormCreateBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 352);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tbBackupName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCreateBackup";
            Text = "Create Backup";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbBackupName;
        private GroupBox groupBox1;
        private Panel panel1;
        private ListBox listBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddSource;
        private ToolStripButton btnDeleteSource;
        private GroupBox groupBox2;
        private Panel panel2;
        private ListBox listBox2;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAddDestination;
        private ToolStripButton btnDeleteDestination;
        private Button btnSave;
        private FolderBrowserDialog folderBrowserDialog;
    }
}