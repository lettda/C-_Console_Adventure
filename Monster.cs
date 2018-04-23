using System;
namespace _350_final_project
{
    public class Monster
    {



        public Monster (int id, string monsterName, int hp, int mxHp, int mxDmg, int exp)
        {
            ID = id;
            Name = monsterName;
            CurrentHp = hp;
            MaxHp = mxHp;
            MaxDamage = mxDmg;
            ExpReward = exp;

        }

        public static int ID { get; set; }
        public static string Name { get; set; }
        public static int CurrentHp { get; set; }
        public static int MaxHp { get; set; }
        public static int MaxDamage { get; set; }
        public static int ExpReward { get; set; }

    }
}
