namespace Library;

public class Placaje : IAttack
{
    public string Name => "Placaje";
    public TypeAttack TypeOfAttack => TypeAttack.Physical; // Asumiendo que tienes un enum para los tipos de ataque
    public Type Type => TypeTable.GetType("Normal"); // Obtener el tipo usando tu gestor de tipos
    public int Potency => 35;

    public int Accuracy => 95;

    public bool IsSpecial => false;
}