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
                for (int i = 0; i < roudns && trainer1.getPokeballs().Count > 0 && trainer2.getPokeballs().Count > 0; i++)
                {

                    // shrinks te ontweikken onderzoeken 
                    Pokeball pokeball1 = trainer1.getPokeballs()[0];
                    Console.WriteLine($"pokemon trainer1 {pokeball1}" );
                    Pokeball pokeball2 = trainer2.getPokeballs()[0];

                    trainer1.Throwpokeball(pokeball1);
                    Logger.log($"the pokeball is opened {pokeball1.getPokemon().getNickName()}");

                    trainer2.Throwpokeball(pokeball2);
                    Logger.log($"the pokeball is opened {pokeball2.getPokemon().getNickName()}");

                    int result = DetermineWinner(pokeball1.getPokemon(), pokeball2.getPokemon());
                    if (result == 1) { Arena.addScoreTrainerOne(); }
                    else if (result == 2) { Arena.addScoreTrainerTwo(); }
                    else { Logger.log("DRAW"); }

                    trainer1.removrPokeball(pokeball1);
                    trainer2.removrPokeball(pokeball2);

                    Logger.log($"scoor trainer1 {trainer1.getName()} {Arena.getScoorTrianerOne()}");
                    Logger.log($"scoor trainer2 {trainer2.getName()} {Arena.getScoorTrianerTwo()}");

                    // docent vragen over of de pokemon in de bal terug moet? of de pokeball in de belt
                    trainer1.returnPokemon(pokeball1, pokeball1.getPokemon());
                    trainer2.returnPokemon(pokeball1, pokeball2.getPokemon());

                    Thread.Sleep(500);
                    Arena.addRound();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Logger.log($"Je had alleen maar {trainer1.getPokeballs().Count()} rondes");
            }
        }

        public int DetermineWinner(Pokemon pokemon1, Pokemon pokemon2)
        {
            if (pokemon1.getStrength() == pokemon2.getStrength())
            {
                return 0;
            }

            else if(pokemon1.getStrength() == pokemon2.getWeakness())
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public int checkWinner(int trainerScoorOne, int trainerScoorTwo)
        {
            if (trainerScoorOne > trainerScoorTwo)
            {
                Logger.log($"{trainer1.getName()} heeft dit battle gewonnen");
                return 1;
            }
            else if (trainerScoorTwo > trainerScoorOne)
            {
                Logger.log($"{trainer2.getName()} heeft dit battle gewonnen");
                return 2;
            }
            else
            {
                Logger.log("beide trainers gelijk gespeeld");
                return 0;
            }
        }
    }
}




