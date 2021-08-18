using System;

namespace Zeichenfolgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hallo, wie heißt du: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hallo " + name + "!");
    
            Console.WriteLine("Registriere dich!");
            Console.Write("Gebe ein Passwort an: ");
            string passwort = Console.ReadLine();
    
            Console.WriteLine("Logge dich ein!");
            Console.Write("Passwort: ");
            string eingegebenesPasswort = Console.ReadLine();

            if (passwort == eingegebenesPasswort) 
            {
                Console.WriteLine("Erfolgreich eingeloggt!");
            }
            else 
            {
                Console.WriteLine("Passwort falsch!");
            }
        }
    }
}
