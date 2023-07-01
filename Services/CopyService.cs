using CopyBackup.Models;

using System.Security.AccessControl;

namespace CopyBackup.Services;

internal class CopyService
{
    public BackupModel Backup { get; set; } = new BackupModel();
    public string FileCopiedName { get; set; } = string.Empty;
    public int FilesCopiedCount { get; set; }
    public bool RemoveArchiveAttribute { get; set; } = false;

    

    public int SourceFilesCount()
    {
        // Total count is all source files for each destination path.
        var totalCount = CountSourceFiles(Backup.Sources);
        totalCount *= Backup.Destinations.Count;

        return totalCount;
    }

    public void CopyDirectory(string sourcePath, string destinationPath)
    {
        var sourceDirectoryInDestinationPath = Path.Combine(destinationPath, Path.GetFileName(sourcePath));

        if (Directory.Exists(sourceDirectoryInDestinationPath) == false)
            Directory.CreateDirectory(sourceDirectoryInDestinationPath);

        var directory = new DirectoryInfo(sourcePath);

        foreach (var file in directory.GetFiles())
        {
            if (file.Attributes.HasFlag(FileAttributes.Archive))
            {
                file.CopyTo(Path.Combine(sourceDirectoryInDestinationPath, file.Name), true);
                FileCopiedName = file.FullName;

                if (RemoveArchiveAttribute)
                    File.SetAttributes(file.FullName, file.Attributes & ~FileAttributes.Archive);

                FilesCopiedCount++;
            }
        }

        foreach (var subDirectory in directory.GetDirectories())
        {
            //destinationPath = directory.FullName;
            CopyDirectory(subDirectory.FullName, sourceDirectoryInDestinationPath);
        }
    }

    public void CopyFile(string sourcePath, string destinationPath)
    {
        var attributes = File.GetAttributes(sourcePath);
        if (attributes.HasFlag(FileAttributes.Archive))
        {
            File.Copy(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)), true);
            FileCopiedName = sourcePath;

            if (RemoveArchiveAttribute)
                File.SetAttributes(sourcePath, attributes & ~FileAttributes.Archive);

            FilesCopiedCount++;
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

    
    private int _directoryFilesCount = 0;
    private int CountDirectoryFile(string path, int count)
    {
        _directoryFilesCount = count;

        if (Directory.Exists(path))
        {
            _directoryFilesCount +=
                (from file in Directory.GetFiles(path)
                 where File.GetAttributes(file).HasFlag(FileAttributes.Archive)
                 select file).Count();

            foreach (var dir in Directory.GetDirectories(path))
                CountDirectoryFile(dir, _directoryFilesCount);
        }

        return _directoryFilesCount;
    }
}
