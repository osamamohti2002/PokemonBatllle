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

    class Charmander
    {
        public string nickName;
        public string strength = "fire";
        public string weakness = "water";


        public Charmander(string NickName)
        {
            this.nickName = NickName;
        }

        public void battleCry()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nickName);
                Thread.Sleep(500);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of your Charmander: ");
            string charmanderName = Console.ReadLine();
            Charmander myCharmander = new Charmander(charmanderName);


            while (true)
            {

                myCharmander.battleCry();
                Console.WriteLine("Do you want to play again with another name? (y/n)");
                string playAgin = Console.ReadLine();
                if (playAgin.ToLower() == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    Thread.Sleep(3000);
                    break;
                }
               
                
                Console.WriteLine("Rename your Charmander: ");
                string updateNickName = Console.ReadLine();
                myCharmander.nickName = updateNickName;
                

                

            }

        }
    }
}