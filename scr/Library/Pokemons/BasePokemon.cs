using Library;

namespace Project2;

public class PokemonBase: IPokemon
{
    private string name;
    private List<Type> types;
    private int lvl;
    private double psmax;
    private double ps;
    private int atk;
    private int def;
    private int spatk;
    private int spdef;
    private int vel;
    private Dictionary<int, IAttack> attacks;

    public string Name { get; set; }
    public List<Type> Types { get; set; }
    public int Lvl { get; set; }
    public double PSMax { get; set; }
    public double PS { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int SpDef { get; set; }
    public int SpAtk { get; set; }
    public int Vel { get; set; }
    public Dictionary<int, IAttack> Attacks { get; set; }


    public void UsarAtaque(IAttack attack, IPokemon objetive)
    {
        objetive.RecibirDaño(DamageCalculator(attack, objetive));
    }

    public void RecibirDaño(double Damage)
    {
        if (this.PS > Damage)
        {
            this.PS -= Damage;
        }
        else
        {
            this.PS = 0;
        }

    }

    private double DamageCalculator(IAttack attack, IPokemon objective)
    {
        double stab;
        if (this.Types.Contains(attack.Type))
        {
            stab = 1.5;
        }
        else
        {
            stab = 1;
        }

        Random rnd = new Random();
        int variacion = rnd.Next(85, 100);
        int pot = attack.Potency;
        double effectiveness = TypeTable.GetEffectiveness(attack.Type, objective.Types);
        double totaldaño;
        double dañostats;

        if (attack.TypeOfAttack == TypeAttack.Fisico)
        {
            dañostats = (((0.2 * this.Lvl + 1) * this.Atk * pot) / (25 * objective.Def)) + 2;
            totaldaño = (0.01 * stab * (effectiveness) * variacion * dañostats);
        }
        else
        {
            dañostats = (((0.2 * this.Lvl + 1) * this.SpAtk * pot) / (25 * objective.SpDef)) + 2;
            totaldaño = (0.01 * stab * (effectiveness) * variacion * dañostats);
        }

        return totaldaño;
    }
}