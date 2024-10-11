namespace Library;

public interface IPokemon
{
    string Name { get; }
    List<Type> Types { get; }
    int Lvl { get; }
    double PSMax { get; }
    double PS { get; set; }
    int Atk { get; }
    int Def { get; }
    int SpDef { get; }
    int SpAtk { get; }
    int Vel { get; }
    Dictionary<int,IAttack> Attacks { get; }
    

    void UsarAtaque(IAttack attack, IPokemon pokemon);
    void RecibirDaño(double damage);
}