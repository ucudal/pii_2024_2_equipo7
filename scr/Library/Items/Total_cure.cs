namespace Project2;

public class Total_cure : BaseItem
{
    public Total_cure () : base()
    {
        this.Name = "Total Cure";
    }

    public override void Effect(IPokemon objetive)
    {
        objetive.PS = objetive.PSMax ;
    }
}

//Cura a un Pokémon de efectos de ataques especiales, dormido, paralizado, envenenado, o quemado.

