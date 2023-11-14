// IL METODO SOMMA

using System;

namespace Metodi{
    public class Program{

        static void Main(string[] args){
            int z = Program.Somma(10, 5);
            Console.WriteLine(z);
        }

        static int Somma ( int x, int y){
            // s è una variabile locale, il suo utlizzio è limitato al metodo Somma
            int s = x + y;
            return s;
        }

    }   

}
