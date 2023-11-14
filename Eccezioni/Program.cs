using System;

namespace Eccezioni
{
    class Program
    {
        static void Main(string[] args){

            int numero = 0;
            Console.Write("inserisci un numero: ");
            string s = Console.ReadLine();
            try {
                numero = Convert.ToInt32(s);
                
            }
            catch (Exception e) {
                Console.WriteLine("Non hai scritto un numero!");
                numero = -1;
            }
            finally {
                Console.WriteLine("Hai scritto: {0}", numero);
            }
            
            
        }
    }
}
