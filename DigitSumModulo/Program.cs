using Avalonia;
using System;

namespace DigitSumModulo;
// Programmet læser heltal og lægger input sammen med modulo
// Ai kun brugt som sparring, alt endelig kode er skrevet slev.

class Program
{

    [STAThread]
    public static void Main(string[] args)
    {
        // Beder bruger om et heltal. (lidt ligeosm opgaven før bare med while. Bruger en)
    Console.WriteLine("Tast en integer (HELTAL)");
    int number = int.Parse(Console.ReadLine()!);
    
    // her gemmes summen af input
    int sum = 0;
    
    // Bruger et while loop, kører så længe input ikke er tomt eller 0
    while (number > 0)
    {
        // tager sidste inpput med modulo 10
        int digit = number % 10;
        
        // summer
        sum += digit;
        
        // fjerner input ved heltals division som angivet.
        number = number / 10;
    }
    // printer resultat
    Console.WriteLine("Sum:" + sum);

    }
}