using System.Configuration;

namespace CF.Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string configName = ConfigurationManager.AppSettings["configName"];
            System.Console.WriteLine("Config: " + configName);
            System.Console.ReadLine();
        }
    }
}
