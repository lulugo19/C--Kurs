using System;

namespace Methoden
{
    class Program
    {
        // Main-Methode, die die Hauptfunktion des Programms ist und ganz
        // am Anfang gestartet wird
        static void Main(string[] args)
        {
            // Ein Array: ["hallo", "welt"]
            string wort = args[0];
            string sprache = args[1];
            //Console.WriteLine(erstesArgument);
            string ausgabe = "";
            if (wort == "hallo") 
            {
                switch (sprache)
                {
                    case "englisch": ausgabe = "Hello";
                        break;
                    case "franz": ausgabe = "Salut";
                        break;
                    case "spanisch": ausgabe = "Ola";
                        break;
                    case "japanisch": ausgabe = "Kon'nichiwa";
                        break;
                    default:
                        break;
                }
            }
            else if (wort == "tschüss")
            {
                switch (sprache)
                {
                    case "englisch": ausgabe = "Bye";
                        break;
                    case "franz": ausgabe = "Salut";
                        break;
                    case "spanisch": ausgabe = "Adios";
                        break;
                    case "japanisch": ausgabe = "Sayounara";
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Ungültiger Parameter.\nBitte lesen Sie sich die Bedienungsanleitung durch...");
            }
            Console.WriteLine(ausgabe);
            /*
            MyConsole.SchreibeZeile("Hello World!");
            Console.Write("Gebe eine Zahl ein: ");
            double zahl = MyConsole.ReadNumber();
            Console.WriteLine("Das Quadrat der Zahl ist: " + zahl * zahl);
            double zahl1 = MyConsole.ReadNumber();
            */

            /*
            double summe = Rechnen.Addieren(zahl, zahl1);
            double differenz = Rechnen.Subtrahieren(zahl, zahl1);
            double produkt = Rechnen.Multiplizieren(zahl, zahl1);
            double produkt3 = Rechnen.Multiplizieren(zahl, zahl1, zahl);
            */
        }
    }
}
