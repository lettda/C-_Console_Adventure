using System;
namespace _350_final_project
{
    public class Player
    {
        internal int playerHealth;
        internal int maxPlayerHealth;
        internal int currentPlayerHealth;
        internal int playerDef;
        internal int playerAgility;
        internal int playerStrength;
        internal int playerExperience;

        public Player()
        {

        }

        public Player(int maxHp, int currentHp, int def, int agil, int str, int exp)
        {
            maxPlayerHealth = maxHp;
            currentPlayerHealth = currentHp;
            playerDef = def;
            playerAgility = agil;
            playerStrength = str;
            playerExperience = exp;
        }


        private int MaxPlayerHealth { get => maxPlayerHealth; set => maxPlayerHealth = value; }
        private int CurrentPlayerHealth { get => currentPlayerHealth; set => currentPlayerHealth = value; }
        private int PlayerDef { get => playerDef; set => playerDef = value; }
        private int PlayerAgility { get => playerAgility; set => playerAgility = value; }
        private int PlayerStrength { get => playerStrength; set => playerStrength = value; }
        private int PlayerExperience { get => playerExperience; set => playerExperience = value; }

        public override string ToString()
        {
            return "Health: " + playerHealth +
                "\nAgility: " + playerAgility +
                "\nFDefense: " + playerDef +
                "\nStrength: " + playerStrength;

        }
    }
}
