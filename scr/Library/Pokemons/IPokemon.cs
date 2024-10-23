namespace Project2;

public interface IPokemon
{
     string Name { get;  set;}
     List<Type> Types { get;  set;}
     int Lvl { get;  set;}
     double PSMax { get;  set;}
     double PS { get; set; }
     int Atk { get;  set;}
     int Def { get;  set;}
     int SpDef { get;  set;}
     int SpAtk { get;  set;}
     int Vel { get;  set;}
     Dictionary<int, IAttack> Attacks { get; set; }


     void UsarAtaque(IAttack attack, IPokemon pokemon);

     void RecibirDaño(double Damage);

     //double DamageCalculator(IAttack attack, PokemonBase pokemon);

}
    