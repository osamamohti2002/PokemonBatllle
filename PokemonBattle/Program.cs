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

                Squirtle squirtle1 = new Squirtle();
                Bulbasaur bulbasaur1 = new Bulbasaur();

               

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"\nRound {i + 1}");
                    trainer1.Throwpokeball(i);
                    trainer2.Throwpokeball(i);
                    trainer1.returnPokemon(i);
                    trainer2.returnPokemon(i);
                    Thread.Sleep(500);
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