using ConsoleApp1.Attack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public class Archer : Character
    {
        public Archer(string name = "Archer", IAttack? attack = null)
            : base(name, attack ?? new RangedAttack()) { }

        public override ICharacter Clone()
        {
            var clone = new Archer(Name, _attack);
            CopyTo(clone);
            return clone;
        }

        public override string ToString() => $"Archer \"{Name}\"";
    }
}
