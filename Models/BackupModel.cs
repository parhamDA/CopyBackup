namespace CopyBackup.Models;

public class BackupModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<string> Sources { get; set; } = new List<string>();
    public List<string> Destinations { get; set; } = new List<string>();
}
