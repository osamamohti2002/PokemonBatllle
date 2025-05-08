using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
     class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle", PokemonType.Water, PokemonType.Leef)
        {

        }

        public override string battleCry()
        {
            return $"{getNickName()} Squirtle Squirtle ";
        }
    }
}
