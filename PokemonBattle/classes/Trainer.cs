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

        // method voor pokeball te pakken met random pokeball


        public Pokemon Throwpokeball(Pokeball pokeball)
        {
            var pokemon = pokeball.Open(pokeball.pokemon);
            Console.WriteLine($"the pokeball is opened {pokeball.pokemon.NickName}");
            return pokemon;

        }

        public void removrPokeball(Pokeball pokeball)
        {
            belt.Remove(pokeball);
            Console.WriteLine($"the pokeball is removed {pokeball.pokemon.NickName}");
        }

        public Pokemon returnPokemon(Pokeball pokeball, Pokemon pokemon)
        {
            //belt.Add(new Pokeball(pokemon));
            return pokeball.Close(pokemon);
        }


    }




}
