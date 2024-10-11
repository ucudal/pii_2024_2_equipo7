namespace Library;

public static class Calculate
{
    public static double DamageCalculator(IPokemon atacante, IAttack attack, IPokemon pokemon)
    {
        double stab;
        if (atacante.Types.Contains(attack.Type))
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
        double effectiveness = TypeTable.GetEffectiveness(attack.Type, pokemon.Types);
        double totaldaño;
        double dañostats;

        if (attack.TypeOfAttack == TypeAttack.Physical)
        {
            dañostats = (((0.2 * atacante.Lvl + 1) * atacante.Atk * pot) / (25 * pokemon.Def)) + 2;
            totaldaño = (0.01 * stab * (effectiveness) * variacion * dañostats);
        }
        else
        {
            dañostats = (((0.2 * atacante.Lvl + 1) * atacante.SpAtk * pot) / (25 * pokemon.SpDef)) + 2;
            totaldaño = (0.01 * stab * (effectiveness) * variacion * dañostats);
        }

        return totaldaño;
    }
}