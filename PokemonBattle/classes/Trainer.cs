using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    public class Trainer
    {
        private readonly string name;
        private readonly List<Pokeball> belt;

        public Trainer(string name)
        {
            this.name = name;
            belt = new List<Pokeball>();
        }

        public string getName()
        {
            return name;
        }

        public List<Pokeball> getPokeballs()
        {
            return belt;
        }


        public Pokemon Throwpokeball(Pokeball pokeball)
        {
            var pokemon = pokeball.Open(pokeball.getPokemon());
            return pokemon;

        }

        public void removrPokeball(Pokeball pokeball)
        {
            belt.Remove(pokeball);
        }

        public Pokemon returnPokemon(Pokeball pokeball, Pokemon pokemon)
        {
            return pokeball.Close(pokemon);
        }


    }




}
