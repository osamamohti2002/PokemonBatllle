using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace pokemonBattle
{
    using System.Collections.Concurrent;
    using System.Threading;
    using PokemonBattle.classes;

    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("Welcome to the Pokemon Battle simulator! ");

                // Trainer one 
                Console.WriteLine("Enter a name of Trainer 1 ");
                Trainer trainer1 = new Trainer(Console.ReadLine());
                
                // Trainer two
                Console.WriteLine("Enter a nmae of Trainer 2 ");
                Trainer trainer2 = new Trainer(Console.ReadLine());


                for (int i = 0; i < 2; i++)
                {
                    trainer1.belt.Add(new Pokeball(new Charmander()));
                    trainer1.belt.Add(new Pokeball(new Squirtle()));
                    trainer1.belt.Add(new Pokeball(new Bulbasaur()));

                    trainer2.belt.Add(new Pokeball(new Charmander()));
                    trainer2.belt.Add(new Pokeball(new Squirtle()));
                    trainer2.belt.Add(new Pokeball(new Bulbasaur()));
                }


                try
                {
                    for (int i = 0; i < 8; i++)
                {

                        // ipv if gebruik try and catch
                        //if (i < trainer1.belt.Count() && i < trainer2.belt.Count())
                        Pokemon pokemon = trainer1.Throwpokeball(i);
                        Pokemon pokemon2 = trainer2.Throwpokeball(i);

                        Console.WriteLine($"\nRound {i + 1}");
                        Console.WriteLine($"{trainer1.name} Throw his Pokeball");
                        Console.WriteLine("Pokeball opened");
                        Console.WriteLine(pokemon.battleCry());


                        Console.WriteLine($"{trainer2.name} Throw his Pokeball");
                        Console.WriteLine("Pokeball opened");
                        Console.WriteLine(pokemon2.battleCry());

                        Console.WriteLine(trainer1.returnPokemon(i, pokemon));
                        Console.WriteLine(trainer2.returnPokemon(i, pokemon2));
                        Thread.Sleep(500);
                    }





                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Je had alleen maar {trainer1.belt.Count()} rondes");
                }
                Console.WriteLine("Do you want to play agin? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                {
                    break;
                }


            }





        }
    }
}