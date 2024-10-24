namespace Project2;

public class Super_Potion : BaseItem
{
    public Super_Potion() : base()
    {
        this.Name = "Super potion";
    }

    public override void Effect(IPokemon objetive)
    {
        objetive.PS += 70;
    }
}