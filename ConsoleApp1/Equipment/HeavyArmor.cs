using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class HeavyArmor : IArmor
    {
        public string GetName() => "Heavy Armor";
        public int GetDefense() => 20;
    }
}
