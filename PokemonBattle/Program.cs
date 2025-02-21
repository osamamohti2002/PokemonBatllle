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


        public void StartGame()
        {
            Console.WriteLine("Enter your name (First Trainer)... ");
            Trainer trainer1 = new Trainer(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Enter your name (Second Trainer)... ");
            Trainer trainer2 = new Trainer(Console.ReadLine());

            StartBattle(trainer1, trainer2);
        }

        public void RestartGame()
        {
            Console.WriteLine("<<< Would you like to play agin (y/n)>>>");
            string restart = Console.ReadLine();
            if (restart == "y")
            {
                StartGame();
                //Console.WriteLine("WOOOH");

            }
            else
            {
                Console.WriteLine("Thanks for playing ");
            }

        }

        public void StartBattle(Trainer trainer1, Trainer trainer2)
        {

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{trainer1.name} throws a Pokeball! ");
                Charmander chaermander1 = trainer1.throwPokeball();
                chaermander1.battleCry();

                Console.WriteLine($"{trainer2.name} throws a Pokeball");
                Charmander charmander2 = trainer2.throwPokeball();
                chaermander1.battleCry();

                Console.WriteLine($"{trainer1.name} puts his Charmander back into the Pokeball");
                trainer1.returnPokemon(chaermander1);

                Console.WriteLine($"{trainer2.name} puts his Charmander back into the Pokeball");
                trainer2.returnPokemon(charmander2);

            }
            
            RestartGame();

        }
        static void Main(string[] args)
        {

            Charmander charmander1 = new Charmander("Zebi", "", "");
            Charmander charmander2 = new Charmander("eri", "", "");

            Program game = new Program();
            Console.WriteLine("<< Welcome to Pokemon Simulator >>>");
            game.StartGame();
            game.RestartGame();



        }
    }
}