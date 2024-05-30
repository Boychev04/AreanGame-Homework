using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Warrior : Hero
    {
        private double bonusDamage { get; set; }
        private double hitCount;
        public Warrior(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            this.hitCount = 0;
            if(weapon.GetType() == typeof(Crossbow))
            {
                this.bonusDamage = armor * 3;
            } 
            else if (weapon.GetType() == typeof(Dagger))
            {
                this.bonusDamage = armor * 5;
            }
            else if (weapon.GetType() == typeof(Sword))
            {
                this.bonusDamage = armor * 6;
            }
        }
        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage + bonusDamage;
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
