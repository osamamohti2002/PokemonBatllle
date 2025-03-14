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
        // var name veranderen
        public bool hasChaermanderInside = false;


        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;

        }



        public Pokemon Open()
        {
            // dit conditie proberen bij de game logic te plaatsen

            if (hasChaermanderInside)
            {
                //return "the pokeball is already open"; 
            }
            hasChaermanderInside = true;
            var pokemon1 = pokemon;
            this.pokemon = null;

            return pokemon1;


        }

        public string Close(Pokemon pokemon)
        {
            if (!hasChaermanderInside)
            {
                // dit conditie proberen bij de game logic te plaatsen

                return "Pokeball is already closed! ";
            }
            
            hasChaermanderInside = false;
            this.pokemon = pokemon;
            return $"{pokemon.NickName} returnd to the pokeball";
        }

    }
}
