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
                Console.WriteLine("Pokeball is already closed! ");
            }
            hasChaermanderInside = false;
            Console.WriteLine("Charmander returnd to the pokeball");
        }

    }
}
