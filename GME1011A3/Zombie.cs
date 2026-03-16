using GME1011A3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroInheritance
{
    internal class Zombie : Minion
    {
        private int _infectionLevel;
        public Zombie(int health, int armour) : base(health, armour)
        {
            _infectionLevel = 0;
        }
        public override void TakeDamage(int damage)
        {
            _health -= damage;
        }
        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(2, 8);
        }
        public void Infection()
        {
            Console.WriteLine("**infectious bite**");
            Random rng = new Random();
            _infectionLevel = rng.Next(1,3);
        }
        public override string ToString()
        {
            return "Zombie" + base.ToString() + "]";
        }
        public int GetInfection() => _infectionLevel;
    }
}
