using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Charmander
    {

        public string NickName;
        public string strength = "fire";
        public string weakness = "water";


        public Charmander(string NickName, string strength, string weakenss)
        {
            this.NickName = NickName;
            this.strength = strength;
            this.weakness = weakenss;
        }

        public Charmander(string NickName)
        {
            this.NickName = NickName;
        }


            
            

        public void battleCry()
        {

            Console.WriteLine($"{NickName} Char Char");
        }
        
    }
}
