using System;
using static System.Console;
using System.Threading;
namespace _350_final_project
{
    public class Encounter
    {
        static int encounterCounter = Randomize.NumberGenerator(1, 10) % 2;

        //public static void GenerateEncounter (string playerClass,Player classChoosen)
        //{
        //    if (encounterCounter == 0)
        //    {
        //        StartBattle(playerClass, classChoosen);
        //    }
        //}

        public static void StartBattle(string playerClass, Player choosenClass)
        {
            Monster currentMonster = Randomize.RandomizeMonster();
            string action;
            WriteLine("AMBUSH! A {0} appears to challenge you adventurer!", currentMonster.Name);

            switch (playerClass)
            {
                case "warrior":
                    WriteLine("You quickly draw your greatsword and stand at the ready");
                    action = "You drag your sword in a great arc!";
                    EncounterBattle(currentMonster, choosenClass, action);
                    break;
                case "theif":
                    WriteLine("You swiftly load your gun, eyes glaring over the barrell");
                    action = "You fire your weapon with extreme accuracy!";
                    EncounterBattle(currentMonster, choosenClass, action);
                    break;
                case "gunner":
                    WriteLine("You pull both daggers from your cloak and being to toss them from palm to palm");
                    action = "You dash forward, daggers a silver blur!";
                    EncounterBattle(currentMonster, choosenClass, action);
                    break;
                default:
                    break;
            }

        }

        static void EncounterBattle(Monster monster, Player choosenClass, string action)
        {
            while (monster.CurrentHp > monster.MonsterDamageTaken(choosenClass.playerDamage) || 
                   choosenClass.CurrentPlayerHealth > choosenClass.DamageTaken(monster.MaxDamage)) //while the monster's health or players health is greater than the amount of damage taken continue the battle
            {
                int monsterHitMissCounter = Randomize.NumberGenerator(1, 10) % 2;

                WriteLine("{0}{1}", monster.Name, monster.Attack);

                if (monsterHitMissCounter != 0)
                {
                    WriteLine("{0}'s attack hits, you take {1} damage", monster.Name, monster.MaxDamage);

                    WriteLine("Your health is now {0}", choosenClass.DamageTaken(monster.MaxDamage));
                    ReadKey();
                }

                else
                {
                    Thread.Sleep(2000);
                    WriteLine("\n {0} missed!", monster.Name);
                    ReadKey();
                }
                int playerHitMissCounter = Randomize.NumberGenerator(1, 10) % 2;
                if (playerHitMissCounter != 0)
                {
                    WriteLine("Your attacked missed!");
                    ReadKey();
                } else
                {
                    WriteLine("You {0}, {1} takes {2} damage", action, monster.Name, choosenClass.playerDamage);

                    WriteLine("{0}'s current health is {1}", monster.Name, monster.MonsterDamageTaken(choosenClass.playerDamage));
                    ReadKey();
                }
            }
        }
    }
}
