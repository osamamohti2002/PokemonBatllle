using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PokemonBattle.classes
{
    public class Arena
    {

        // ik moet battle variabel hebben 
        private static int battles = 0;
        private static int rounds = 0; 
        private static int trainerOneScoor = 0;
        private static int trainerTwoScoor = 0;
        private Battle battle;



        public static void addRound()
        {
            rounds++;
        }

        public static void addScoreTrainerOne()
        {
            trainerOneScoor++;
        }

        public static void addScoreTrainerTwo()
        {
            trainerTwoScoor++;
        }

        public static int getScoorTrianerOne()
        {
            return trainerOneScoor;
        }

        public static int getScoorTrianerTwo()
        {
            return trainerTwoScoor;
        }

        public static void restScoor()
        {
            trainerOneScoor = 0;
            trainerTwoScoor = 0;
        }

        public static void setBattle()
        {
            battles++;
        }

        public static int getBattles()
        {
            return battles;
        }


        public void StartBattle(Trainer trainer1, Trainer trainer2)
        {

            battle = new Battle(trainer1, trainer2);
            battle.startBattle();
            battle.checkWinner(getScoorTrianerOne(), getScoorTrianerTwo());

        }





    }
}
