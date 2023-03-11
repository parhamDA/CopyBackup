using CopyBackup.Models;

using LiteDB;

namespace CopyBackup.Data;

public class Database
{
    private readonly ConnectionString _connectionString;
    public Database()
    {
        _connectionString = new ConnectionString
        {
            Filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db")
        };
    }

    public IEnumerable<string> GetSourcesName()
    {
        var sourceNames = new List<string>();
        
        using (var db = new LiteDatabase(_connectionString))
        {
            sourceNames.AddRange(
                db.GetCollection<SourceModel>("SourceGroup")
                .FindAll().OrderBy(x => x.Name).Select(g => g.Name));
        }

        return sourceNames;
    }

    public IEnumerable<string> GetDestinationsName()
    {
        var destinationNames = new List<string>();

        using (var db = new LiteDatabase(_connectionString))
        {
            destinationNames.AddRange(
                db.GetCollection<DestinationModel>("DestinationGroup")
                .FindAll().OrderBy(x => x.Name).Select(x => x.Name));
        }

        return destinationNames;
    }

    public IEnumerable<string> GetPlansName()
    {
        var planNames = new List<string>();
        
        using (var db = new LiteDatabase(_connectionString))
        {
            planNames.AddRange(db.GetCollection<CopyPlanModel>("PlansGroup")
                .FindAll().OrderBy(x=>x.PlanName).Select(x => x.PlanName));
        }

        return planNames;
    }

    public string GetSourcePath(string sourceName)
    {
        using var db = new LiteDatabase(_connectionString);
        return db.GetCollection<SourceModel>("SourceGroup").FindOne(x => x.Name == sourceName).Path;
    }

    public IEnumerable<string?> GetDestinationsPath(IEnumerable<string?> destinationsName)
    {
        var paths = new List<string?>();

        using var db = new LiteDatabase(_connectionString);
        paths.AddRange(db.GetCollection<DestinationModel>("DestinationGroup")
            .Query()
            .Where(x => destinationsName.Contains(x.Name))
            .Select(x => x.Path).ToList());

        return paths;
    }

    public IEnumerable<string> GetPlanDestinations(string planName)
    {
        var planDestinations = new List<string>();

        using var db = new LiteDatabase(_connectionString);
        planDestinations.AddRange(db.GetCollection<CopyPlanModel>("PlanGroup")
            .Query()
            .Where(x=> planName == x.PlanName)
            .Select(x=>x.PlanName).ToList());

        return planDestinations;
    }

    public void AddSource(SourceModel source)
    {
        using var db = new LiteDatabase(_connectionString);

        if (db.GetCollection<SourceModel>("SourceGroup").Exists(g => g.Name.ToLower() == source.Name.ToLower()))
            throw new Exception("Source name is already exist!");

        db.GetCollection<SourceModel>("SourceGroup").Insert(source);
    }

    public void AddDestination(DestinationModel destination)
    {
        using var db = new LiteDatabase(_connectionString);

        if (db.GetCollection<DestinationModel>("DestinationGroup")
            .Exists(g => g.Name.ToLower() == destination.Name.ToLower()))
            throw new Exception("Destination name is already exist!");

        db.GetCollection<DestinationModel>("DestinationGroup").Insert(destination);
    }

    public void AddCopyPlan(CopyPlanModel copyPlan)
    {
        using var db = new LiteDatabase(_connectionString);

        if(db.GetCollection<CopyPlanModel>("PlanGroup")
            .Exists(x=>x.PlanName.ToLower() == copyPlan.PlanName.ToLower()))
            throw new Exception("Copy Plane is already exist!");

        db.GetCollection<CopyPlanModel>("PlanGroup").Insert(copyPlan);
    }

    public void RemoveSource(string sourceName)
    {
        using var db = new LiteDatabase(_connectionString);
        var sourceId = db.GetCollection<SourceModel>("SourceGroup").FindOne(x => x.Name == sourceName).Id;
        db.GetCollection<SourceModel>("SourceGroup").Delete(sourceId);
    }

    public void RemoveDestination(string destinationName)
    {
        using var db = new LiteDatabase(_connectionString);
        var destinationId = db.GetCollection<DestinationModel>("DestinationGroup")
            .FindOne(x => x.Name == destinationName).Id;
        db.GetCollection<DestinationModel>("DestinationGroup").Delete(destinationId);
    }

    public void RemoveCopyPlan(string copyPlanName)
    {
        using var db = new LiteDatabase(_connectionString);
        var copyPlanId = db.GetCollection<CopyPlanModel>("PlanGroup")
            .FindOne(x=>x.PlanName == copyPlanName).Id;

        db.GetCollection<CopyPlanModel>("PlanGroup").Delete(copyPlanId);
    }
}
