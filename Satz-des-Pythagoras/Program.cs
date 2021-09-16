using System;

namespace Satz_des_Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            |* 
          a |  *   c
            | .  *
            -------*
                b  
            a² + b² = c²
            c = Wurzel(a²+b²)
            */

            /*
            EVA-Prinzip

            1. Eingabe
            2. Verarbeitung
            3. Ausgabe
            */

            // Eingabe
            Console.WriteLine("Satz des Pythagoras\n");
            Console.Write("Gebe die Länge der ersten Seite a an: ");
            double a = ZahlenEingabe();

            Console.Write("Gebe die Länge der zweiten Seite b an: ");
            double b = ZahlenEingabe();

            // Verarbeitung
            double c = Math.Sqrt( a*a + b*b );

            // Ausgabe
            Console.WriteLine($"Wurzel({a}²+{b}²) = {c}");
        }

        // liest ein Zahl von der Konsole ein
        static double ZahlenEingabe()
        {
            string eingabe = Console.ReadLine();
            double zahl = Convert.ToDouble(eingabe);
            return zahl;

        }


    }
}
