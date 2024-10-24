using System.Runtime.CompilerServices;

namespace Project2;

public class Player
{
    private string name;
    public string Name { get; set; }
    
    public Dictionary<int, IAttack> AtkList
    {
        get { return this.ActivePokemon.Attacks; } 
        set { }
    }
    
    private List<IPokemon> pokemonsList = new List<IPokemon>();
    public List<IPokemon> PokemonsList { get; set; }
    
    private List<IItem> itemList;
    public List<IItem> ItemList { get; set; }
    
    private IPokemon activePokemon;
    public IPokemon ActivePokemon { get; set; }

    public double PokemonHealth {
        get { return this.ActivePokemon.PS; } 
        set { }
    }

    private IAttack ataqueElegido;
    public IAttack AtaqueElegido { get; set; }
    
    private Action accionElegida;
    public Action AccionElegida { get; set; }
    
    private IItem objetoElegido;
    public IItem ObjetoElegido { get; set; }
    
    private IPokemon pokemonElegido;
    public IPokemon PokemonElegido { get; set; }
    

    public void CambiarPokemon(IPokemon pokemon)        //hay que poner que tenga que tener vida y alguna excepcion
    {
        if (this.pokemonsList.Contains(pokemon))
        {
            this.ActivePokemon = pokemon;
        }
    }

    public bool EstaVivo()
    {
        int pokemonMuerto = 0;
        foreach (IPokemon VARIABLE in pokemonsList)
        {
            if (VARIABLE.PS == 0)
            {
                pokemonMuerto += 1;
            }

            if (pokemonMuerto == 6)
            {
                return false;
            }
        }

        return true;
    }

    public void UsarObjeto(IItem item, IPokemon pokemon)
    {
        if (pokemon == this.ActivePokemon)
        {
            item.Effect(this.ActivePokemon);
        }
        else
        {
            item.Effect(pokemon);
        }
        this.ItemList.Remove(item);
    }

    public Player(string nombre)
    {
        Name = nombre;
        PokemonsList = new List<IPokemon>();
        this.ItemList = new List<IItem>()
        {
            { new Super_Potion() }, // Agregar ataque Salpicadura
            { new Revive() } // Agregar otro ataque
        };
    }
//Turno=
}
