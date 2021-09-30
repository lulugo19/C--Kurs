using System;

class Pokemon
{
    // Eigenschaften
    public PokemonArt Art { get; set; }
    public string Name { get; set; }

    public int LP { get; set; }
    public int Defense { get; set; }

    public Attacke[] Attacken { get; set; }

    // Konstruktor
    public Pokemon(PokemonArt art, string name)
    {
        Art = art;
        Name = name;
        LP = 100;
        Defense = 50;
    }

    public Pokemon(PokemonArt art)
    {
        Art = art;
        Name = art.Name;
        LP = 100;
        Defense = 50;
    }

    // Methode
    public void ErlerneNeueAttacke(Attacke attacke)
    {
        if (Attacken.Length == 4)
        {
            Console.WriteLine(Name + " hat schon 4 Attacken. Es muss erst eine Attacke verlernt werden!");
        }
        else
        {
            FügeNeueAttackeHinzu(attacke);
            Console.WriteLine(Name + " hat die Attacke " + attacke.Name + " gelernt!");
        }
    }

    private void FügeNeueAttackeHinzu(Attacke attacke)
    {
        Attacke[] erweiterteAttacken = new Attacke[Attacken.Length + 1];
        // Kopiere die alten Attacken in die erweiterten Attacken
        for (int i = 0; i < Attacken.Length; i++)
        {
            erweiterteAttacken[i] = Attacken[i];
        }

    }
}