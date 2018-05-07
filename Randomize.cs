using System;
using System.Linq;
namespace _350_final_project
{
    public static class Randomize
    {
        private static Random rnd = new Random();
        //public static Monster choosenMonster;
        //public static Location choosenLocation;


        public static Monster RandomizeMonster()    //using random counter chose a random monster from the list of monsters
        {
            
            int monsterCounter = rnd.Next(Map.Monsters.Count);
            var choosenMonster = Map.Monsters[monsterCounter];

            return choosenMonster;
        }
        public static Location RandomizeLocation()  //using random counter chose a random location from the list of locations
        {
            int locationCounter = rnd.Next(Map.Locations.Count);
            var choosenLocation = Map.Locations[locationCounter];

            return choosenLocation;
        }
        public static int NumberGenerator(int min,int max)  //generate a random number value
        {
            return rnd.Next(min, max);
        }
    }
}