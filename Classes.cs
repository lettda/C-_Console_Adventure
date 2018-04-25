using System;
namespace _350_final_project
{
    public class Player
    {
        internal int maxPlayerHealth;
        internal int currentPlayerHealth;
        internal int playerDamage;
        internal int playerDef;
        internal int playerAgility;
        internal int playerStrength;
        internal int playerExperience;


        public Player()
        {

        }

        public Player(int maxHp, int currentHp, int dmg, int def, int agil, int str, int exp)
        {
            maxPlayerHealth = maxHp;
            currentPlayerHealth = currentHp;
            playerDamage = dmg;
            playerDef = def;
            playerAgility = agil;
            playerStrength = str;
            playerExperience = exp;
        }


        private int MaxPlayerHealth { get => maxPlayerHealth;}
        public int CurrentPlayerHealth { get => currentPlayerHealth; set => currentPlayerHealth = value;}
        private int PlayerDamage { get => playerDamage;}
        private int PlayerDef { get => playerDef; }
        private int PlayerAgility { get => playerAgility; }
        private int PlayerStrength { get => playerStrength;}
        public int PlayerExperience { get => playerExperience;}

        //public override string ToString()
        //{
        //    return "Health: " + currentPlayerHealth;
        //}
        public int DamageTaken(int monsterDMG)
        {
            CurrentPlayerHealth = CurrentPlayerHealth - monsterDMG;
            return CurrentPlayerHealth;
        }
    }
}
