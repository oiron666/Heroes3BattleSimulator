using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Heroes3BattleSimulator
{
    class Unit
    {
        public string name;
        private Town town;
        private int lvl;
        private int attack;
        private int def;
        public int minDamage;
        public int maxDamage;
        public int hp;
        public int speed;
        private int growth;
        private int goldCost;
        private int otherCost;
        private string otherResource;
        private string special;
        private bool isAlive;
        private bool side;

        private Hero heroAttack;
        private Hero heroDef;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public string Name
        {
            set
            {
                Console.ReadLine();
            }
        }

        public Unit(string name, int minDamage, int maxDamage, int hp, int speed)
        {
            this.name = name;
            //this.town = town;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.hp = hp;
            this.speed = speed;
            isAlive = true;
        }
    }
}
