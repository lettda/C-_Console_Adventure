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

            Story newStory = new Story(); //instantiate new class to access class member methods (main method being static)

            do
            {
                WriteLine("What do you want your character's name to be?"); //Have player input their name and save for further use
                playerName = ReadLine();

            } while (string.IsNullOrEmpty(playerName)); //while playerName contains no value

            WriteLine("Welcome {0}, to your great Adventure", playerName);

            WriteLine("Choose your class by entering its name: \n You may choose the noble Warrior, the dastardly Theif, or the honorable Gunner");
            playerClass = ReadLine(); //Have player input their class and save for further use

            newStory.ChooseClass(playerClass); //Belongs to the story class, must have an instance instatiated due to main method being static


            newStory.Beginning(playerName, playerClass); //Belongs to the story class
        }
    }
}