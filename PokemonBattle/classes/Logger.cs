using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.classes
{
    // dit helper class aangemaakt om de massges in de logic classes te printen imv Console.WriteLine() in de logic classes
    // en dat helpt voor clean code
    public static class Logger
    { 
        public static void log(String massege)
        {
            // in de toekomst als de UI veranderet hoeven we alleen dit regel te veranderen 
            Console.WriteLine(massege);
        }
    }
}
