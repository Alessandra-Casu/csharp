using System;

public class Program{
    public static void Main(){
        int temperatura = 20;

        // if ( temperatura > 25){
        //     Console.WriteLine("Fa caldo!");
        // } else if {
        //     Console.WriteLine("Fa freddo!");
        // } else {
        //     Console.WriteLine("Si sta bene!");
        // }

        Console.WriteLine((temperatura > 25) ? "Fa caldo!" : "Si sta bene!");

        // Statement Switch
        int myVar = 20;
        switch(myVar) {
            case 10:
                Console.WriteLine("Valore 10");
                break;
            case 20:
                Console.WriteLine("Valore 20");
                break;
            // case 10:
            // case 20:
            //     Console.WriteLine("Valore 10 o 20");
            //     break;
            case 30:
                Console.WriteLine("Valore 30");
                break;
            default:
                Console.WriteLine("Un altro valore");
                break;
        }
    }
}
