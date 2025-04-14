using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Battle
    {
        private Trainer trainer1;
        private Trainer trainer2;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public void startBattle()
        {
            try
            {
                int roudns = 6;
                for (int i = 0; i < roudns && trainer1.belt.Count > 0 && trainer2.belt.Count > 0; i++)
                {

                    // shrinks te ontweikken onderzoeken 
                    Pokeball pokeball1 = trainer1.belt[0];
                    Pokeball pokeball2 = trainer2.belt[0];

                    trainer1.Throwpokeball(pokeball1);
                    trainer2.Throwpokeball(pokeball2);
                        
                    Console.WriteLine($"aantal pokeballs voor trainer1 {trainer1.belt.Count}");
                    Console.WriteLine($"aantal pokeballs voor trainer2 {trainer2.belt.Count}");
                    // check winning 
                    // punten trainers aanpassen in de arena 

                    int result = DetermineWinner(pokeball1.pokemon, pokeball2.pokemon);
                    if (result == 1) { Arena.addScoreTrainerOne(); }
                    else if (result == 2) { Arena.addScoreTrainerTwo(); }
                    else { Console.WriteLine("Draw"); }

                    trainer1.removrPokeball(pokeball1);
                    trainer2.removrPokeball(pokeball2);


                    Console.WriteLine($"scoor trainer1 {trainer1.name} {Arena.getScoorTrianerOne()}");
                    Console.WriteLine($"scoor trainer2 {trainer2.name} {Arena.getScoorTrianerTwo()}");

                    // docent vragen over of de pokemon in de bal terug moet? of de pokeball in de belt
                    trainer1.returnPokemon(pokeball1, pokeball1.pokemon);
                    trainer2.returnPokemon(pokeball1, pokeball2.pokemon);
                    //Console.WriteLine(pokeball1.Close(pokeball1.pokemon));

                    Thread.Sleep(500);
                    Arena.addRound();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Je had alleen maar {trainer1.belt.Count()} rondes");
            }
        }

        public int DetermineWinner(Pokemon pokemon1, Pokemon pokemon2)
        {
            // If both Pokémon have the same strength, it's a tie
            if (pokemon1.strength == pokemon2.strength)
            {
                return 0;
            }

            // Check win conditions based on the rules
            else if ((pokemon1.strength == "fire" && pokemon2.strength == "grass") ||// Charmander vs Bulbasaur
                    (pokemon1.strength == "grass" && pokemon2.strength == "water") || //Bulbasaur vs Squirtle) 
                    (pokemon1.strength == "water" && pokemon2.strength == "fire"))// Squirtle vs Charmander 
            {
                return 1;
            }
            
            // If pokemon1 doesn't win, pokemon2 wins
            return 2;
        }

        public int checkWinner(int trainerScoorOne, int trainerScoorTwo)
        {
            if (trainerScoorOne > trainerScoorTwo)
            {
                Console.WriteLine($"{trainer1.name} heeft dit battle gewonnen");
                return 1;
            }
            else if (trainerScoorTwo > trainerScoorOne)
            {
                Console.WriteLine($"{trainer2.name} heeft dit battle gewonnen");
                return 2;
            }
            else
            {
                Console.WriteLine("beide trainers gelijk gespeeld");
                return 0;
            }
        }
    }
}




