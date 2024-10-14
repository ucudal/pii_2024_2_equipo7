using System.Security.Cryptography.X509Certificates;

namespace Library;

public class Magikarp : PokemonBase
{
    public Magikarp()
    {
        this.Name = "Magikarp";
        this.Lvl = 100;
        this.PSMax = 244;
        this.PS = PSMax;
        this.Atk = 130;
        this.Def = 229;
        this.SpAtk = 141;
        this.SpDef = 152;
        this.Vel = 284;
        this.Attacks = new Dictionary<int, IAttack>()
        {
            { 1, new Salpicadura() }, // Agregar ataque Salpicadura
            { 2, new Placaje() } // Agregar otro ataque
        };
    }
}



