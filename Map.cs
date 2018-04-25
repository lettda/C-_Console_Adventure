using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace _350_final_project
{
    public class Map
    {
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Monster> Monsters = new List<Monster>();


        //public static int Location_ID_Forest = 1;
        //public static int Location_ID_Cavern = 2;
        //public static int Location_ID_Lake = 3;
        //public static int Location_ID_Tower = 4;
        //public static int Location_ID_Mountain = 5;
        //public static int Location_ID_Dungeon = 6;
        //public static int Location_ID_PalletTown = 7;


        static Map()
        {
            CreateLocations();
            CreateMonsters();
        }

        static void CreateMonsters()
        {
            Monster goblin = new Monster ("Goblin","throws club",5,5,1,2);
            Monster fireElemental = new Monster("Fire Elemental", "hurls fire ball", 20, 20, 15, 10);
            Monster giantCrow = new Monster("Giant Crow", "wing attack", 8, 8, 3, 5);
            Monster grunt = new Monster("Grunt","fires its pistol", 6, 6, 1, 7);
            Monster pokemonMaster = new Monster("Pokemon Master","throws pokeball", 15, 15, 9, 25);
            Monster dragon = new Monster("Dragon","conjures a tornado of flames", 50, 50, 25, 100);

            Monsters.Add(goblin);
            Monsters.Add(fireElemental);
            Monsters.Add(giantCrow);
            Monsters.Add(grunt);
            Monsters.Add(pokemonMaster);
            Monsters.Add(dragon);

        }

        static void CreateLocations()
        {
            Location forest = new Location("Everwood Forest", "You stepped into everwood forest");
            Location cavern = new Location( "Pyre Stone Caverns", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location lake = new Location("Maiden's Lake", "You stumble the Maiden's lake, remember to pay homage to the lady of the lake");
            Location tower = new Location("Tower", "Before you lies the dark tower");
            Location mountain = new Location("Mountain", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location dungeon = new Location("Dungeon", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location palletTown = new Location("Pallet Town", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");

            Locations.Add(forest);
            Locations.Add(cavern);
            Locations.Add(lake);
            Locations.Add(tower);
            Locations.Add(mountain);
            Locations.Add(dungeon);
            Locations.Add(palletTown);
        }
    }
}
