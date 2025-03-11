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

            for (int i = 0; i < 2; i++)
            {
                belt.Add(new Pokeball(new Charmander()));
                belt.Add(new Pokeball(new Squirtle()));
                belt.Add(new Pokeball(new Bulbasaur()));
            }
        }
        
        
        public string Throwpokeball(int index)
        {
            // de index wordt in de game logic gecontroleert
            return belt[index].Open();
        }
        
        public string returnPokemon(int index)
        {
            // de index wordt in de game logic gecontroleert
            return belt[index].Close();
        }


    }




}
