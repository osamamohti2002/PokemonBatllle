using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Pokeball
    {
        // ipv class Charmander, Class Pokemon gebruikt
        public Pokemon pokemon;
        public bool hasChaermanderInside = false;


        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }



        public string Open()
        {
            // dit conditie proberen bij de game logic te plaatsen

            if (hasChaermanderInside)
            {
                return "the pokeball is already open"; 
            }
            hasChaermanderInside = true;
            
            return pokemon.battleCry();


        }

        public string Close()
        {
            if (!hasChaermanderInside)
            {
                // dit conditie proberen bij de game logic te plaatsen

                return "Pokeball is already closed! ";
            }
            hasChaermanderInside = false;
            return $"{pokemon.NickName} returnd to the pokeball";
        }

    }
}
