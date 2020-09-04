using System;
using System.Collections.Generic;

namespace wizardtaketwo.Classes
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }
        public override int Attack(Human target)
        {
            int dmg = base.Attack(target, Intelligence * 5);
            Console.WriteLine($"{Name} casted a spell on {target.Name} for a total of {dmg} health points");
            health += dmg;
            return health; 
        }
        public void Heal(Human target)
        {
            target.Health += 10;
            Console.WriteLine($"{Name} just casted a healing spell on {target.Name} and now their health is {target.Health}");
        }
    }
}