using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    public class Pokeball
    {
        public Pokemon pokemon;
        public bool hasChaermanderInside = true;


        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public Pokemon Open(Pokemon pokemon)
        {
            hasChaermanderInside = false;
            var pokemonValue = pokemon;
            pokemon = null;
            return pokemonValue;
        }
        public Pokemon Close(Pokemon pokemon)
        {
            hasChaermanderInside = true;
            return pokemon;
            //return $"{pokemon.NickName} returnd to the pokeball";
        }

    }
}
