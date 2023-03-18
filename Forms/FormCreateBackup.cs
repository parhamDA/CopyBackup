using CopyBackup.Data;
using CopyBackup.Models;

namespace CopyBackup.Forms;

public partial class FormCreateBackup : Form
{
    private readonly Database _database = new();

    private readonly List<SourceModel> _sources = new();
    private readonly List<DestinationModel> _destinations = new();

    public FormCreateBackup()
    {
        InitializeComponent();
    }

    public FormCreateBackup(BackupModel backup)
    {
        InitializeComponent();

        _sources.AddRange(backup.Sources);
        listBoxSource.Items.AddRange(_sources.Select(x => x.Name).ToArray());

        _destinations.AddRange(backup.Destinations);
        listBoxDestination.Items.AddRange(_destinations.Select(x => x.Name).ToArray());

        tbBackupName.Text = backup.Name;
    }

    private void BtnAddSource_Click(object sender, EventArgs e)
    {
        var folderDialog = folderBrowserDialog.ShowDialog();
        if (folderDialog != DialogResult.OK) return;

        _sources.Add(new SourceModel
        {
            Name = Path.GetFileNameWithoutExtension(folderBrowserDialog.SelectedPath),
            Path = folderBrowserDialog.SelectedPath,
        });
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

        _destinations.Add(new DestinationModel
        {
            Name = Path.GetFileNameWithoutExtension(folderBrowserDialog.SelectedPath),
            Path = folderBrowserDialog.SelectedPath,
        });
    }

    private void BtnDeleteDestination_Click(object sender, EventArgs e)
    {
        if (listBoxDestination.SelectedItem is null) return;

        _destinations.RemoveAll(x => x.Name == listBoxDestination.SelectedItem.ToString());
        listBoxSource.Items.RemoveAt(listBoxDestination.SelectedIndex);
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
            _database.AddBackup(new BackupModel
            {
                Name = tbBackupName.Text,
                Sources = _sources,
                Destinations = _destinations
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
