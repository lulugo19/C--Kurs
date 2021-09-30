class PokemonArt
{
    // Eigenschaften
    public string Name { get; set; }
    public string Typ { get; set; }

    public int Index { get; set; }

    // Konstruktor
    public PokemonArt(string name, string typ, int index)
    {
        Name = name;
        Typ = typ;
        Index = index;
    }
}