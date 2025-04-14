using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", "grass", "fire")
        {

        }

        public override string battleCry()
        {
            return $"{NickName} Bulba  Bulba  ";
        }
    }
}
