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
            Filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CopyBackupDatabase.db")
        };
    }

    public IEnumerable<string> GetBackups()
    {
        var backups = new List<string>();

        using (var db = new LiteDatabase(_connectionString))
        {
            backups.AddRange(
                db.GetCollection<BackupModel>("BackupPlans")
                .FindAll()
                .OrderBy(x => x.Name)
                .Select(x => x.Name));
        }

        return backups;
    }

    public BackupModel GetBackup(string backupName)
    {
        using var db = new LiteDatabase(_connectionString);
        return db.GetCollection<BackupModel>("BackupPlans")
            .FindOne(x => x.Name == backupName);
    }

    public void AddBackup(BackupModel backup)
    {
        using var db = new LiteDatabase(_connectionString);
        if (db.GetCollection<BackupModel>("BackupPlans").Exists(x => x.Name.ToLower() == backup.Name.ToLower()))
            throw new Exception("Backup name is already exist!");

        db.GetCollection<BackupModel>("BackupPlans").Insert(backup);
    }

    public void UpdateBackup(BackupModel editedBackup)
    {
        using var db = new LiteDatabase(_connectionString);

        var backups = db.GetCollection<BackupModel>("BackupPlans");
        var backup = backups.FindOne(x => x.Name == editedBackup.Name)
            ?? throw new Exception($"Backup {editedBackup.Name} not founded!");

        if(backup.Name.ToLower() != editedBackup.Name.ToLower())
            if(backups.FindOne(x=>x.Name.ToLower() == editedBackup.Name.ToLower()) is not null)
                throw new Exception("Back name is already exist!");

        backup.Name = editedBackup.Name;
        backup.Sources = editedBackup.Sources;
        backup.Destinations = editedBackup.Destinations;

        backups.Update(backup);
    }

    public void DeleteBackup(string backupName)
    {
        using var db = new LiteDatabase(_connectionString);
        var BackupId = db.GetCollection<BackupModel>("BackupPlans")
            .FindOne(x => x.Name == backupName).Id;

        if (BackupId <= 0)
            throw new Exception($"Backup {backupName} not founded!");

        db.GetCollection<BackupModel>("BackupPlans").Delete(BackupId);
    }
}
