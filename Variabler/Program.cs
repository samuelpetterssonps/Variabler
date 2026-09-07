using System;

namespace Variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖVNING 2
            // int tal1 = 8;
            // int tal2 = 5;
            // int summa = tal1 + tal2;
            //
            // Console.Out.WriteLine($"Variabeln tal1 har värdet: {tal1}");
            // Console.Out.WriteLine($"Variabeln tal2 har värdet: {tal2}");
            // Console.Out.WriteLine($"Summan av tal1 och tal2: {summa}");
            //
            // int differens = tal1 - tal2;
            //
            // Console.Out.WriteLine($"{tal1} - {tal2} = {differens}");

            // ÖVNING 3

            string namn = "Samuel";
            string titel = "Elev";
            string email = "samuel@gmail.se";
            string telefonnummer = "071-234 56 78";

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n" + new String(' ', 30));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"    Hej, jag är {namn}!" + new String(' ', 30 - $"    Hej, jag är {namn}!".Length));
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("    Titel: ");

            Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine($"{titel}" + new String(' ', 30 - $"    Titel: {titel}".Length));
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"    Telefon: {telefonnummer}" + new String(' ', 30 - $"    Telefon: {telefonnummer}".Length));
            Console.WriteLine($"    {email}" + new String(' ', 30 - $"    {email}".Length));
            Console.WriteLine(new String(' ', 30));


            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
