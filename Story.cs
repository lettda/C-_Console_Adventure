using System;
using static System.Console;
namespace _350_final_project
{
    public class Story
    {
        public static void Beginning(string playerName, string playerClass, int playerHP)
        {
            WriteLine("Valiant {0}, It is time to begin your journey", playerName);
            WriteLine("We begin in the hall of heroes, the queen has tasked you with destorying the dragon \n" +
                      " that resides at the tower on the edge of the kingdom. To bein your journey pick a direction in which to go. \n" +
                      "Will you venture north, east or west?");
            string directionDecision = ReadLine();

            WriteLine("You head {0}, steadily maing your way toward {1}", directionDecision, Randomize.RandomizeLocation().Name);
            WriteLine("After several long miles you come across a fork in the road with no signs pointing you to your destination. \n " +
                      "Your map is useless and due to your illpreparaedness supplies are running short. Wich direction will you go? \n" +
                      "North, East, or West?:");
            directionDecision = ReadLine();

            WriteLine("Setting your sights to the {0} you soldier on. As you take a look at your surrondings and you suddenly " +
                      "notice your not alone", directionDecision);
            Encounter.StartBattle(playerClass, classChoosen);
        }
    }
}
