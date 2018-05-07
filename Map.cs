using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace _350_final_project
{
    public class Map
    {
        public static readonly List<Location> Locations = new List<Location>(); //create list to hold locations to be used
        public static readonly List<Monster> Monsters = new List<Monster>();    //create list to hold the types of monsters that will appear


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

        static void CreateMonsters() //instatiate new monster type and add it to the list
        {
            Monster goblin = new Monster ("Goblin","throws club",5,5,1,2);
            Monster fireElemental = new Monster("Fire Elemental", "hurls fire ball", 20, 20, 15, 10);
            Monster giantCrow = new Monster("Giant Crow", "wing attack", 8, 8, 3, 5);
            Monster grunt = new Monster("Grunt","fires its pistol", 6, 6, 1, 7);
            Monster pokemonMaster = new Monster("Pokemon Master","throws pokeball", 15, 15, 9, 25);
            Monster jester = new Monster("Jester", "tells a bad joke", 11, 11, 1, 100);
            Monster dragon = new Monster("Dragon","conjures a tornado of flames", 50, 50, 25, 100);
            Monster pikachu = new Monster("wild Pikachu", "uses thunderbolt!", 10, 10, 2, 3);
            Monster metapod = new Monster("wild Metapod", "uses harden!", 50,50,0,1);
            Monster boss = new Monster("The Dead God", "lashes out with his witch stone", 200, 200, 30, 50);

            Monsters.Add(goblin);
            Monsters.Add(fireElemental);
            Monsters.Add(giantCrow);
            Monsters.Add(grunt);
            Monsters.Add(pokemonMaster);
            Monsters.Add(dragon);

        }

        static void CreateLocations() //instantiate new location type and add it to the list
        {
            Location forest = new Location("Everwood Forest", "You stepped into everwood forest");
            Location cavern = new Location( "Pyre Stone Caverns", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location lake = new Location("Maiden's Lake", "You stumble the Maiden's lake, remember to pay homage to the lady of the lake");
            Location tower = new Location("Tower", "Before you lies the dark tower");
            Location mountain = new Location("Mountain", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location dungeon = new Location("Dungeon", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location palletTown = new Location("Pallet Town", "You wander into the Pyre Stone Caverns, a sign says 'Travelers Beware'");
            Location sevendore = new Location("Sevendore", "You come to the snow white village of Sevendore, ruled by the powerful mage lord");
            Location penumbra = new Location("The Penumbra", "Darkness surrounds you, the influence of the dead god is everywhere");
            Location brooklyn = new Location("Brooklyn", "You see a bodega on the corner, you can't resist its call");
            Location witheredVale = new Location("The Whithered Vale", "Before you lies the Whithered Vale, \n " +
                                                 "best not terry too long or you to will become part of the forest");
            Location oakvale = new Location("Oakvale","100ft: Town of Oakvale \n Population: 1");


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
