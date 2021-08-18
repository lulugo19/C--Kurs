using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings (Zeichenfolgen)
            string name = "Lukas";
            string emoji = "🥃";

            // Characters (Zeichen)
            char zeichen = 'a';

            // Bool (Wahrheitswert, entweder 'true' oder 'false')
            bool wahr = true;
            bool falsch = false;
            
            // Ganzzahlen (Integers)
            int zahl = 12; // 32 Bit -> -2.147.483.648 bis +2.147.483.674
            long zahlDoppelteGenauigkeit = 42; // 64 Bit -> -9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807

            // Kommazahlen
            float kommaZahl = 12.1234567f; // 32 Bit (speichert bis zu 7 Stellen hinterm Komma)
            double kommaZahlDoppelteGenauigkeit = 24.123456789123456; // 64 Bit (speichert bis zu 16 Stellen hinterm Komma)
        }
    }
}
