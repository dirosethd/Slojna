using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class Bow : IWeapon
    {
        public string GetName() => "Bow";
        public int GetDamage() => 8;
    }
}
