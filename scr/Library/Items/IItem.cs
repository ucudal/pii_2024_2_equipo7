namespace Project2;

public interface IItem
{
    string Name { get; set; }
    void Effect(IPokemon objetive);
}