using System;
using System.Linq;
using static System.Console;

namespace _350_final_project
{
    class Program
    {

        public static void Main()
        {
            string playerName;
            string playerClass;

            do
            {
                WriteLine("What do you want your character's name to be?");
                playerName = ReadLine();

            } while (string.IsNullOrEmpty(playerName)); //while playerName contains no value

            WriteLine("Welcome {0}, to your great Adventure", playerName);

            WriteLine("Choose your class by entering its name: \n You may choose the noble Warrior, the dastardly Theif, or the honorable Gunner");
            playerClass = ReadLine();

            switch (playerClass.ToLower())
            {
                case "warrior":
                    Player warrior = new Player()
                    {
                        playerHealth = 150,
                        currentPlayerHealth = 150,
                        playerDef = 120,
                        playerStrength = 95,
                        playerAgility = 30,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen the path of the Warrior. Live by the sword. Die by the sword! \n");
                    break;
                case "theif":
                    Player theif = new Player()
                    {
                        maxPlayerHealth = 85,
                        currentPlayerHealth = 85,
                        playerDef = 43,
                        playerStrength = 20,
                        playerAgility = 125,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen to lurk in the shadows as a theif \n");
                    break;
                case "gunner":
                    Player gunner = new Player()
                    {
                        playerHealth = 70,
                        currentPlayerHealth = 70,
                        playerDef = 75,
                        playerStrength = 60,
                        playerAgility = 110,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen the way of the gunner, shoot with your mind not your eye \n");
                    break;
                default:
                    break;
            }

            WriteLine("Valiant {0}, It is time to begin your journey", playerClass);
            WriteLine("We begin in the hall of heroes, the queen has tasked you with destorying the dragon \n" +
                      " that resides at the tower on the edge of the kingdom. To bein your journey pick a direction in which to go. \n" +
                      "Will you venture north, east or west?");
            string directionDecision = ReadLine();

            WriteLine("You head toward the {0}, facing you is the {1}", directionDecision, Randomize.RandomizeLocation().Name);
                                
        }
    }
}