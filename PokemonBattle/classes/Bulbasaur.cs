using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", "grass", "Fire")
        {

        }

        public override void battleCry()
        {
            Console.WriteLine($"{NickName} Bulba  Bulba  ");
        }
    }
}
