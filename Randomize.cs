using System;
using System.Linq;
namespace _350_final_project
{
    public static class Randomize
    {
        private static Random rnd = new Random();
        //public static Monster choosenMonster;
        //public static Location choosenLocation;


        public static Monster RandomizeMonster()
        {
            
            int monsterCounter = rnd.Next(Map.Monsters.Count);
            var choosenMonster = Map.Monsters[monsterCounter];

            return choosenMonster;
        }
        public static Location RandomizeLocation()
        {
            int locationCounter = rnd.Next(Map.Locations.Count);
            var choosenLocation = Map.Locations[locationCounter];

            return choosenLocation;
        }
    }
}
