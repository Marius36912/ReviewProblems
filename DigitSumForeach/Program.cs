using Avalonia;
using System;

namespace DigitSumForeach;
// Programmet læser input som tekst og lægger sammen. 
// Ai er brugt kun som sparring, alt kode er lavet selv

class Program
{

    [STAThread]
    public static void Main(string[] args)
    {
        // Spørg burger om helt tal med console writeline
        Console.WriteLine("tast en integer");
        // laver string 
        string input = Console.ReadLine()!;
        
        int sum = 0;
        
        // laver en foreach for hver input i stringen
        foreach (char c in input)
        {
            // Laver input om til en string og til heltal
            int digit = int.Parse(c.ToString());
            // herefter lægges det sammen
            sum += digit;
        }
        
        // printer resultat
        Console.WriteLine(sum);

    }
}