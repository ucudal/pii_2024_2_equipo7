namespace Library;

public class Player
{
    private string name;
    public string Name { get; set; }
    
    private Dictionary<int, IAttack> atkList;
    public Dictionary<int, IAttack> AtkList { get; set; }
    
    private List<IPokemon> pokemonsList;
    public List<IPokemon> PokemonsList { get; set; }
    
    private IPokemon activePokemon;
    public IPokemon ActivePokemon { get; set; }
    
    private double pokemonHealth;
    public double PokemonHealth { get; set; }
    
    private IAttack ataqueElegido;
    public IAttack AtaqueElegido { get; set; }
    
    private Action accionElegida;
    public Action AccionElegida { get; set; }
    

    public void CambiarPokemon(string nombre)
    {
        foreach (IPokemon VARIABLE in pokemonsList)
        {
            if (VARIABLE.Name == nombre)
            {
                activePokemon = VARIABLE;
            }
            else
            {
                Console.WriteLine("No tienes ese pokemon");
            }
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
    
    

    public Player(string nombre)
    {
        Name = nombre;
        PokemonsList = new List<IPokemon>();
        ActivePokemon = null;
        PokemonHealth = ActivePokemon.PS;
        AtkList = ActivePokemon.Attacks;
        //Turno=
    }
}