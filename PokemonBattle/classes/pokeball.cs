using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    public sealed class Pokeball
    {
        private readonly Pokemon pokemon;
        private bool isOpen = false;


        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public Pokemon getPokemon()
        {
            return pokemon;
        }

        public Pokemon Open(Pokemon pokemon)
        {
            isOpen = true;
            var pokemonValue = pokemon;
            pokemon = null;
            return pokemonValue;
        }
        public Pokemon Close(Pokemon pokemon)
        {
            isOpen = false;
            return pokemon;

        }

    }
}
