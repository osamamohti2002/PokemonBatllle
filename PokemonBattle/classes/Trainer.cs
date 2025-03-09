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
        public List<Pokeball> belt;

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new Pokeball());
            }
        }

        public Charmander Throwpokebal()
        {
            for (int i = 0; i < 6; i++)
            {
                if (belt[i].hasChaermanderInside)
                {
                    Charmander charmander = belt[i].Open();
                    belt.Remove(belt[i]);
                    return charmander;
                }
            }
            return null;
        }

        public void returnPokemon(Charmander charmander)
        {
            if (belt.Count < 6)
            {
                belt.close();

            }
        }


    }




}
