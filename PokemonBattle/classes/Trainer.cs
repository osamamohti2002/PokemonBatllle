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

        public Trainer(string name)
        {

            this.name = name;
            this.belt = new List<Pokeball>();

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new Pokeball());
            }

            
        }

        public void takePokeball(Pokeball pokeball)
        {
            belt.Remove(pokeball);
        }

        public Charmander throwPokeball()
        {
            if(belt.Count > 0)
            {
                Pokeball pokeballToThrow = belt.First();
                belt.RemoveAt(0);
                return pokeballToThrow.Open();
            }
            else
            {
                throw new InvalidOperationException("No Pokeballs available to throw");
            }
        }

        public void returnPokemon(Charmander charmander)
        {
            if (belt.Count < 6)
            {
                Pokeball pokeballToReturn = belt.First();
                pokeballToReturn.Close(charmander);
                belt.Add(pokeballToReturn);
            }
            else
            {
                throw new InvalidOperationException("The belt is already full");
            }
        }


    }




}
