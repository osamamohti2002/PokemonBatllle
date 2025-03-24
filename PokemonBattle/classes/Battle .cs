using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Battle
    {
        public Trainer trainer1;
        public Trainer trainer2;


        

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }


        public void StartBattle()
        {

            for (int i = 0; i < 2; i++)
            {


                trainer1.belt.Add(new Pokeball(new Charmander()));
                trainer1.belt.Add(new Pokeball(new Squirtle()));
                trainer1.belt.Add(new Pokeball(new Bulbasaur()));
                

                trainer2.belt.Add(new Pokeball(new Charmander()));
                trainer2.belt.Add(new Pokeball(new Squirtle()));
                trainer2.belt.Add(new Pokeball(new Bulbasaur()));
            }

            

            while (trainer1.belt.Count > 0 && trainer2.belt.Count > 0)
            {

                try
                {
                    for (int i = 0; i < 6; i++)
                    {

                        // ipv if gebruik try and catch
                        //if (i < trainer1.belt.Count() && i < trainer2.belt.Count())

                        Pokeball pokeball1 = getRandomPokeball(trainer1);
                        Pokeball pokeball2 = getRandomPokeball(trainer2);

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

            }
        }

        public  Pokeball getRandomPokeball(Trainer trainer)
        {
            Random random = new Random();
            return trainer.belt[random.Next(trainer.belt.Count)];
        }

        public int DetermineWinner(Pokemon pokemon1,  Pokemon pokemon2)
        {
            if ((pokemon1.strength == "fire" && pokemon2.weakness == "fire") ||
                (pokemon1.strength == "grass" && pokemon2.weakness == "grass") ||
                (pokemon1.strength == "water" && pokemon2.weakness == "water"))
            {
                return 1; // trainer 1 wint
            }
            else if ((pokemon2.strength == "fire" && pokemon1.weakness == "fire") ||
                     (pokemon2.strength == "grass" && pokemon1.weakness == "grass") ||
                     (pokemon2.strength == "water" && pokemon1.weakness == "water"))
            {
                return -1; // treainer 2 wint
            }
            return 0; // gelijkspel
        }



    }


}
