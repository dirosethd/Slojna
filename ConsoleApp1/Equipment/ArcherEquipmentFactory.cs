using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class ArcherEquipmentFactory : IEquipmentFactory
    {
        public IWeapon CreateWeapon() => new Bow();
        public IArmor CreateArmor() => new LightArmor();
    }
}
