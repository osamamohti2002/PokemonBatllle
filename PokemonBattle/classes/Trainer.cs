using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Trainer
    {
        public string name;
        public List<Pokeball> belt = new List<Pokeball>();

        public Trainer(string name)
        {
            this.name = name;
           

        }
        
        
        public Pokemon Throwpokeball(int index)
        {
            return belt[index].Open();
        }
        
        public string returnPokemon(int index, Pokemon pokemon)
        {
            return belt[index].Close(pokemon);
        }


    }




}
