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

            Story.ChooseClass(playerClass);


            Story.Beginning(playerName, playerClass);
        }


    }
}