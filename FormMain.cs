using CopyBackup.Data;
using CopyBackup.Forms;
using CopyBackup.Models;
using CopyBackup.Services;

using System.ComponentModel;

namespace CopyBackup;

public record BackupProcess
{
    public int FilesCopiedCount { get; set; }
    public string FileCopiedName { get; set; } = string.Empty;
}

public partial class FormMain : Form
{
    private readonly BackgroundWorker _copyBackgroudWorker;

    private readonly List<string> _backupItems = [];
    private readonly CopyService _copyService = new();
    private readonly Database _database = new();
    private BackupModel _selectedbackup = new();

    public FormMain()
    {
        InitializeComponent();
        _copyBackgroudWorker = new BackgroundWorker();
        _copyBackgroudWorker.DoWork += new DoWorkEventHandler(RunCopyService);
        _copyBackgroudWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CopyServiceFinished);
        _copyBackgroudWorker.ProgressChanged += new ProgressChangedEventHandler(CopyServiceProgressChannged);
        _copyBackgroudWorker.WorkerReportsProgress = true;
    }

    #region Events
    private void FormMain_Load(object sender, EventArgs e)
    {
        try
        {
            _backupItems.AddRange(_database.GetBackups().ToList());
            listBoxBackups.Items.AddRange(_backupItems.ToArray());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FormMain_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
        {
            Hide();

            notifyIconContextMenu.Items.Clear();

            foreach (var menuItem in from item in _backupItems
                                     let menuItem = new ToolStripMenuItem
                                     {
                                         Text = item
                                     }
                                     select menuItem)
            {
                menuItem.Click += MenuItem_Click;
                notifyIconContextMenu.Items.Add(menuItem);
            }

            notifyIcon.Visible = true;
        }
    }

    private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
        notifyIcon.Visible = false;
    }

    private void MenuItem_Click(object? sender, EventArgs e)
    {
        if (sender is null)
        {
            notifyIcon.ShowBalloonTip(7000, "Error!", "There is an isuue to run backup", ToolTipIcon.Error);
        }
        else
        {
            notifyIcon.ShowBalloonTip(7000, "‌Backup Running!", $"[{sender}] backup is in process ...", ToolTipIcon.Info);

            var posibleErrorMessage = GetSelectedBackup(sender.ToString()!);
            if (string.IsNullOrEmpty(posibleErrorMessage))
            {
                _copyService.Backup = _selectedbackup;
                _copyBackgroudWorker.RunWorkerAsync();
            }
            else
            {
                notifyIcon.ShowBalloonTip(7000, "‌Error!", posibleErrorMessage, ToolTipIcon.Error);
            }
        }
    }

    private void BtnAddBackup_Click(object sender, EventArgs e)
    {
        ResetUi();

        var frmSetupBackup = new FormSetupBackup();
        var frmSetupBackupDialogResult = frmSetupBackup.ShowDialog();
        if (frmSetupBackupDialogResult != DialogResult.OK) { return; }

        listBoxBackups.Items.Add(frmSetupBackup.SavedBackupName!);
        listBoxBackups.SelectedItem = frmSetupBackup.SavedBackupName!;
        
        _backupItems.Add(frmSetupBackup.SavedBackupName!);
    }

    private void BtnDeleteBackup_Click(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null ||
            string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
        { return; }

        ResetUi();

        _backupItems.Remove(listBoxBackups.SelectedItem.ToString()!);

        listBoxBackups.Items.RemoveAt(listBoxBackups.SelectedIndex);
        listBoxDestinations.Items.Clear();
        listView.Items.Clear();

        try
        {
            _database.DeleteBackup(_selectedbackup.Id);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        _selectedbackup = new();
    }

    private void BtnEditBackup_Click(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null ||
            string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
            return;

        ResetUi();

        var frmSetupBackup = new FormSetupBackup(_selectedbackup);
        var frmSetupBackupDialogResult = frmSetupBackup.ShowDialog();
        if (frmSetupBackupDialogResult != DialogResult.OK) { return; }

        var savedBackupName = frmSetupBackup.SavedBackupName;
        var listBoxItemIndex = listBoxBackups.Items.IndexOf(_selectedbackup.Name);

        if (_selectedbackup.Name != savedBackupName)
        {
            listBoxBackups.Items[listBoxItemIndex] = savedBackupName!;
            _backupItems[listBoxItemIndex] = savedBackupName!;
        }
        else
        {
            listBoxBackups.Items[listBoxItemIndex] = _selectedbackup.Name;
            _backupItems[listBoxItemIndex] = _selectedbackup.Name;
        }
    }

    private void BtnRun_Click(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null || string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
        { return; }

        toolStrip.Enabled = false;
        listBoxBackups.Enabled = false;
        lblStatus.ForeColor = Color.Navy;
        lblStatus.Text = $"[{_selectedbackup.Name}] backup is in process . . .";

        _copyService.Backup = _selectedbackup;
        progressBar.Maximum = _copyService.SourceFilesCount();
        if (progressBar.Maximum == 0)
        {
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Text = $"[{_selectedbackup.Name}] has no archive file to backup . . .";
            toolStrip.Enabled = true;
            listBoxBackups.Enabled = true;
            return;
        }

        _copyBackgroudWorker.RunWorkerAsync();
    }

    private void ListBoxBackups_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null ||
            string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
        { return; }

        ResetUi();

        var posibleErrorMessage = GetSelectedBackup(listBoxBackups.SelectedItem.ToString()!);
        if (!string.IsNullOrEmpty(posibleErrorMessage))
        {
            MessageBox.Show(posibleErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        listView.Items.Clear();
        foreach (var item in _selectedbackup.Sources)
        {
            listView.Items.Add(new ListViewItem
            {
                Text = item.Name,
                Tag = item.Path,
                ImageIndex = item.IsFile ? 0 : 1
            });
        }

        listBoxDestinations.Items.Clear();
        listBoxDestinations.Items.AddRange(_selectedbackup.Destinations.Select(x => x.Path).ToArray());
    }
    #endregion

    #region BackgroundWorkerEvents
    private void RunCopyService(object? sender, DoWorkEventArgs e)
    {
        Thread.Sleep(2000);
        var destinationsPath = _selectedbackup.Destinations.Select(x => x.Path).ToList();
        var lastDestination = destinationsPath.Last();

        _copyService.FileCopiedName = string.Empty;
        _copyService.FilesCopiedCount = 0;
        _copyService.RemoveArchiveAttribute = false;

        var hasError = false;
        var isDestinationExist = false;
        var notFoundDestinations = string.Empty;

        foreach (var destinationPath in destinationsPath)
        {
            try
            {
                if (destinationPath == lastDestination)
                {
                    _copyService.RemoveArchiveAttribute = true;
                }

                if (Directory.Exists(destinationPath) == false)
                {

                    notFoundDestinations += string.IsNullOrEmpty(notFoundDestinations) ? $"{destinationPath} " : $"{destinationPath}, ";
                    continue;
                }

                isDestinationExist = true;

                foreach (var source in _selectedbackup.Sources)
                {
                    try
                    {
                        if (source.IsFile == false && Directory.Exists(source.Path) == true)
                        {
                            _copyService.CopyDirectory(source.Path, destinationPath);
                        }
                        else
                        {
                            _copyService.CopyFile(source.Path, destinationPath);
                        }

                        if (_copyService.FilesCopiedCount != 0 && !string.IsNullOrEmpty(_copyService.FileCopiedName))
                        {
                            _copyBackgroudWorker.ReportProgress(0, new BackupProcess
                            {
                                FilesCopiedCount = _copyService.FilesCopiedCount,
                                FileCopiedName = _copyService.FileCopiedName
                            });
                            Thread.Sleep(500);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasError = true;
            }
        }

        if (hasError)
        {
            e.Result = "Backup finished with error(s)";
        }
        else if (!isDestinationExist)
        {
            e.Result = $"Destination(s) not found: {notFoundDestinations}";
        }
        else
        {
            e.Result = new BackupProcess
            {
                FilesCopiedCount = _copyService.FilesCopiedCount,
                FileCopiedName = _copyService.FileCopiedName
            };
        }
    }

    private void CopyServiceFinished(object? sender, RunWorkerCompletedEventArgs e)
    {
        if (e.Result is null) return;

        if (e.Result.GetType() == typeof(string))
        {
            if(notifyIcon.Visible)
            {
                notifyIcon.ShowBalloonTip(7000, "‌Error!", $"[{_selectedbackup.Name}] {e.Result}", ToolTipIcon.Error);
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = $"[{_selectedbackup.Name}] {e.Result}";
                progressBar.Value = progressBar.Maximum;
                toolStrip.Enabled = true;
                listBoxBackups.Enabled = true;
            }
        }
        else if (e.Result is BackupProcess result)
        {
            if (notifyIcon.Visible)
            {
                notifyIcon.ShowBalloonTip(7000, "‌Info", $"[{_selectedbackup.Name}] backup is finished successfully . . .", ToolTipIcon.Info);
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = result?.FileCopiedName;

                if (result!.FilesCopiedCount <= progressBar.Maximum)
                { progressBar.Value = result!.FilesCopiedCount; }

                if (progressBar.Value == progressBar.Maximum)
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"[{_selectedbackup.Name}] backup is finished successfully . . .";
                    toolStrip.Enabled = true;
                    listBoxBackups.Enabled = true;
                }
            }
        }
    }

    private void CopyServiceProgressChannged(object? sender, ProgressChangedEventArgs e)
    {
        if (e.UserState is null) return;

        var userState = (BackupProcess)e.UserState;

        lblStatus.Text = userState.FileCopiedName;

        if (userState.FilesCopiedCount >= progressBar.Maximum)
            progressBar.Value = progressBar.Maximum;
        else
            progressBar.Value = userState.FilesCopiedCount;
    }
    #endregion

    #region HelperMethods
    private void ResetUi()
    {
        lblStatus.ForeColor = Color.Black;
        lblStatus.Text = string.Empty;
        progressBar.Value = 0;
    }

    private string GetSelectedBackup(string selectedBackup)
    {
        try
        {
            _selectedbackup = _database.GetBackup(selectedBackup);
            if (_selectedbackup is null)
            { return "Selected backup is not exist!"; }

            return string.Empty;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ex.Message;
        }
    }
    #endregion
}
