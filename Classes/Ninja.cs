using System;
using System.Collections.Generic;
namespace wizardtaketwo.Classes
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int dmg = Dexterity * 5;
            if (rand.Next (1, 101) <=20 )
            {
                dmg += 10;
                base.Attack(target, dmg);
                Console.WriteLine($"{Name} punched {target.Name} for a total of {dmg} health points!");
            }
            else
            {
                base.Attack(target, dmg);
                Console.WriteLine($"{Name} punched {target.Name} for a total of {dmg} health points!");
            }
            return dmg;
        }
        public void Steal(Human target)
        {
            int dmg = 5;
            base.Attack(target, dmg);
            Health += dmg;
        }
    }
}