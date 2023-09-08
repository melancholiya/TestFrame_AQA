using System.Text.Json;

namespace Test_Fram.TestModel
{
    public class ConfigReader
    {
        public static ConfigData ReadDataFromJson(string jsonFilePath)
        {
            ConfigData configData = null;

            try
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                configData = JsonSerializer.Deserialize<ConfigData>(jsonData);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Config file not found: {jsonFilePath}");

            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing JSON data: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            return configData;
        }
        public ConfigData ConfigData;
    }
}
