public static class Starup
{
    public static IConfigurationBuilder Configuration()
    {
        var configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile($"appsettings.json");

        //var config = configuration.Build();
        return configuration;
    }
}