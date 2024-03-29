﻿using CopyBackup.Data;
using CopyBackup.Models;
using CopyBackup.Services;

namespace CopyBackup.Forms;

public partial class FormSetupBackup : Form
{
    private readonly Database _database = new();
    private readonly ApplicationSettings _applicationSettings = new();

    private readonly List<SourceModel> _sources = [];
    private readonly List<DestinationModel> _destinations = [];

    private readonly bool _isUpdate = false;
    private readonly int _editBackupId;

    public string? SavedBackupName { get; set; }


    public FormSetupBackup()
    {
        InitializeComponent();
        
        _database.ConnectionString = _applicationSettings.ConnectionString;
    }

    public FormSetupBackup(BackupModel backup)
    {
        InitializeComponent();

        _database.ConnectionString = _applicationSettings.ConnectionString;

        Text = "Edit Backup";

        _sources.AddRange(backup.Sources);
        listBoxSource.Items.AddRange(_sources.Select(x => x.Name).ToArray());

        _destinations.AddRange(backup.Destinations);
        listBoxDestination.Items.AddRange(_destinations.Select(x => x.Path).ToArray());

        tbBackupName.Text = backup.Name;
        _editBackupId = backup.Id;

        _isUpdate = true;
    }

    private void BtnAddFolder_Click(object sender, EventArgs e)
    {
        var folderDialog = folderBrowserDialog.ShowDialog();
        if (folderDialog != DialogResult.OK) return;

        var folderName = Path.GetFileName(folderBrowserDialog.SelectedPath);
        if (listBoxSource.Items.Contains(folderName))
            return;

        listBoxSource.Items.Add(folderName);

        _sources.Add(new SourceModel
        {
            Name = folderName,
            Path = folderBrowserDialog.SelectedPath,
            IsFile = false
        });
    }

    private void BtnAddFile_Click(object sender, EventArgs e)
    {
        var fileDialog = openFileDialog.ShowDialog();
        if (fileDialog != DialogResult.OK) return;

        foreach (var file in openFileDialog.FileNames)
        {
            var fileName = Path.GetFileName(file);

            if (listBoxSource.Items.Contains(fileName))
                continue;

            listBoxSource.Items.Add(fileName);
            _sources.Add(new SourceModel
            {
                Name = fileName,
                Path = file,
                IsFile = true
            });
        }
    }

    private void BtnDeleteSource_Click(object sender, EventArgs e)
    {
        if (listBoxSource.SelectedItem is null) return;

        _sources.RemoveAll(x => x.Name == listBoxSource.SelectedItem.ToString());
        listBoxSource.Items.RemoveAt(listBoxSource.SelectedIndex);
    }

    private void BtnAddDestination_Click(object sender, EventArgs e)
    {
        var folderDialog = folderBrowserDialog.ShowDialog();
        if (folderDialog != DialogResult.OK) return;

        var folderPath = folderBrowserDialog.SelectedPath;
        if (listBoxDestination.Items.Contains(folderPath))
            return;

        _destinations.Add(new DestinationModel
        {
            Path = folderBrowserDialog.SelectedPath,
        });

        listBoxDestination.Items.Add(folderPath);
    }

    private void BtnDeleteDestination_Click(object sender, EventArgs e)
    {
        if (listBoxDestination.SelectedItem is null) return;

        _destinations.RemoveAll(x => x.Path == listBoxDestination.SelectedItem.ToString());
        listBoxDestination.Items.RemoveAt(listBoxDestination.SelectedIndex);
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tbBackupName.Text))
        {
            MessageBox.Show("Please enter a name for the backup!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_sources.Count == 0 || _destinations.Count == 0)
        {
            MessageBox.Show("Source or Destination lists is empty!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            var backup = new BackupModel
            {
                Id = _editBackupId,
                Name = tbBackupName.Text,
                Sources = _sources,
                Destinations = _destinations,
            };

            if(_isUpdate) _database.UpdateBackup(backup);
            else _database.AddBackup(backup);

            SavedBackupName = backup.Name;
            
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
