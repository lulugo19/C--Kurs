using System;

namespace Zahlen
{
  class Program
  {
    static void Main(string[] args)
    {
        string aZeichenfolge = Console.ReadLine();
        double a = Convert.ToDouble(aZeichenfolge);

        string bZeichenfolge = Console.ReadLine();
        double b = Convert.ToDouble(bZeichenfolge);

        double summe = a + b;
        double differenz = a - b;
        double produkt = a * b;
        double quotient = a / b;
        double wurzel = Math.Sqrt(a);
        double produktQuadrat = Math.Pow(a, 23);

        Console.WriteLine("Summe: " + summe);
        Console.WriteLine("Differenz: " + differenz);
        Console.WriteLine("Produkt: " + produkt);
        Console.WriteLine("Quotient: " + quotient);
        Console.WriteLine("Quadratwurzel: " + wurzel);
        Console.WriteLine("23^23: " + produktQuadrat);

        // 88223
        // 8 Zehntausender + 8 Tausender + 2 Hunderter + 2 Zehner + 3 Einer
        // 8 * 10.000 + 8 * 1000 + 2 * 100 + 2 * 10 + 3
        // 8 * 10^4 + 8 * 10^3 + 2 * 10^2 + 2 * 10^1 + 3 * 10^0

        // 10101 =
        // 1 * Sechzehner + 0 * Achter + 1 * Vierer + 0 * Zweier + 1 * Einser
        // 1 * 16 + 0 * 8 + 1 * 4 + 0 * 2 + 1 * Einser
        // 1 * 2^4 + 0 * 2^3 + 1 * 2^2 + 0 * 2^1 + 1 * 2^0
        // 21
        int hex = 0xA1;
        Console.WriteLine(hex); // 161

        // 101 -> 5
        // 100 -> 4

        //  101
        //+ 100
        //-----
        //  1001  -> 9 
    }
  }
}
