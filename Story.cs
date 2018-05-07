using System;
using System.Threading;
using static System.Console;
namespace _350_final_project
{
    public class Story
    {
        public Player choosenClass; //player's choosen class
        //Encounter newEncounter = new Encounter();
        int riddleCounter;


        public Player ChooseClass(string choice)    //to run and allow player to pick from 3 different classes by intantiate an instance depending on their answer
        {
            switch (choice.ToLower())
            {
                case "warrior": //blue print for the warrior class
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
                case "theif":   //blueprint for Theif class
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
                case "gunner":  //blueprint for the gunner class
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

        public void Beginning(string playerName, string playerClass)    //Begin the story

        {
            WriteLine("Valiant {0}, It is time to begin your journey", playerName);
            WriteLine("We begin in the hall of heroes: \n" +
                      " The queen has tasked you with destorying the dead god \n" +
                      " that resides at the tower on the edge of the kingdom \n." +
                      " To begin your journey pick a direction in which to go. \n" +
                      "Will you venture north, east or west? ");
            string directionDecision = ReadLine();  //player's diretion decision

            WriteLine("You head {0}, steadily maing your way toward {1}", directionDecision, Randomize.RandomizeLocation().Name);   //pick a random location
            WriteLine("After several long miles you come across a fork in the road with no signs pointing you to your destination. \n " +
                      "Your map is useless and due to your illpreparaedness supplies are running short. Wich direction will you go? \n" +
                      "North, East, or West?:");
            directionDecision = ReadLine();

            WriteLine("Setting your sights to the {0} you soldier on. As you take a look at your surrondings you suddenly " +
                      "notice your not alone \n", directionDecision);
            Encounter.GenerateEncounter(playerClass, choosenClass);

            switch (Encounter.gameOver) //Game over logics
            {
                case true:
                    WriteLine("You have been defeated......GAME OVER");
                    break;
                case false:
                    WriteLine("You have slain the beast! Now you must continue your jounrey to the {0}. ", directionDecision);
                    break;
                default:
                    break;
            }
            WriteLine("Moving again toward the {0} you arrive at {1}", directionDecision, Randomize.RandomizeLocation().Name);
            WriteLine("As you wander around you begin to hear a voice calling to you, it has the asnwers you seek. \n " +
                      "Tell me hero/heroine will you follow(f) the voice or continue(c) on your own?");
            string followOrContinue = ReadLine();

            switch (followOrContinue.ToLower())
            {
                case "f":
                    FollowChoosen(playerName, playerClass);
                    break;
                case "c":
                    ContinueChoosen(playerName, playerClass);
                    break;
                default:
                    break;
            }

        }
        private void FollowChoosen(string playerName, string playerClass) //Story continuatin based on follow(F)
        {
            
            WriteLine("You choose to listen to the voice. It speaks of an ancient magic that will help you defeat the dead god");
            Thread.Sleep(1000);
            WriteLine("{0}, for the prize that you seek /n" +
                      "Answers three are what I keep /n" +
                      "Three for three and be on your way \n" +
                      "Two for two a small price to pay \n" +
                     "One an only you, with me you stay");
            Thread.Sleep(1000);
            WriteLine("The first may be circle of gold or words unspoken and if left unkept is surely broken: \n");
            string riddleOneAnswer = ReadLine().ToLower();

            switch (riddleOneAnswer)
            {
                case "promise":
                    WriteLine();
                    riddleCounter += 1;
                    break;
                default:
                    WriteLine("Incorrect");
                    break;
            }
            Thread.Sleep(1000);
            WriteLine("The second lives from falls on high, but a watery grave ensures its demise: \n");
            string riddleTwoAnswer = ReadLine().ToLower();
            switch (riddleTwoAnswer)
            {
                case "paper":
                    WriteLine();
                    riddleCounter += 1;
                    break;
                default:
                    WriteLine("Incorrect");
                    break;
            }
            Thread.Sleep(1000);
            WriteLine("The third a treasure which begins yet has no end, to those that live it is no friend: \n");
            string riddleThreeAnswer = ReadLine().ToLower();
            switch (riddleThreeAnswer)
            {
                case "time":
                    WriteLine();
                    riddleCounter += 1;
                    break;
                default:
                    WriteLine("Incorrect");
                    break;
            }
            if (riddleCounter == 3)
            {
                WriteLine("You have answered my riddles three. Ask the truth and I shall answer thee \n" +
                          "Be it grand or be it small, no question be to short or tall");
            } else if (riddleCounter == 2)
            {
                WriteLine("Two you passed yet one was failed, pay the cost to continue your tale");
                Encounter.GenerateEncounter(playerClass, choosenClass);
            } else 
            {
                WriteLine("One by one, you've failed this test. Now your soul I lay to rest");
                Encounter.gameOver = true;
                WriteLine("You have been defeated......GAME OVER");
            }

        }

        private void ContinueChoosen(string playerName, string playerClass) //Story continuation absed on continue(C)
        {
            WriteLine("Ignoring the voice you continue on. A {0} has to time for fairytales.", playerClass);
            WriteLine("As you walk through the streets of the town you notice a dark figure waiting in the wings \n" +
                      "You've been followed, a spy of he dead god?");
            Encounter.GenerateEncounter(playerName, choosenClass);

            switch (Encounter.gameOver) //Game over logics
            {
                case true:
                    WriteLine("You have been defeated......GAME OVER");
                    break;
                case false:
                    WriteLine("You have slain the villian!");
                    break;
                default:
                    break;
            }
        }
    }
}