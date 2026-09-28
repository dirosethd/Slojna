using ConsoleApp1.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Decorators
{
    public class CriticalDecorator : WeaponDecorator
    {
        public CriticalDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetName() => "Critical " + _weapon.GetName();
        public override int GetDamage() => _weapon.GetDamage() + 7;
    }
}
