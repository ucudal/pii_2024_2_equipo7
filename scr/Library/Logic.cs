using System.Reflection.PortableExecutable;

namespace Project2;

public class Logic
{
    private List<Action> posibleacciones = Action.InicializarAcciones();
    public Player Jugador1 { get; set; }
    public Player Jugador2 { get; set; }
    public int turno { get; set; }
    
    public Logic(Player p1, Player p2)
    {
        Jugador1 = p1;
        Jugador2 = p2;
        turno = 1;
    }

    public bool Endgame()
    {
        return (!Jugador1.EstaVivo() || !Jugador2.EstaVivo());
    }

    public void Iniciar()
    {
        Console.WriteLine($"¡Inicia la batalla entre {Jugador1.Name} y {Jugador2.Name}!");
        while (!Endgame())
        {
            RealizarTurno();
        }
        DeclararGanador();
    }

    public void RealizarTurno()
    {
        Console.WriteLine($"Turno:{turno}");
        PedirAccion(Jugador1);
        PedirAccion(Jugador2);
        
        
        
        if (Jugador1.AccionElegida.Priority > Jugador2.AccionElegida.Priority)
        {
            EjecutarAcciones(Jugador1,Jugador2);
        }
        else if (Jugador1.AccionElegida.Priority < Jugador2.AccionElegida.Priority)
        {
            EjecutarAcciones(Jugador2,Jugador1);
        }
        else
        {
            if (Jugador1.ActivePokemon.Vel > Jugador2.ActivePokemon.Vel)
            {
                EjecutarAcciones(Jugador1,Jugador2);
            }
            else
            {
                EjecutarAcciones(Jugador2,Jugador1);
            }
        }

        turno++;
    }

    public void PedirAccion(Player jugador) // Cambié el tipo de retorno a 'Action'
    {
        Console.WriteLine($"{jugador.Name}, elige tu acción: (1) Atacar (2) Cambiar Pokémon");
        int input = Convert.ToInt32(Console.ReadLine());

        // Aquí puedes definir las acciones con prioridad
        if (input == 1)
        {
            PreguntarPorAtaque(jugador);
            jugador.AccionElegida = posibleacciones[0]; // Agrega una acción de atacar
        }
        else if (input == 2)
        {
            PreguntarPorPokemon(jugador);
            jugador.AccionElegida = posibleacciones[1]; // Agrega una acción de cambiar Pokémon
        }
        else if (input == 3)
        {
            PreguntarPorObjeto(jugador);
            jugador.AccionElegida = posibleacciones[2];
        }
        else
        {
            throw new ArgumentOutOfRangeException("Acción inválida");
        }
    }

    public void EjecutarAcciones(Player primero, Player segundo)
    {
        if (primero.AccionElegida.Name == "Atacar")
        {
            primero.ActivePokemon.UsarAtaque(primero.AtaqueElegido,segundo.ActivePokemon);
        }
        else if (primero.AccionElegida.Name == "Cambiar")
        {
            primero.CambiarPokemon(primero.PokemonElegido);
        }
        else if (primero.AccionElegida.Name == "Usar Objeto")
        {
            primero.UsarObjeto(primero.ObjetoElegido, primero.PokemonElegido);
        }
        
        if (segundo.AccionElegida.Name == "Atacar")
        {
            segundo.ActivePokemon.UsarAtaque(segundo.AtaqueElegido,primero.ActivePokemon);
            Console.WriteLine($"{segundo.ActivePokemon.Name} realiza un ataque.");
        }
        else if (segundo.AccionElegida.Name == "Cambiar")
        {
            segundo.CambiarPokemon(segundo.PokemonElegido);
        }
        else if (segundo.AccionElegida.Name == "Usar Objeto")
        {
            segundo.UsarObjeto(segundo.ObjetoElegido, primero.PokemonElegido);
        }
    }

    private void PreguntarPorAtaque(Player jugador)
    {
        Console.WriteLine("Elige un ataque:");
        foreach (var variable in jugador.ActivePokemon.Attacks)
        {
            Console.WriteLine($"{variable.Key} - Nombre:{variable.Value.Name} - POT:{variable.Value.Potency} - ACC:{variable.Value.Accuracy}- Tipo:{variable.Value.TypeOfAttack}/{variable.Value.Accuracy} - EsEspecial{variable.Value.IsSpecial}");
        }
        jugador.AtaqueElegido = jugador.ActivePokemon.Attacks[Convert.ToInt32(Console.ReadLine())];
    }

    private void PreguntarPorPokemon(Player jugador)
    {
        Console.WriteLine("Elige un pokemon:");
        int index = 1;
        foreach (IPokemon variable in jugador.PokemonsList)
        {
            Console.WriteLine($"{index}-{variable.Name}");
            index++;
        }

        int eleccion = Convert.ToInt32(Console.ReadLine());
        jugador.PokemonElegido = jugador.PokemonsList[index - 1];
}
    
    private void PreguntarPorObjeto(Player jugador)
    {
        Console.WriteLine("Elige un pokemon:");
        int index = 1;
        foreach (IItem variable in jugador.ItemList)
        {
            Console.WriteLine($"{index}-{variable.Name}");
            index++;
        }

        int eleccion = Convert.ToInt32(Console.ReadLine());
        jugador.ObjetoElegido = jugador.ItemList[index - 1];
        PreguntarPorPokemon(jugador);
    }
    
    public void DeclararGanador()
    {
        if (Jugador1.EstaVivo())
        {
            Console.WriteLine($"{Jugador1.Name} ha ganado la batalla!");
        }
        else
        {
            Console.WriteLine($"{Jugador2.Name} ha ganado la batalla!");
        }
    }
}
