using CopyBackup.Data;
using CopyBackup.Forms;

namespace CopyBackup;

public partial class FormMain : Form
{
    private readonly Database _database = new();

    public FormMain()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        LoadBackupsName();
    }

    private void BtnAddBackup_Click(object sender, EventArgs e)
    {
        var frmCreateBackup = new FormCreateBackup();
        var frmCreateBackupDialogResult = frmCreateBackup.ShowDialog();
        if (frmCreateBackupDialogResult != DialogResult.OK) return;

        LoadBackupsName();
    }

    private void BtnDeleteBackup_Click(object sender, EventArgs e)
    {
        var selectedItem = listBoxBackups.SelectedItem.ToString();
        listBoxBackups.Items.RemoveAt(listBoxBackups.SelectedIndex);

        try
        {
            if (string.IsNullOrEmpty(selectedItem)) return;

            _database.DeleteBackup(selectedItem);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnEditBackup_Click(object sender, EventArgs e)
    {
        var frmCreateBackup = new FormCreateBackup();
        var frmCreateBackupDialogResult = frmCreateBackup.ShowDialog();
        if (frmCreateBackupDialogResult != DialogResult.OK) return;

        LoadBackupsName();
    }

    private void BtnRun_Click(object sender, EventArgs e)
    {
        var selectedBackup = listBoxBackups.SelectedItem.ToString();
        if (string.IsNullOrEmpty(selectedBackup))
        {
            lblStatus.Text = "Backup plan not selected to run!";
            return;
        }

        try
        {
            var backup = _database.GetBackup(selectedBackup);
            if (backup is null)
            {
                MessageBox.Show("Selected backup not founded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frmRunBackup = new FormRunBackup(backup);
            var frmRunBackupDialogResult = frmRunBackup.ShowDialog();
            if (frmRunBackupDialogResult == DialogResult.OK)
                lblStatus.Text = "Backup finished successfully";
            else lblStatus.Text = "There is an issue in backup process!";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadBackupsName()
    {
        try
        {
            listBoxBackups.Items.AddRange(_database.GetBackups().ToArray());
            lblStatus.Text = string.Empty;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
