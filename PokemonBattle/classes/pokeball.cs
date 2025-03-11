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



        public void Open()
        {
            // dit conditie proberen bij de game logic te plaatsen

            if (hasChaermanderInside)
            {
                Console.WriteLine("the pokeball is already open");
            }
            hasChaermanderInside = true;
            Console.WriteLine("Pokeball opened");
            charmander.battleCry();

        }

        public void Close()
        {
            if (!hasChaermanderInside)
            {
                // dit conditie proberen bij de game logic te plaatsen

                Console.WriteLine("Pokeball is already closed! ");
            }
            hasChaermanderInside = false;
            Console.WriteLine("Charmander returnd to the pokeball");
        }

    }
}
