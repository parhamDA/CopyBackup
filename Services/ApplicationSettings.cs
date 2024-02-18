using System.Configuration;

namespace CopyBackup.Services;

internal class ApplicationSettings : ApplicationSettingsBase
{
    [UserScopedSetting()]
    public string ConnectionString
    {
        get
        {
            var connectionString = this[nameof(ConnectionString)];
            if (connectionString is null || string.IsNullOrEmpty(connectionString.ToString()))
                return string.Empty;

            return connectionString.ToString()!;
        }
        set
        {
            this[nameof(ConnectionString)] = value;
        }
    }
}
