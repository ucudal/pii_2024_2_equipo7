namespace Project2;

public class Revive : BaseItem
{
    public Revive() : base()
    {
        this.Name = "Revive";
    }

    public override void Effect(IPokemon objetive)
    {
        objetive.PS = objetive.PSMax / 2;
    }
}

