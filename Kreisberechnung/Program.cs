using System;

namespace Kreisberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kreisberechnung\n");
            Console.Write("Gebe den Radius ein: ");
            string eingabe = Console.ReadLine().Trim();
            double radius = Convert.ToDouble(eingabe);
            double fläche = Math.PI * radius * radius;
            double umfang = Math.PI * 2 * radius;
            Console.WriteLine("Fläche: " + fläche);
            Console.WriteLine("Umfang: " + umfang);
        }
    }
}