using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Pokeball
    {
        public Charmander charmander;
        public bool hasChaermanderInside = false;


        public Pokeball(Charmander charmander)
        {
            this.charmander = charmander;
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
