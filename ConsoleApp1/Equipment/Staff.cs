using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class Staff : IWeapon
    {
        public string GetName() => "MagicStaff";
        public int GetDamage() => 7;
    }
}
