using System;
using static System.Console;
namespace _350_final_project
{
    public class Encounter
    {
        private static int encounterCounter = Randomize.NumberGenerator(1, 10) % 2;

        public static void GenerateEncounter (string playerClass,Player classChoosen)
        {
            if (encounterCounter == 0)
            {
                StartBattle(playerClass, classChoosen);
            }
        }

        public static void StartBattle(string playerClass, Player choosenClass)
        {
            Monster currentMonster = Randomize.RandomizeMonster();
            WriteLine("AMBUSH! A {0} appears to challenge you adventurer!", currentMonster.Name);

            switch (playerClass)
            {
                case "warrior":
                    WriteLine("You quickly draw your greatsword and stand at the ready");
                    break;
                case "theif":
                    WriteLine("You swiftly load your gun, eyes glaring over the barrell");
                    break;
                case "gunner":
                    WriteLine("You pull both daggers from your cloak and being to toss them from palm to palm");
                    break;

                default:
                    break;
            }
            EncounterBattle(currentMonster);
        }

        private static void EncounterBattle(Monster monster)
        {
            int hitMissCounter = Randomize.NumberGenerator(1, 10) % 2;

            WriteLine("{0}{1}", monster.Name, monster.Attack);

            if (encounterCounter != 0)
            {
                WriteLine("{0}'s attack hits, you take {1} damage", monster.Name, monster.MaxDamage);

                WriteLine("Your current health is {0}", CalculateDamageDone(monster.MaxDamage));
            }
        }
    }
}
