using System.Configuration;

namespace MochaMemoirs.Model
{
    internal class ChangeLanguage
    {
        public void UpdateConfig(string key, string value)
        {
            // Open the configuration file
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Check if the key exists and update its value
            if (config.AppSettings.Settings[key] != null)
            {
                config.AppSettings.Settings[key].Value = value;
            }
            else
            {
                // If the key does not exist, add it
                config.AppSettings.Settings.Add(key, value);
            }

            // Save the changes and refresh the section
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
