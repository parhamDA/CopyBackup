using CopyBackup.Models;

namespace CopyBackup.Forms;

public partial class FormRunBackup : Form
{
    private readonly BackupModel _backup;
    private int _sourceFilesCount = 0;
    private int _filesCopiedCount = 0;
    private bool _isBackupFinished = false;
    private bool _isLastDestination = false;

    public FormRunBackup(BackupModel backup)
    {
        InitializeComponent();

        lblBackupName.Text = $"{backup.Name} backup is currently in process";

        _backup = backup;
        btnStopBackup.Text = "Stop Backup";
    }

    private void FormRunBackup_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_isBackupFinished == false)
        {
            var messageBoxResult = MessageBox.Show("Are you sure you want to cancel the backup?",
            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            e.Cancel = (messageBoxResult == DialogResult.No);
        }
    }

    private void BtnStopBackup_Click(object sender, EventArgs e)
    {
        DialogResult = _isBackupFinished == false ? DialogResult.No : DialogResult.Yes;
    }

    private void FormRunBackup_Shown(object sender, EventArgs e)
    {
        // A trick from StackOverFlow site, to completely display UI before execute the rest if codes.
        Refresh();

        lblCopyingFile.Text = "Processing Backup ...";
        _sourceFilesCount = CountSourceFiles(_backup.Sources);

        var destinationsPath = _backup.Destinations.Select(x => x.Path).ToList();
        var lastDestination = destinationsPath.Last();

        // progressBar.Maximum means count all sources files in all destinations path.
        _sourceFilesCount *= destinationsPath.Count;
        progressBar.Maximum = _sourceFilesCount;

        foreach (var destinationPath in destinationsPath)
        {
            if (destinationPath == lastDestination)
                _isLastDestination = true;

            if (Directory.Exists(destinationPath) == false)
                continue;

            foreach (var source in _backup.Sources)
            {
                if (source.IsFile == false && Directory.Exists(source.Path) == true)
                {
                    CopyDirectory(source.Path, destinationPath);
                }
                else
                {
                    CopyFile(source.Path, destinationPath);
                }
            }
        }

        if(_sourceFilesCount == 0)
            lblCopyingFile.Text = "No archive files to backup";
        else lblCopyingFile.Text = "Backup is finished";

        _isBackupFinished = true;
        btnStopBackup.Text = "Close Backup";
    }

    private void CopyDirectory(string sourcePath, string destinationPath)
    {
        var sourceDirectoryInDestinationPath = Path.Combine(destinationPath, Path.GetFileName(sourcePath));

        try
        {
            if (Directory.Exists(sourceDirectoryInDestinationPath) == false)
                Directory.CreateDirectory(sourceDirectoryInDestinationPath);

            var directory = new DirectoryInfo(sourcePath);

            foreach (var file in directory.GetFiles())
            {
                if (file.Attributes.HasFlag(FileAttributes.Archive))
                {
                    progressBar.Value = ++_filesCopiedCount;
                    lblPercentage.Text = $"{Math.Round((double)(100 * _filesCopiedCount) / _sourceFilesCount)}%";
                    lblCopyingFile.Text = file.FullName;

                    file.CopyTo(Path.Combine(sourceDirectoryInDestinationPath, file.Name), true);

                    if (_isLastDestination)
                        File.SetAttributes(file.FullName, file.Attributes & ~FileAttributes.Archive);
                }
            }

            foreach (var subDirectory in directory.GetDirectories())
            {
                CopyDirectory(subDirectory.FullName, destinationPath);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CopyFile(string sourcePath, string destinationPath)
    {
        try
        {
            var attributes = File.GetAttributes(sourcePath);
            if (attributes.HasFlag(FileAttributes.Archive))
            {
                progressBar.Value = ++_filesCopiedCount;
                lblPercentage.Text = $"{Math.Round((double)(100 * _filesCopiedCount) / _sourceFilesCount)}%";
                lblCopyingFile.Text = sourcePath;

                File.Copy(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)), true);

                if (_isLastDestination)
                    File.SetAttributes(sourcePath, attributes & ~FileAttributes.Archive);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private int CountSourceFiles(List<SourceModel> sources)
    {
        var filesCount = 0;

        foreach (var item in sources)
        {
            if (item.IsFile)
            {
                if (File.GetAttributes(item.Path).HasFlag(FileAttributes.Archive))
                    filesCount++;
            }
            else filesCount += CountDirectoryFile(item.Path, 0);
        }

        return filesCount;
    }

    private int CountDirectoryFile(string path, int count)
    {
        var directoryFilesCount = count;

        if (Directory.Exists(path))
        {
            directoryFilesCount +=
                (from file in Directory.GetFiles(path)
                 where File.GetAttributes(file).HasFlag(FileAttributes.Archive)
                 select file).Count();

            foreach (var dir in Directory.GetDirectories(path))
                CountDirectoryFile(dir, directoryFilesCount);
        }

        return directoryFilesCount;
    }
}
