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


            Console.WriteLine("Enter your name of both trainers !... ");
            string nameTrainer1 = Console.ReadLine();
            string nameTrainer2 = Console.ReadLine();
            Trainer trainer1 = new Trainer(nameTrainer1);
            Trainer trainer2 = new Trainer(nameTrainer2);
            Console.WriteLine(trainer1.name);
            Console.WriteLine(trainer2.name);
            Console.WriteLine($"{trainer1.name} gooit de eerste pokebaal {trainer1.throwPokeball()}");



        }
    }
}