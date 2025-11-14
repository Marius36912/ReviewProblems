using Avalonia;
using System;

namespace SentenceFromWords;
// Programmet læser inputs fra bruger og laver dem til en sætning
// Ai brugt som sparring, alt endelig kode er skrevet selv.
class Program
{

    [STAThread]
    public static void Main(string[] args)
    {
        // Starter med at definere string for sætningen
        string sentence = "";
        
        // læser ord med en while indtil brugeren skriver "stop"
        while (true)
        {
            Console.WriteLine("Tast et ord, eller stop for at afslutte");
            string word = Console.ReadLine()!;
            
            // hvis brugeren skriver stop, så stopper løkken
            if (word.ToLower() == "stop")
            {
                break;
            }
            
            // tilføjer ordet til sætningen med et mellem så det passer til at lave sætninger
            sentence += word + " ";
        }
        
        // printer hele sætningen
        Console.WriteLine("Sentence:");
        Console.WriteLine(sentence);
    }
}