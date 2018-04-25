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
            Player choosenClass;

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
                    choosenClass = new Player()
                    {
                        maxPlayerHealth = 150,
                        currentPlayerHealth = 150,
                        playerDef = 120,
                        playerStrength = 95,
                        playerAgility = 30,
                        playerExperience = 0
                    };
                    WriteLine("You have choosen the path of the Warrior. Live by the sword. Die by the sword! \n");
                    break;
                case "theif":
                    choosenClass = new Player()
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
                    choosenClass = new Player()
                    {
                        maxPlayerHealth = 70,
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
            Story.Beginning(playerName, playerClass, choosenClass.currentPlayerHealth);
        }

        //public static int CalculateDamageDone(playerHP, monsterDMG)                   //method to calculate the damage a player takes in battle
        //{
        //    playerHP.currentPlayerHealth = playerHP.CurrentPlayerHealth - monsterDMG;
        //}
    }
}