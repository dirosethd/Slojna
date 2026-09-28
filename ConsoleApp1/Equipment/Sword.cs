using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class Sword : IWeapon
    {
        public string GetName() => "Sword";
        public int GetDamage() => 10;
    }
}
