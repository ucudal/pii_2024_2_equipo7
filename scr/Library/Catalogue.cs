namespace Library;

public class Catalogue
{
    private List<PokemonBase> catalogo_pokemons;
    public List<PokemonBase> Catalogo_pokemons { get; set; }

    public List<PokemonBase> AgregarCatalogo(PokemonBase a)
    { 
        Catalogo_pokemons.Add(a);
        return Catalogo_pokemons;
    }
    public Catalogue()
    {
            Catalogo_pokemons = new List<PokemonBase>();
    }
}
