using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizzard : Hero
    {
        private double magicDamage { get; set; }
        private double hitCount;
        public Wizzard(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            Random random = new Random();
            double probability = random.NextDouble();
            if(probability < 0.05)
            {
                magicDamage = strenght * 100;
            } else if(probability < 0.3)
            {
                magicDamage = strenght * 1.3;
            } else
            {
                magicDamage = strenght * 0.5;
            }
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage + magicDamage;
            return realDamage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
