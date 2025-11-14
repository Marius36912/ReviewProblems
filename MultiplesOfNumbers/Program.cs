using Avalonia;
using System;

namespace MultiplesOfNumbers;
// Programmet tjekker en dividend og diviser, om det er multiplum
// Ai brugt som sparring feedback, ALT endelig kode skrevet selv
class Program
{

    [STAThread]
    public static void Main(string[] args)
    {
       // Spørger brugeren om det første devidend med console writeline
       Console.WriteLine("Tast dividend");
       // laver en double for tal a
       double a = double.Parse(Console.ReadLine()!);
       Console.WriteLine("Tast divisor");
       // laver en double for tal b
       double b = double.Parse(Console.ReadLine()!);
       
       // laver if else og spørgger om multiples
       if (a % b == 0)
       {
            Console.WriteLine("Det er multiples");  
       }
       else
       {
           Console.WriteLine("Det er ikke MultiplesOfNumbers");
       }

    }
}