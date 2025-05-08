using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", PokemonType.Grass, PokemonType.Fire)
        {

        }

        public override string battleCry()
        {
            return $"{getNickName()} Bulba  Bulba  ";
        }
    }
}
