namespace Project2;

public class Revive : BaseItem
{
    public Revive() : base()
    {
        this.Name = "Revive";
    }

    public override void Effect(IPokemon objetive)
    {
        if (objetive.PS == 0)
        {
            objetive.PS = objetive.PSMax;
        }
        else throw new Exception("Este pokemon no esta debilitado");
    }
}

