using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gebe die erste Zahl ein
            Console.Write("gebe die erste Zahl ein : ");
            string line = Console.ReadLine();
            double a = Convert.ToDouble(line);

            // Gebe die zweite Zahl an
            Console.Write("gebe die zweite Zahl an : ");
            line = Console.ReadLine();
            double b = Convert.ToDouble(line);

            // Gebe einen Operator an 
            Console.Write("gebe einen Operator an : ");
            string op = Console.ReadLine().Trim();
            double ergebnis = 0.0;
            /*
            if(op == "+")
            {
                ergebnis = a + b;
            }
            else if(op == "-")
            {
                ergebnis = a - b;
            }
            else if(op == "/")
            {
                ergebnis = a / b;
            }
            else if(op == "*" || op == "x")
            {
                ergebnis = a * b; 
            }
            else if(op == "^")
            {
                ergebnis = Math.Pow(a, b);
            }
            else if(op == "v")
            {
                ergebnis = Math.Sqrt(a);
            }

            else 
            {
                Console.WriteLine("Ungültiger Operator! Operator muss '+', '-', '*' oder '/' sein");
                return;
            }
            */

            switch (op)      
            {
                case "+": ergebnis = a + b;
                    break;
                case "-": ergebnis = a - b;
                    break;
                case "*":
                case "x":
                    ergebnis = a * b;
                    break;
                case "/": ergebnis = a / b;
                    break;
                case "^": ergebnis = Math.Pow(a, b);
                    break;
                case "v": ergebnis = Math.Sqrt(a);
                    break;
                default: 
                {
                    Console.WriteLine("Ungültiger Operator! Operator muss '+', '-', '*' oder '/' sein");
                    return;
                }
            }

            Console.WriteLine("Ergebnis: " + ergebnis);
        }
    }
}
