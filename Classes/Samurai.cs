using System;
using System.Collections.Generic;

namespace wizardtaketwo.Classes
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public Samurai(string name, int stre, int intel, int dex, int hp) : base(name, stre, intel, dex, hp)
        {
        }

        public override int Attack(Human target)
        {
            int dmg = base.Attack(target);
            if (target.Health <= 50)
            {
                target.Health = 0;
                Console.WriteLine($"{Name} just tornado kicked {target.Name} and now for all health points!");
            }
            else
            {
                Console.WriteLine($"{Name} just tornado kicked {target.Name} and now for all health points!");
            }
            return dmg;
        }
        public void Meditate()
        {
            health = 200;
            Console.WriteLine ($"{Name} thought about it and is now healed.");
        }
    }
}