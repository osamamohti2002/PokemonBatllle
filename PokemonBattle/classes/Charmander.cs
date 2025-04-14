using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Charmander : Pokemon
    {


        public Charmander() : base("Charmander", "fire", "water")
        {

        }

        public override string battleCry()
        {
            return $"{NickName} Char Char";
        }










    }
}
