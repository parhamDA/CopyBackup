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
        using var db = new LiteDatabase(_connectionString);
        return db.GetCollection<BackupModel>("‌BackupPlans")
            .FindAll()
            .OrderBy(x => x.Name)
            .Select(x => x.Name);
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
            throw new Exception("Source name is already exist!");

        db.GetCollection<BackupModel>("SourceGroup").Insert(backup);
    }

    public void UpdateBackup(BackupModel editedBackup)
    {
        using var db = new LiteDatabase(_connectionString);

        var backups = db.GetCollection<BackupModel>("BackupPlans");
        var backup = backups.FindOne(x => x.Name == editedBackup.Name)
            ?? throw new Exception($"Backup {editedBackup.Name} not founded!");

        backup.Name = editedBackup.Name;
        backup.Sources = editedBackup.Sources;
        backup.Destinations = editedBackup.Destinations;

        backups.Update(backup);
    }

    public void RemoveBackup(string backupName)
    {
        using var db = new LiteDatabase(_connectionString);
        var BackupId = db.GetCollection<BackupModel>("BackupPlans")
            .FindOne(x => x.Name == backupName).Id;

        if (BackupId <= 0)
            throw new Exception($"Backup {backupName} not founded!");

        db.GetCollection<BackupModel>("BackupPlans").Delete(BackupId);
    }
}
