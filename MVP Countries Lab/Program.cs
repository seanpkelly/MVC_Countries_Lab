
using System;

namespace MVP_Countries_Lab
{
   public class Program
    {
        static void Main(string[] args)
        {
            CountryController c = new CountryController();
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome to the Countries App");
                Console.WriteLine("Press any key to continue.");
                Console.WriteLine();
                Console.ReadKey();
                c.WelcomeAction();
            }
            

            
        }
    }
}
