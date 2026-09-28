using ConsoleApp1.Attack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public class Warrior : Character
    {
        public Warrior(string name = "Warrior", IAttack? attack = null)
            : base(name, attack ?? new PhysicalAttack()) { }

        public override ICharacter Clone()
        {
            var clone = new Warrior(Name, _attack);
            CopyTo(clone);
            return clone;
        }

        public override string ToString() => $"Warrior \"{Name}\"";
    }
}
