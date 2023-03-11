namespace CopyBackup.Models;

public class CopyPlanModel
{
    public int Id { get; set; }
    public string PlanName { get; set; } = string.Empty;
    public List<DestinationModel> Destinations { get; set; } = new List<DestinationModel>();
}
