namespace Project2;

public class Potion : BaseItem
{
    public Potion() : base()
    {
        this.Name = "potion";
    }

    public override void Effect(IPokemon objetive)
    {
        objetive.PS += 35;
    }
}