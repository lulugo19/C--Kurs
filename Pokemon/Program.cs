using System;

class Program
{
    static void Main(string[] args)
    {
        // 0 2 4 6 8
        for (int i = 0; i <= 8; i = i + 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Pokemon!");
        ErstellePokemon();
    }

    static void ErstellePokemon()
    {
        PokemonArt karpador = new PokemonArt("Karpador", "Wasser", 129);
        Pokemon karpi = new Pokemon(karpador, "Ulli");

        Attacke platscher = new Attacke("Platscher", 0);
        Attacke tackle = new Attacke("Tackle", 20);

        Attacke[] attacken = new Attacke[1] { platscher };
        karpi.Attacken = attacken;

        karpi.ErlerneNeueAttacke(tackle);
    }
}