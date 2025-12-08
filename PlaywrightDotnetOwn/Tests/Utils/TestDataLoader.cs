using System.Text.Json;

namespace Tests.Utils;

public static class TestDataLoader
{
    public static T LoadJson<T>(string relativePath)
    {
        var fullPath = Path.Combine(AppContext.BaseDirectory, relativePath);

        var json = File.ReadAllText(fullPath);
        return JsonSerializer.Deserialize<T>(json)!;
    }
}
