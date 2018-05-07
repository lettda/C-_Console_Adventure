using System;
using static System.Console;
using System.Threading;
namespace _350_final_project
{
    public class Encounter
    {
        static int encounterCounter = Randomize.NumberGenerator(1, 10) % 2;
        public static bool gameOver;

        public static void GenerateEncounter (string playerClass,Player classChoosen) //randomize monster encounters
        {
            if (encounterCounter == 0)
            {
                StartBattle(playerClass, classChoosen);
            }
        }

        internal static void StartBattle(string playerClass, Player choosenClass) //
        {
            Monster currentMonster = Randomize.RandomizeMonster(); //current monster the player has encountered
            string action;
            WriteLine("AMBUSH! A {0} appears to challenge you adventurer! \n", currentMonster.Name);

            switch (playerClass) //Determine initial combat action taken depending on player's choosen class
            {
                case "warrior":
                    WriteLine("You quickly draw your greatsword and stand at the ready \n");
                    action = "You drag your sword in a great arc! \n";
                    EncounterBattle(currentMonster, choosenClass, action);
                    break;
                case "theif":
                    WriteLine("You swiftly load your gun, eyes glaring over the barrell \n");
                    action = "You fire your weapon with extreme accuracy! \n";
                    EncounterBattle(currentMonster, choosenClass, action);
                    break;
                case "gunner":
                    WriteLine("You pull both daggers from your cloak and being to toss them from palm to palm \n");
                    action = "You dash forward, daggers a silver blur! \n";
                    EncounterBattle(currentMonster, choosenClass, action);
                    break;
                default:
                    break;
            }

        }

        public static void EncounterBattle(Monster monster, Player choosenClass, string action)    //method to run when an encounter starts
        {
            while (monster.CurrentHp > 0 && 
                   choosenClass.CurrentPlayerHealth > 0) //while the monster's health or players health is greater than the amount of damage taken continue the battle
            {
                if (monster.CurrentHp > 0 && choosenClass.currentPlayerHealth > 0)  //if player and monster both have more than 0 HP continue the battle
                {
                    int monsterHitMissCounter = Randomize.NumberGenerator(1, 10) % 2;   //determine if the monster's attack will hit or miss

                    WriteLine("{0}{1}", monster.Name, monster.Attack);
                    Thread.Sleep(1000);

                    if (monsterHitMissCounter != 0)
                    {

                        WriteLine("{0}'s attack hits, you take {1} damage", monster.Name, monster.MaxDamage);   //display monster's name and damage taken
                        choosenClass.currentPlayerHealth = choosenClass.currentPlayerHealth - monster.MaxDamage;

                        if (choosenClass.currentPlayerHealth <= 0)  //if player has 0 HP game over
                        {
                            gameOver = true;
                            return;
                        } else
                        {
                            WriteLine("Your health is now {0}", choosenClass.currentPlayerHealth);   //display monster's remaiing health
                            ReadKey();
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000); //Pause for one second
                        WriteLine("\n {0} missed!", monster.Name);
                        ReadKey();
                    }
                    int playerHitMissCounter = Randomize.NumberGenerator(1, 10) % 2;    //determine if the player's attack will hit or miss
                    if (playerHitMissCounter != 0)
                    {
                        Thread.Sleep(2000);
                        WriteLine("Your attacked missed!");
                        ReadKey();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        WriteLine("You {0}, {1} takes {2} damage", action, monster.Name, choosenClass.playerDamage);    //display the player's class' choosen prep action and amount of damage taken
                        monster.CurrentHp = monster.CurrentHp - choosenClass.playerDamage;

                        if (monster.CurrentHp <= 0)
                        {
                            WriteLine("{0} has been slain! \n Player earns {1} exp", monster.Name, monster.ExpReward);  //victory condition and message
                        } else
                        {
                            WriteLine("{0}'s current health is {1}", monster.Name, monster.CurrentHp); //display player's remaining health
                            ReadKey();
                        }

                    }
                }
            }
        }
    }
}