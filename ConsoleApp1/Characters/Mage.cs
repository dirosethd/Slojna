using ConsoleApp1.Attack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public class Mage : Character
    {
        public Mage(string name = "Mage", IAttack? attack = null)
            : base(name, attack ?? new MagicAttack()) { }

        public override ICharacter Clone()
        {
            var clone = new Mage(Name, _attack);
            CopyTo(clone);
            return clone;
        }

        public override string ToString() => $"Mage \"{Name}\"";
    }
}
