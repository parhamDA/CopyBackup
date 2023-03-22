﻿using CopyBackup.Data;
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

    private readonly CopyService _copyService = new();
    private readonly Database _database = new();
    private BackupModel _selectedbackup = new();

    public FormMain()
    {
        InitializeComponent();
        _copyBackgroudWorker = new BackgroundWorker();
        _copyBackgroudWorker.DoWork += new DoWorkEventHandler(RunCopyService);
        _copyBackgroudWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CopyServiceFinished);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        try
        {
            listBoxBackups.Items.AddRange(_database.GetBackups().ToArray());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnAddBackup_Click(object sender, EventArgs e)
    {
        ResetUi();

        var frmSetupBackup = new FormSetupBackup();
        var frmSetupBackupDialogResult = frmSetupBackup.ShowDialog();
        if (frmSetupBackupDialogResult != DialogResult.OK) return;

        listBoxBackups.Items.Add(frmSetupBackup.SavedBackupName!);
        listBoxBackups.SelectedItem = frmSetupBackup.SavedBackupName!;
    }

    private void BtnDeleteBackup_Click(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null ||
            string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
            return;

        ResetUi();

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
        if (frmSetupBackupDialogResult != DialogResult.OK) return;

        var savedBackupName = frmSetupBackup.SavedBackupName;
        var listBoxItemIndex = listBoxBackups.Items.IndexOf(_selectedbackup.Name);

        if (_selectedbackup.Name != savedBackupName)
            listBoxBackups.Items[listBoxItemIndex] = savedBackupName!;
        else
            listBoxBackups.Items[listBoxItemIndex] = _selectedbackup.Name;
    }

    private void ListBoxBackups_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null ||
            string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
            return;

        ResetUi();

        try
        {
            _selectedbackup = _database.GetBackup(listBoxBackups.SelectedItem.ToString()!);
            if (_selectedbackup is null)
            {
                MessageBox.Show("Selected backup not founded!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void BtnRun_Click(object sender, EventArgs e)
    {
        if (listBoxBackups.SelectedItem is null ||
            string.IsNullOrEmpty(listBoxBackups.SelectedItem.ToString()))
            return;

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

    private void RunCopyService(object? sender, DoWorkEventArgs e)
    {
        try
        {
            var destinationsPath = _selectedbackup.Destinations.Select(x => x.Path).ToList();
            var lastDestination = destinationsPath.Last();

            _copyService.FileCopiedName = string.Empty;
            _copyService.FilesCopiedCount = 0;
            _copyService.RemoveArchiveAttribute = false;

            foreach (var destinationPath in destinationsPath)
            {
                if (destinationPath == lastDestination)
                    _copyService.RemoveArchiveAttribute = true;

                if (Directory.Exists(destinationPath) == false)
                    continue;

                foreach (var source in _selectedbackup.Sources)
                {
                    if (source.IsFile == false && Directory.Exists(source.Path) == true)
                    {
                        _copyService.CopyDirectory(source.Path, destinationPath);
                    }
                    else
                    {
                        _copyService.CopyFile(source.Path, destinationPath);
                    }

                    e.Result = new BackupProcess
                    {
                        FilesCopiedCount = _copyService.FilesCopiedCount,
                        FileCopiedName = _copyService.FileCopiedName
                    };
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CopyServiceFinished(object? sender, RunWorkerCompletedEventArgs e)
    {
        if (e.Result is null) return;

        if (e.Result is BackupProcess result)
        {
            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = result?.FileCopiedName;

            progressBar.Value = result!.FilesCopiedCount;
        }

        if(progressBar.Value == progressBar.Maximum)
        {
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = $"[{_selectedbackup.Name}] backup is finished successfully . . .";
            toolStrip.Enabled = true;
            listBoxBackups.Enabled = true;
        }
    }

    private void ResetUi()
    {
        lblStatus.ForeColor = Color.Black;
        lblStatus.Text = string.Empty;
        progressBar.Value = 0;
    }
}
