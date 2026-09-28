using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class WarriorEquipmentFactory : IEquipmentFactory
    {
        public IWeapon CreateWeapon() => new Sword();
        public IArmor CreateArmor() => new HeavyArmor();
    }
}
