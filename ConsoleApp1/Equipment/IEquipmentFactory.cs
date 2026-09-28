using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public interface IEquipmentFactory
    {
        IWeapon CreateWeapon();
        IArmor CreateArmor();
    }
}
