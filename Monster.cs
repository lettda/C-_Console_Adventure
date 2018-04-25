using System;
namespace _350_final_project
{
    public class Monster
    {
        public Monster (string monsterName, string atk, int hp, int mxHp, int mxDmg, int exp)
        {
            Name = monsterName;
            Attack = atk;
            CurrentHp = hp;
            MaxHp = mxHp;
            MaxDamage = mxDmg;
            ExpReward = exp;

        }

        public string Name { get; set; }
        public string Attack { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int MaxDamage { get; set; }
        public int ExpReward { get; set; }

		public override string ToString()
		{
            return "Monster Health: " + CurrentHp;
		}

		public int MonsterDamageTaken(int playerDMG)    //calculate the damage the monster takes and overwrite its current HP value
        {
            CurrentHp = CurrentHp - playerDMG;
            return CurrentHp;
        }

    }
}
