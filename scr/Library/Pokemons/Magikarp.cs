using System.Security.Cryptography.X509Certificates;

namespace Library;

public class Magikarp : IPokemon
{
    public Magikarp()
    {
        this.name = "Magikarp";
        this.lvl = 100;
        this.psmax = 244;
        this.ps = psmax;
        this.atk = 130;
        this.def = 229;
        this.spatk = 141;
        this.spdef = 152;
        this.vel = 284;
        this.attacks = new Dictionary<int, IAttack>()
        {
            { 1, new Salpicadura() }, // Agregar ataque Salpicadura
            { 2, new Placaje() }       // Agregar otro ataque
        };
    }
    
    public void UsarAtaque(IAttack attack, IPokemon pokemon)
    {
        pokemon.RecibirDaño(Calculate.DamageCalculator(this,attack, pokemon));
        
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
    private Dictionary<int,IAttack> attacks;
    
    public string Name
    {
        get { return name; }
    }

    public double PSMax
    {
        get { return psmax; }
    }
    public double PS
    {
        get { return ps; }
        set { ps = value; }
    }
    public int Lvl
    {
        get { return lvl; }
    }
    public int Atk
    {
        get { return atk; }
    }
    public int Def
    {
        get { return def; }
    }
    public int SpAtk
    {
        get { return spatk; }
    }
    public int SpDef
    {
        get { return spdef; }
    }
    public int Vel
    {
        get { return vel; }
    }

    public List<Type> Types
    {
        get { return types;}
    }

    public Dictionary<int,IAttack> Attacks
    {
        get { return attacks; }
    }
}

