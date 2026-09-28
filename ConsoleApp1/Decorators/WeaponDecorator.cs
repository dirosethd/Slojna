using ConsoleApp1.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Decorators
{
    public abstract class WeaponDecorator : IWeapon
    {
        protected readonly IWeapon _weapon;

        protected WeaponDecorator(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public virtual string GetName() => _weapon.GetName();
        public virtual int GetDamage() => _weapon.GetDamage();
    }
}
