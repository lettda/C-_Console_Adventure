using System;
namespace _350_final_project
{
    public class Player
    {
        internal int maxPlayerHealth;
        public int currentPlayerHealth;
        internal int playerDamage;
        internal int playerDef;
        internal int playerAgility;
        internal int playerStrength;
        public int playerExperience;


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


        public int MaxPlayerHealth { get => maxPlayerHealth;}
        public int CurrentPlayerHealth { get => currentPlayerHealth; set => currentPlayerHealth = value;}
        public int PlayerDamage { get => playerDamage;}
        public int PlayerDef { get => playerDef; }
        public int PlayerAgility { get => playerAgility; }
        public int PlayerStrength { get => playerStrength;}
        public int PlayerExperience { get => playerExperience;}

        //public override string ToString()
        //{
        //    return "Health: " + currentPlayerHealth;
        //}
        //public int DamageTaken(int monsterDMG)
        //{
        //    CurrentPlayerHealth = CurrentPlayerHealth - monsterDMG; //calculate the damage the player takes and overwrite their current HP value
        //    return CurrentPlayerHealth;
        //}
    }
}
