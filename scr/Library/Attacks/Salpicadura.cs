using Library;

namespace Project2;

public class Salpicadura : IAttack
{
    public string Name => "Salpicadura";
    public TypeAttack TypeOfAttack => TypeAttack.Physical; // Asumiendo que tienes un enum para los tipos de ataque
    public Type Type => TypeTable.GetType("Agua"); // Obtener el tipo usando tu gestor de tipos
    public int Potency => 0;

    public int Accuracy => 100;

    public bool IsSpecial => false;
}
