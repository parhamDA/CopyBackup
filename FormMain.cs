﻿using CopyBackup.Data;

namespace CopyBackup;

public partial class FormMain : Form
{
    private readonly Database _database = new();
    private string _currentPath = string.Empty;

    public FormMain()
    {
        InitializeComponent();
    }

    #region Events

    private void FormMain_Load(object sender, EventArgs e)
    {
        //ListBoxSource.Items.AddRange(_database.GetSourcesName().ToArray());
        //ListBoxDestination.Items.AddRange(_database.GetDestinationsName().ToArray());
    }

   private void ButtonRemoveSourceFolder_Click(object sender, EventArgs e)
    {
        //var selectedItem = ListBoxSource.SelectedItem.ToString();
        //ListBoxSource.Items.RemoveAt(ListBoxSource.SelectedIndex);

        //if (selectedItem == null) return;

        //_database.RemoveSource(selectedItem);
        //ListView.Items.Clear();
    }

    private void ButtonAddDestinationFolder_Click(object sender, EventArgs e)
    {
        //var folderDialog = FolderBrowserDialog.ShowDialog();
        //if (folderDialog != DialogResult.OK) return;

        //var frmGetName = new FormGetName();
        //var frmNameDialogResult = frmGetName.ShowDialog();
        //if (frmNameDialogResult != DialogResult.OK) return;

        //try
        //{
        //    ListBoxDestination.Items.Add(frmGetName.ItemName);
        //    _database.AddDestination(new DestinationModel
        //    {
        //        Name = frmGetName.ItemName,
        //        Path = FolderBrowserDialog.SelectedPath
        //    });
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
    }

    private void ButtonRemoveDestinationFolder_Click(object sender, EventArgs e)
    {
        //var selectedItem = ListBoxDestination.SelectedItem.ToString();
        //ListBoxDestination.Items.RemoveAt(ListBoxDestination.SelectedIndex);

        //if (selectedItem == null) return;

        //_database.RemoveDestination(selectedItem);
    }

    private void ButtonUp_Click(object sender, EventArgs e)
    {
        if (!Directory.Exists(_currentPath)) return;

        var directoryInfo = new DirectoryInfo(_currentPath).Parent;
        if (directoryInfo == null) return;

        ExtractSubDirectories(directoryInfo.FullName);
    }

    private void ButtonRunCopy_Click(object sender, EventArgs e)
    {
        //var sourceListPath = new List<string?>();
        //foreach (ListViewItem item in ListView.SelectedItems)
        //    sourceListPath.Add(item.Tag.ToString());

        //var destinationList = new List<string?>();

        //foreach (var item in ListBoxDestination.SelectedItems)
        //    destinationList.Add(item.ToString());

        //if (destinationList.Count == 0) return;

        //var destinationsPath = _database.GetDestinationsPath(destinationList);
        //try
        //{
        //    foreach (var sourcePath in sourceListPath)
        //    {
        //        foreach (var destinationPath in destinationsPath)
        //        {
        //            if (!Directory.Exists(destinationPath))
        //            {
        //                if (!string.IsNullOrEmpty(destinationPath)) Directory.CreateDirectory(destinationPath);
        //            }
        //            else
        //            {
        //                if (Directory.Exists(sourcePath))
        //                {
        //                    var destinationPathTemp = Path.Combine(destinationPath, Path.GetFileName(sourcePath));
        //                    if (!Directory.Exists(destinationPathTemp))
        //                        Directory.CreateDirectory(destinationPathTemp);

        //                    FileSystem.CopyDirectory(sourcePath, destinationPathTemp, UIOption.AllDialogs);
        //                }
        //                else if (File.Exists(sourcePath))
        //                {
        //                    FileSystem.CopyFile(
        //                        sourcePath,
        //                        Path.Combine(destinationPath, Path.GetFileName(sourcePath)),
        //                        UIOption.AllDialogs);
        //                }
        //            }
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
    }

    private void ListBoxSource_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (ListBoxSource.SelectedItem is null) return;

        //var selectedItem = ListBoxSource.SelectedItem.ToString();
        //if (selectedItem == null) return;

        //var sourcePath = _database.GetSourcePath(selectedItem);
        //if (string.IsNullOrEmpty(sourcePath)) return;

        //ExtractSubDirectories(sourcePath);
    }

    private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        //if (ListView.SelectedItems.Count != 1) return;

        //var selectedItemPath = ListView.SelectedItems[0].Tag.ToString();
        //if (string.IsNullOrEmpty(selectedItemPath)) return;

        //ExtractSubDirectories(selectedItemPath);
    }

    #endregion

    #region Private Methods

    private void ExtractSubDirectories(string path)
    {
        //if (!Directory.Exists(path)) return;

        //var directoryInfo = new DirectoryInfo(path);
        //ListView.Items.Clear();
        //try
        //{
        //    foreach (var directory in directoryInfo.GetDirectories())
        //    {
        //        ListView.Items.Add(new ListViewItem
        //        {
        //            Text = directory.Name,
        //            Tag = directory.FullName,
        //            ImageIndex = 2
        //        });
        //    }

        //    foreach (var file in directoryInfo.GetFiles())
        //    {
        //        ListView.Items.Add(new ListViewItem
        //        {
        //            Text = file.Name,
        //            Tag = file.FullName,
        //            ImageIndex = 1
        //        });
        //    }

        //    _currentPath = directoryInfo.FullName;
        //}
        //catch (Exception exception)
        //{
        //    MessageBox.Show(exception.Message);
        //}
    }

    #endregion

    private void BtnAddBackup_Click(object sender, EventArgs e)
    {
        var frmGetName = new FormGetName();
        var frmNameDialogResult = frmGetName.ShowDialog();
        if (frmNameDialogResult != DialogResult.OK) return;

        //try
        //{
        //    ListBoxSource.Items.Add(frmGetName.ItemName);
        //    _database.AddSource(new SourceModel
        //    {
        //        Name = frmGetName.ItemName,
        //        Path = FolderBrowserDialog.SelectedPath
        //    });
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
    }

    private void LoadBackups()
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
}
