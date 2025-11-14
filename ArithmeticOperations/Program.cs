using Avalonia;
using System;

namespace ArithmeticOperations;
// Aritmetiske operationer på to integers
// Programmet spørger bruger om to integers, der tastes og der udføres kalkulationer.
// Brugt AI til feedback og sparring med endelig kode. Alt kode er skrevet selv og eget ansvar.

class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        // Spørger bruger om første integer
        Console.WriteLine("Tast første Integer");
        // Program læser input fra console. Bruger strong og converter til int
        int a = int.Parse(Console.ReadLine()!);
        
        // spørger bruger for second integer
        Console.WriteLine("Enter second integer");
        // Converter igen fra input til int med int, parse og console readlin
        int b = int.Parse(Console.ReadLine()!);
        
        // printer resultater med console writeline
        Console.WriteLine("Resultat:");
        
        // KALKULATIONS DEL!
        
        // Kalkulation
        
        // Sum
        Console.WriteLine(a + b);
        
        // produkt
        Console.WriteLine(a * b);
        
        // difference
        Console.WriteLine(a - b);
        
        // division
        Console.WriteLine(a / b);
        
        // procenter
        Console.WriteLine(a % b);
    }
    
}

