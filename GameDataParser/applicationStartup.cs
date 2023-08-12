namespace GameDataParser;

public class applicationStartup
{
    public void userInput()
    {
        while (true)
        {
            Console.WriteLine("Enter the name of the file you want to read: ");
            string fileName = Console.ReadLine();
            readData.printFormattedJson(fileName);
        }
        
    }
}

