namespace Library;

public static class TypeTable
{
    private static List<Type> types = new List<Type>();

    static TypeTable()
    {
        InicializarTipos();
    }

    private static void InicializarTipos()
    {
        var fuego = new Type("Fuego");
        fuego.AddEffectiveness("Planta", 2.0);
        fuego.AddEffectiveness("Agua", 0.5);
        fuego.AddEffectiveness("Fuego", 1.0);
        fuego.AddEffectiveness("Volador", 1.0);
        fuego.AddEffectiveness("Roca", 0.5);
        fuego.AddEffectiveness("Electrico", 1.0);
        types.Add(fuego);

        var agua = new Type("Agua");
        agua.AddEffectiveness("Fuego", 2.0);
        agua.AddEffectiveness("Planta", 0.5);
        agua.AddEffectiveness("Agua", 1.0);
        agua.AddEffectiveness("Volador", 1.0);
        agua.AddEffectiveness("Roca", 2.0);
        agua.AddEffectiveness("Electrico", 1.0);
        types.Add(agua);
        
        var planta = new Type("Planta");
        planta.AddEffectiveness("Planta", 1.0);
        planta.AddEffectiveness("Agua", 2.0);
        planta.AddEffectiveness("Fuego", 0.5);
        planta.AddEffectiveness("Volador", 0.5);
        planta.AddEffectiveness("Roca", 2.0);
        planta.AddEffectiveness("Electrico", 1.0);
        types.Add(planta);
        
        var volador = new Type("Volador");
        volador.AddEffectiveness("Planta", 2.0);
        volador.AddEffectiveness("Agua", 1.0);
        volador.AddEffectiveness("Fuego", 1.0);
        volador.AddEffectiveness("Volador", 1.0);
        volador.AddEffectiveness("Roca", 0.5);
        volador.AddEffectiveness("Electrico", 0.5);
        types.Add(volador);
        
        var electrico = new Type("Electrico");
        electrico.AddEffectiveness("Planta", 0.5);
        electrico.AddEffectiveness("Agua", 2.0);
        electrico.AddEffectiveness("Fuego", 1.0);
        electrico.AddEffectiveness("Volador",2.0);
        electrico.AddEffectiveness("Roca",0.0);
        electrico.AddEffectiveness("Electrico",0.5);
        types.Add(electrico);
        
        var roca = new Type("Roca");
        roca.AddEffectiveness("Planta", 1.0);
        roca.AddEffectiveness("Agua", 1.0);
        roca.AddEffectiveness("Fuego", 2.0);
        roca.AddEffectiveness("Volador",2.0);
        roca.AddEffectiveness("Roca",1.0);
        roca.AddEffectiveness("Electrico",1.0);
        types.Add(roca);
    }

    public static Type GetType(string name)
    {
        foreach (Type VARIABLE in types)
        {
            if (VARIABLE.Name == name) 
            { 
                return VARIABLE;
            }
        }
        return null;
    }

    public static double GetEffectiveness(Type tipoAtaque, List<Type> tipoDefensor)
    {
        double multiplicator = 0;
        foreach (Type VARIABLE in tipoDefensor)
        {
            if (tipoAtaque.Effectiveness.ContainsKey(VARIABLE.Name))
            {
                multiplicator += tipoAtaque.Effectiveness[VARIABLE.Name];
            }
            else multiplicator += 1;

            ;
        }

        return multiplicator;
    }

}