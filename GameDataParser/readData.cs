using Newtonsoft.Json;
namespace GameDataParser;

public class readData
{
    public static string readJson(string path)
    {
        string data;
        FileStream fRead = new FileStream(path, FileMode.Open, FileAccess.Read);
        using (StreamReader sr = new StreamReader(fRead))
        {
            data = sr.ReadToEnd();
        }
        return data;
    }

    public static void printFormattedJson(string path)
    {
        string jsonString = readJson(path);
        
        List<gamesModel> gamesModels = JsonConvert.DeserializeObject<List<gamesModel>>(jsonString);
        foreach (var item in gamesModels)
        {
            Console.WriteLine($"Title: {item.Title}, Released in {item.ReleaseYear}, Rating: {item.Rating}");
        }
    }
}