namespace GameDataParserV2;
using Newtonsoft.Json;
public class Application
{
    public void Run()
    {
        bool isFileValid = false;
        bool fileRead = false;
        string fileName = null;
        string fileContents = null;
        do
        {
            Console.WriteLine("Enter the name of the file you want to read");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("The file name cannot be null");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("File name cannot be left empty");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                fileContents = File.ReadAllText(fileName);
                isFileValid = true;
            }
        } while (!isFileValid);

        List<gamesModel> GamesModels = null;
        try
        {
            GamesModels = JsonConvert.DeserializeObject<List<gamesModel>>(fileContents);
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine(fileContents);
            throw new JsonReaderException(
                $"JSON in the {fileName} was not in a valid format. {e.Message} JSON body:");
        }
            
            
        foreach (var item in GamesModels)
        {
            Console.WriteLine($"Title: {item.Title}, Released in {item.ReleaseYear}, Rating: {item.Rating}");
        }
    }
    
}