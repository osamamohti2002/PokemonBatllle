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
    using System.Net.Configuration;
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

                // 6 random pokeballs aan de trainers geven 
                Random random = new Random();

                List<Pokemon> pokemons = new List<Pokemon>();
                for(int i = 0; i < 4; i++)
                {
                    pokemons.Add(new Charmander());
                    pokemons.Add(new Squirtle());
                    pokemons.Add(new Bulbasaur());
                }

                for (int i = 0; i < 6; i++)
                {
                    Pokemon randomPokemon = pokemons[random.Next(pokemons.Count)];
                    trainer1.getPokeballs().Add(new Pokeball(randomPokemon));
                    pokemons.Remove(randomPokemon);
                }

                for (int i = 0; i < 6; i++)
                {
                    Pokemon randomPokemon = pokemons[random.Next(pokemons.Count)];
                    trainer2.getPokeballs().Add(new Pokeball(randomPokemon));
                    pokemons.Remove(randomPokemon);
                }

                Arena arena = new Arena();
                arena.StartBattle(trainer1 ,trainer2);
                Arena.setBattle();
                Console.WriteLine("Do you want to play agin? (y/n)");
                string answer = Console.ReadLine();
                Arena.restScoor();
                Console.WriteLine($"gespeelde battle {Arena.getBattles()}");

                if (answer.ToLower() != "y")
                {
                    break;
                }


            }





        }
    }
}






//for (int i = 0;i < trainer1.belt.Count; i++)
//{
//    Console.WriteLine($"trainet1 belt  {trainer1.belt[i].pokemon.NickName}" );
//}

//for (int i = 0; i < trainer2.belt.Count; i++)
//{
//    Console.WriteLine($"trainet2 belt  {trainer2.belt[i].pokemon.NickName}");
//}