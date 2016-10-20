namespace MyRestfulApi.Core.Helpers
{
    using System;
    using System.Configuration;

    public class ConfigurationManagerHelper : IConfigurationManagerHelper
    {
        public string GetAppSettings(string key)
        {
            try
            {
                var setting = ConfigurationManager.AppSettings[key];

                if (setting == null)
                    throw new Exception("Error at Server configuration");

                return setting;
            }
            catch (Exception ex)
            {

                throw new NullReferenceException("Server configuration missing = " + key, ex.InnerException);
            }

        }

    }
}
