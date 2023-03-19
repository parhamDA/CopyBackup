using CopyBackup.Models;

namespace CopyBackup.Forms;

public partial class FormRunBackup : Form
{
    private readonly BackupModel _backup;

    public FormRunBackup(BackupModel backup)
    {
        InitializeComponent();

        lblBackupName.Text = $"{backup.Name} backup is currently in process";

        _backup = backup;
    }

    private void FormRunBackup_FormClosing(object sender, FormClosingEventArgs e)
    {
        var messageBoxResult = MessageBox.Show("Are you sure you want to cancel the backup?",
            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        e.Cancel = (messageBoxResult == DialogResult.No);
    }

    private void BtnStopBackup_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FormRunBackup_Load(object sender, EventArgs e)
    {
        try
        {
            foreach (var destinationPath in _backup.Destinations.Select(x => x.Path).ToList())
            {
                if (Directory.Exists(destinationPath) == false)
                    continue;

                foreach (var source in _backup.Sources)
                {
                    if (source.IsFile == false)
                    {
                        if (Directory.Exists(source.Path) == false)
                            Directory.CreateDirectory(Path.Combine(destinationPath, Path.GetFileName(source.Path)));
                        
                        CopyDirectory(source.Path, destinationPath);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CopyDirectory(string sourcePath, string destinationPath)
    {
        foreach (var item in sourcePath)
        {
            
        }
    }
}
