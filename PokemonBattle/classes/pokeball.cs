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
        public bool hasChaermanderInside;


        public Pokeball()
        {
            hasChaermanderInside = false;
            charmander = null;
        }


        public Pokeball(Charmander charmander)
        {
            this.hasChaermanderInside = true;
            this.charmander = charmander;
        }

        public Charmander Open()
        {
            if (hasChaermanderInside)
            {
                hasChaermanderInside = false;
                return charmander;
            }
            return null;
        }

        public void Close(Charmander charmander)
        {
            if (!hasChaermanderInside)
            {
                hasChaermanderInside = true;
            }
        }

        public bool HasCharmanderInside()
        {
            return hasChaermanderInside;
        }
    }
}
