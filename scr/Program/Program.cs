using System;
using System.Numerics;
using Project2;

namespace Project2;
public class Program
{
    static void Main()
    {
        Player j1 = new Player("pepe");
        Player j2 = new Player("juan");

        Magikarp m1 = new Magikarp();

        j1.PokemonsList.Add(m1);
        j2.PokemonsList.Add(m1);
        j1.ActivePokemon = m1;
        j2.ActivePokemon = m1;

        Logic logic = new Logic(j1, j2);
        logic.Iniciar();
    }
}