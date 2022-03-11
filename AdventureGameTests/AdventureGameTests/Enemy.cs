using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Enemy
    {
        private Random r;
        private double health;
        private double strength;
        private double dexterity;
        private bool isAlive;

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
        public double Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public double Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public double Health
        {
            get { return health; }
            set { health = value; }
        }

        public Enemy()
        {
            r = new Random();
            IsAlive = true;
            Health = r.Next(10,501);
            Dexterity = r.Next(1, 10);
            Strength = r.Next(1, 20);
        }
    }
}
