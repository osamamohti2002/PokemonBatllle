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

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new Pokeball(new Charmander($"charmander{i + 1}" )));
            }
        }
        
        
        public void Throwpokeball(int index)
        {
            if(index < 0 || index >= belt.Count)
            {
                Console.WriteLine("Invalid Pokeball index");
            }
            belt[index].Open();
        }

        public void returnPokemon(int index)
        {
            if(index >= 0  || index>= belt.Count)
            {
                Console.WriteLine("Indalid pokeball index");
            }
            belt[index].Close();
        }


    }




}
