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
            if ( charmander != null)
            {
                hasChaermanderInside = true;
                this.charmander = charmander;
            }

        }

        public Charmander Open()
        {
            if (hasChaermanderInside)
            {
                hasChaermanderInside = false;
                Charmander temp = charmander;
                charmander = null;
                return charmander;
            }
            return null;
        }

        public void Close(Charmander charmander)
        {
            if (!hasChaermanderInside && charmander != null)
            {
                hasChaermanderInside = true;
                this.charmander = charmander;
            }
        }

        public bool HasCharmanderInside()
        {
            return hasChaermanderInside;
        }
    }
}
