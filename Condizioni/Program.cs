using System;

namespace Condizioni
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Scrivi qualcosa: ");
            string s = Console.ReadLine();

            if (s == "primo")
                Console.WriteLine("Hai scritto PRIMO");
            else if (s == "secondo")
                Console.WriteLine("Hai scritto SECONDO");
            else
                Console.WriteLine($"Hai scritto {s}");

            switch(s){
                case "primo":
                    Console.WriteLine("PRIMO");
                    break;
                case "secondo":
                    Console.WriteLine("SECONDO");
                    break;
                default:
                    Console.WriteLine($"Hai scritto {s}");
                    break;
            }
            
        }
    }

}