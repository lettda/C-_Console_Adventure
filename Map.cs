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



        public static int Goblin_ID = 1;
        public static int Elemental_ID = 2;
        public static int GiantCrow_ID = 3;
        public static int PokemonMaster_ID = 4;
        public static int Grunt_ID = 5;
        public static int Dragon_ID = 6;




        public static int Location_ID_Forest = 1;
        public static int Location_ID_Cavern = 2;
        public static int Location_ID_Lake = 3;
        public static int Location_ID_Tower = 4;
        public static int Location_ID_Mountain = 5;
        public static int Location_ID_Dungeon = 6;
        public static int Location_ID_PalletTown = 7;


        static Map()
        {
            CreateLocations();
            CreateMonsters();
        }

        private static void CreateMonsters()
        {
            Monster goblin = new Monster (Goblin_ID, "Goblin",5,5,1,2);
            Monster fireElemental = new Monster(Elemental_ID, "Fire Elemental", 20, 20, 15, 10);
            Monster giantCrow = new Monster(GiantCrow_ID, "Giant Crow", 8, 8, 3, 5);
            Monster grunt = new Monster(Grunt_ID, "Grunt", 6, 6, 1, 7);
            Monster pokemonMaster = new Monster(PokemonMaster_ID, "Pokemon Master", 15, 15, 9, 25);
            Monster dragon = new Monster(Dragon_ID, "Dragon", 50, 50, 25, 100);

            Monsters.Add(goblin);
            Monsters.Add(fireElemental);
            Monsters.Add(giantCrow);
            Monsters.Add(grunt);
            Monsters.Add(pokemonMaster);
            Monsters.Add(dragon);

        }

        private static void CreateLocations()
        {
            Location forest = new Location(Location_ID_Forest,"Everwood Forest", "You stepped into everwood forest");
            Location cavern = new Location(Location_ID_Cavern, "Pyre Stone Caverns", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location lake = new Location(Location_ID_Lake, "Maiden's Lake", "You stumble the Maiden's lake, remember to pay homage to the lady of the lake");
            Location tower = new Location(Location_ID_Tower, "Tower", "Before you lies the dark tower");
            Location mountain = new Location(Location_ID_Mountain, "Mountain", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location dungeon = new Location(Location_ID_Dungeon, "Dungeon", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location palletTown = new Location(Location_ID_PalletTown, "Pallet Town", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");

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
