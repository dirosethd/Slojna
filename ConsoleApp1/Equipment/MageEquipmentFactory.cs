using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class MageEquipmentFactory : IEquipmentFactory
    {
        public IWeapon CreateWeapon() => new Staff();
        public IArmor CreateArmor() => new Robe();
    }
}
