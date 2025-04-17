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
        public string name;
        public List<Pokeball> belt = new List<Pokeball>();

        public Trainer(string name)
        {
            this.name = name;
        }



        public Pokemon Throwpokeball(Pokeball pokeball)
        {
            var pokemon = pokeball.Open(pokeball.pokemon);
            return pokemon;

        }

        public void removrPokeball(Pokeball pokeball)
        {
            belt.Remove(pokeball);
            //Logger.log($"the pokeball is removed {pokeball.pokemon.NickName}");
        }

        public Pokemon returnPokemon(Pokeball pokeball, Pokemon pokemon)
        {
            return pokeball.Close(pokemon);
        }


    }




}
