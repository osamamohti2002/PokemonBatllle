using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PokemonBattle.classes
{
    abstract class Pokemon
    {
        public string NickName;
        public string strength;
        public string weakness;

        public Pokemon(string Nickname, string strength, string weakness)
        { 
            this.NickName = Nickname;
            this.strength = strength;
            this.weakness = weakness;
        }

        public abstract string battleCry();

    }
    




}
