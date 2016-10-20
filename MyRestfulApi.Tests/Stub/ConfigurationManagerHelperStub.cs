namespace MyRestfulApi.Tests.Stub
{
    using Core.Helpers;

    public class ConfigurationManagerHelperStub : IConfigurationManagerHelper
    {
        public string GetAppSettings(string key)
        {
            var path = "url";
            return path;
        }
    }
}
