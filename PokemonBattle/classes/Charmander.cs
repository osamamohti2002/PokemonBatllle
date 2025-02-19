using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    class Charmander
    {

            public string nickName;
            public string strength = "fire";
            public string weakness = "water";


            public Charmander(string NickName)
            {
                this.nickName = NickName;
            }

            public string battleCry()
            {

            return this.nickName;    
            }
        
    }
}
