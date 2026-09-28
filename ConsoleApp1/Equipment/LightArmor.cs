using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class LightArmor : IArmor
    {
        public string GetName() => "Light Armor";
        public int GetDefense() => 10;
    }
}
