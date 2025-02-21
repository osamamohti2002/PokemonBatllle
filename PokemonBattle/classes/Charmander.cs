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

        public string nickName;
        public string strength = "fire";
        public string weakness = "water";


        public Charmander(string NickName, string strength, string weakenss)
        {
            this.nickName = NickName;
            this.strength = strength;
            this.weakness = weakenss;
        }

        public string GetName()
        {
            return nickName;
        }

            
            

        public void battleCry()
        {

            Console.WriteLine("Charmander Char Char");
        }
        
    }
}
