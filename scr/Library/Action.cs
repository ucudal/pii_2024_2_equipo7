namespace Library;

using System;
using System.Collections.Generic;

public class Action
{
    private Action(string name, int priority)
    {
        this.name = name;
        this.priority = priority;
    }
    
    private string name;
    private int priority;
    public static List<Action> InicializarAcciones()
    {
        return new List<Action>
        {
            new Action("Atacar", 1),
            new Action("Cambiar", 2),
        };
    }
    public string Name
    {
        get {return name;}
    }
    
    public int Priority
    {
        get {return priority;}
    }
}
