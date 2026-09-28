using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipment
{
    public class Robe : IArmor
    {
        public string GetName() => "Robe";
        public int GetDefense() => 5;
    }
}
