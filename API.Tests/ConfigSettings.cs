using System.Text.Json;

namespace API.Tests
{
    public class ConfigSettings
    {
        public required string BaseUrl { get; set; }
        public required string AuthUrl { get; set; }
        public required string ClientId { get; set; }
        public required string ClientSecret { get; set; }

        public static ConfigSettings LoadConfig(string path = "appsettings.json")
        {
            var configJson = File.ReadAllText(path);
            return JsonSerializer.Deserialize<ConfigSettings>(configJson);
        }
    }
}
