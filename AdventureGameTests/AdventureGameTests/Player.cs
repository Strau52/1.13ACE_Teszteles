using System;

namespace AdventureGame
{ 
    public class Player
    {
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

        public Player(double dexterity, double strength)
        {
            IsAlive = true;
            Health = 100;
            Dexterity = dexterity;
            Strength = strength;
        }

        public bool Attack(Enemy e)
        {
            if (strength > 0 && dexterity > 0)
            {
                e.Health -= strength / (1 / dexterity);
                return true;
            }
            return false;
        }
    }
}
