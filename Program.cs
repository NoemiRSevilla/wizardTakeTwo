using System;
using wizardtaketwo.Classes;

namespace wizardtaketwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Human nibbles = new Human("Mr. Nibbles");
            Wizard benny = new Wizard("Benny Bob");
            benny.Attack(nibbles);
            Ninja adam = new Ninja("Adam");
            adam.Attack(benny);
            Samurai bob = new Samurai("Bob");
            bob.Attack(benny);
            Wizard ken = new Wizard ("Ken");
            ken.Heal(benny);
        }
    }
}
