using NClass.Core;
using NClass.CSharp;
using System.IO;

namespace NClass.GUI;

// This class allows you to handle specific events on the settings class:
//  The SettingChanging event is raised before a setting's value is changed.
//  The PropertyChanged event is raised after a setting's value is changed.
//  The SettingsLoaded event is raised after the setting values are loaded.
//  The SettingsSaving event is raised before the setting values are saved.
public sealed partial class Settings {
        
    public Settings() {
        // // To add event handlers for saving and changing settings, uncomment the lines below:
        //
        // this.SettingChanging += this.SettingChangingEventHandler;
        //
        // this.SettingsSaving += this.SettingsSavingEventHandler;
        //
    }
        
    private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
        // Add code to handle the SettingChangingEvent event here.
    }
        
    private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
        // Add code to handle the SettingsSaving event here.
    }

    private const int MaxRecentFileCount = 5;

    public Language GetDefaultLanguage()
    {
        Language defaultLanguage = LanguageManager.Instance.GetLanguage(DefaultLanguageName);

        return defaultLanguage ?? CSharpLanguage.Instance;
    }

    public void AddRecentFile(string recentFile)
    {
        if (!File.Exists(recentFile))
            return;

        int index = RecentFiles.IndexOf(recentFile);

        if (index < 0)
        {
            if (RecentFiles.Count < MaxRecentFileCount)
                RecentFiles.Add(string.Empty);

            for (int i = RecentFiles.Count - 2; i >= 0; i--)
                RecentFiles[i + 1] = RecentFiles[i];
            RecentFiles[0] = recentFile;
        }
        else if (index > 0)
        {
            string temp = RecentFiles[index];
            for (int i = index; i > 0; i--)
                RecentFiles[i] = RecentFiles[i - 1];
            RecentFiles[0] = temp;
        }
    }

}