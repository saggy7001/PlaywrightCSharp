﻿using System.Text.Json;

namespace PlaywrightCSharp
{
    public class ConfigSettings
    {
        public required string BaseUrl { get; set; }
        public required string Browser { get; set; }
        public bool Headless { get; set; }

        public static ConfigSettings LoadConfig(string path = "appsettings.json")
        {
            var configJson = File.ReadAllText(path);
            return JsonSerializer.Deserialize<ConfigSettings>(configJson);
        }
    }
}
