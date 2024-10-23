namespace Project2;

public abstract class BaseItem : IItem
{
    private string name;
    public string Name { get; set; }

    public abstract void Effect(IPokemon objetive);
}