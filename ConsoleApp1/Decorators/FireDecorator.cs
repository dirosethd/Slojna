using ConsoleApp1.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Decorators
{
    public class FireDecorator : WeaponDecorator
    {
        public FireDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetName() => "Fire " + _weapon.GetName();
        public override int GetDamage() => _weapon.GetDamage() + 5;
    }
}
