using System.Text.Json;

namespace StudentStudyPlanner
{
    public class DataStorage
    {
        public void Save<T>(List<T> items, string fileName)
        {
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, json);
        }

        public List<T> Load<T>(string fileName)
        {
            if (!File.Exists(fileName))
                return new List<T>();

            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
    }
}
