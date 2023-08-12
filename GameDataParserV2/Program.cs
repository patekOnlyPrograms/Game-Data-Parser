

namespace GameDataParserV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var application = new Application();
            var logger = new Logger("log.txt");
            try
            {
                application.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry the application crashed unexpectedly " + "and will have to be closed");
                logger.Log(e);
            }

            Console.ReadKey();
        }
    }


}