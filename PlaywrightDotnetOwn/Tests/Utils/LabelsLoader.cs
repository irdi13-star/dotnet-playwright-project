using System.Text.Json;

namespace Tests.Utils;

public static class LabelsLoader
{
    public static LabelsAndStrings Load(string path)
    {
        var fullPath = Path.Combine(AppContext.BaseDirectory, path);
        var json = File.ReadAllText(fullPath);
        return JsonSerializer.Deserialize<LabelsAndStrings>(json)!;
    }
}
