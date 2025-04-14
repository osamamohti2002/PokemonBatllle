using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
     class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle", "water", "leaf")
        {

        }

        public override string battleCry()
        {
            return $"{NickName} Squirtle Squirtle ";
        }
    }
}
