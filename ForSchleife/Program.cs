using System;

namespace ForSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe: Stelle die For-Schleife so ein, dass sie die 
            // folgenden Zahlenfolge erzeugt

            /*
            1: 1 2 3 4 5 6 7 8 9
            2: 2 5 8 11 14
            3: 1 2 4 8 16
            4: 20 18 16 14
            5: 200 100 50 25
            6: 1 2 4 7 11 16 22 
            */
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine();

            for (int i = 2; i <=14; i = i + 3)
            {
                Console.WriteLine(i);
            }

             Console.WriteLine();

            for (int i = 1; i <=16; i = i * 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 20; i >=14; i = i - 2) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 200; i >=25; i = i /2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            int y = 0;
            for(int i = 1; i <= 22; i = i +y)
            {
                y = y + 1;
                Console.WriteLine(i);
            }
           
        }
    }
}
