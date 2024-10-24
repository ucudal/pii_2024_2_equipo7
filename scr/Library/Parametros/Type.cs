namespace Project2;

public class Type
{
    public string Name { get; set; }
    public Dictionary<string, double> Effectiveness { get; set; } 
    
    public Type(string nombre)
    {
        Name = nombre;
        Effectiveness = new Dictionary<string, double>();
    }
    
    public void AddEffectiveness(string tipo, double multiplicador) 
    {
        Effectiveness[tipo] = multiplicador; 
    }
}