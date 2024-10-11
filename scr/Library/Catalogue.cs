namespace Library;

public class Catalogue
{
    private List<IPokemon> catalogo_pokemons;
    public List<IPokemon> Catalogo_pokemons { get; set; }

    public List<IPokemon> AgregarCatalogo(IPokemon a)
    { 
        Catalogo_pokemons.Add(a);
        return Catalogo_pokemons;
    }
    public Catalogue()
    {
            Catalogo_pokemons = new List<IPokemon>();
    }
}
