namespace Project2;

public interface IAttack
{
    string Name { get; }
    TypeAttack TypeOfAttack { get; }
    Type Type { get; }
    int Potency { get; }
    int Accuracy { get; }
    bool IsSpecial { get; }
}