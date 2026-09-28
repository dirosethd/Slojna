using ConsoleApp1.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Decorators
{
    public class PoisonDecorator : WeaponDecorator
    {
        public PoisonDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetName() => "Poison " + _weapon.GetName();
        public override int GetDamage() => _weapon.GetDamage() + 3;
    }
}
