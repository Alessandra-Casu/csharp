using System;

namespace Fattoriale
{

    class Program
    {
        static void Main(string[] args)
        {     
            Console.Write("Inserisci un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Il fattoriale di {n} è il {Fattoriale(n)}");
        }

        static int Fattoriale(int n)
        {
            //caso base
            if ( n == 0)
                return 1;
            return n * Fattoriale(n - 1);
        }
    }
    
}