namespace CopyBackup.Forms
{
    partial class FormRunBackup
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
            lblBackupName = new Label();
            progressBar = new ProgressBar();
            lblPercentage = new Label();
            lblCopyingFile = new Label();
            panel1 = new Panel();
            btnStopBackup = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBackupName
            // 
            lblBackupName.AutoSize = true;
            lblBackupName.Location = new Point(12, 9);
            lblBackupName.Name = "lblBackupName";
            lblBackupName.Size = new Size(0, 15);
            lblBackupName.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 50);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(452, 23);
            progressBar.TabIndex = 1;
            // 
            // lblPercentage
            // 
            lblPercentage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercentage.Location = new Point(470, 50);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(63, 21);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "0%";
            // 
            // lblCopyingFile
            // 
            lblCopyingFile.Location = new Point(12, 81);
            lblCopyingFile.Name = "lblCopyingFile";
            lblCopyingFile.Size = new Size(461, 15);
            lblCopyingFile.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnStopBackup);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 56);
            panel1.TabIndex = 4;
            // 
            // btnStopBackup
            // 
            btnStopBackup.Location = new Point(442, 21);
            btnStopBackup.Name = "btnStopBackup";
            btnStopBackup.Size = new Size(88, 23);
            btnStopBackup.TabIndex = 0;
            btnStopBackup.Text = "Stop Backup";
            btnStopBackup.UseVisualStyleBackColor = true;
            btnStopBackup.Click += BtnStopBackup_Click;
            // 
            // FormRunBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 179);
            Controls.Add(panel1);
            Controls.Add(lblCopyingFile);
            Controls.Add(lblPercentage);
            Controls.Add(progressBar);
            Controls.Add(lblBackupName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormRunBackup";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Backup";
            FormClosing += FormRunBackup_FormClosing;
            Shown += FormRunBackup_Shown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBackupName;
        private ProgressBar progressBar;
        private Label lblPercentage;
        private Label lblCopyingFile;
        private Panel panel1;
        private Button btnStopBackup;
    }
}