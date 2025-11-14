using Avalonia;
using System;

namespace DecisionBasedOnBooleans;
// Programmet spørgeer om 3 spørgsmål som kan besvares med ja eller nej og giver anbefaling
// Ai er brugt kun til sparring, endelig kode er skrevet selv.
class Program
{

    [STAThread]
    public static void Main(string[] args)
    {
        // writeline spg om emne?
        Console.WriteLine("Is the lecture topic interesting? Answer criteria: (yes/no)");
        string s1 = Console.ReadLine()!.ToLower();
        
        // spørg om ven kommer
        Console.WriteLine("Will a friend join you? Answer criteria: (yes/no)");
        string s2 = Console.ReadLine()!.ToLower();
        
        // spørg om ven kommer
        Console.WriteLine("Spørg om du har problemer med opgaven. Answer criteria: (yes/no)");
        string s3 = Console.ReadLine()!.ToLower();
        
        // laver svarene om til booleans (for at kunne boolean logic)
        
        bool interesting = (s1 == "yes");
        bool friend = (s2 == "yes");
        bool problems = (s3 == "yes");
        
        // bruger if else med en betingelse (boollean logic),
        // med && som "og" og de 2 streger for min "or" kommando

        if (interesting && (friend || problems))
        {
            Console.WriteLine("Recommendation: Go to the lecture.");
        }
        else
        {
            Console.WriteLine("Recommendation: Stay home");
        }
    }
}