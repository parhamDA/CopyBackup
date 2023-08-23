namespace CopyBackup.Models;

public class BackupModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<SourceModel> Sources { get; set; } = new List<SourceModel>();
    public List<DestinationModel> Destinations { get; set; } = new List<DestinationModel>();
}
