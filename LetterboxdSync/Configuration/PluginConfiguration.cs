using System.Collections.Generic;
using MediaBrowser.Model.Plugins;

namespace LetterboxdSync.Configuration;

public class PluginConfiguration : BasePluginConfiguration
{
    public List<Account> Accounts { get; set; } = new List<Account>();
    
    public string UserAgent { get; set; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
}
