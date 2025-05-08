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
    public abstract class Pokemon
    {
        private readonly string NickName;
        private readonly PokemonType strength;
        private readonly PokemonType weakness;

        public Pokemon(string Nickname, PokemonType strength, PokemonType weakness)
        { 
            this.NickName = Nickname;
            this.strength = strength;
            this.weakness = weakness;
        }

        public string getNickName()
        {
            return NickName;
        }

        public PokemonType getStrength()
        {
            return strength;
        }

        public PokemonType getWeakness()
        {
            return weakness;
        }

        public abstract string battleCry();

    }

    public enum PokemonType
    {
        Fire,
        Water,
        Grass,
        Leef,
    }

}
