using System;
using static System.Console;
namespace _350_final_project
{
    public class Story
    {
        public Player choosenClass;

        public Player ChooseClass(string choice)
        {
            switch (choice.ToLower())
            {
                case "warrior":
                    choosenClass = new Player()
                    {
                        maxPlayerHealth = 150,
                        currentPlayerHealth = 150,
                        playerDamage = 35,
                        playerDef = 120,
                        playerStrength = 95,
                        playerAgility = 30,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen the path of the Warrior. Live by the sword. Die by the sword! \n");
                    return choosenClass;
                case "theif":
                    choosenClass = new Player()
                    {
                        maxPlayerHealth = 85,
                        currentPlayerHealth = 85,
                        playerDamage = 27,
                        playerDef = 43,
                        playerStrength = 20,
                        playerAgility = 125,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen to lurk in the shadows as a theif \n");
                    return choosenClass;
                case "gunner":
                    choosenClass = new Player()
                    {
                        maxPlayerHealth = 70,
                        currentPlayerHealth = 70,
                        playerDamage = 40,
                        playerDef = 75,
                        playerStrength = 60,
                        playerAgility = 110,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen the way of the gunner, shoot with your mind not your eye \n");
                    return choosenClass;
                default:
                    return null;
            }
        }

        public void Beginning(string playerName, string playerClass)
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
            Encounter.StartBattle(playerClass, choosenClass);
        }
    }
}
