using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Composite
{
    public class Squad : IUnit
    {
        private readonly List<IUnit> _units = new List<IUnit>();
        public string Name { get; }

        public Squad(string name)
        {
            Name = name;
        }

        public void Add(IUnit unit) => _units.Add(unit);
        public void Remove(IUnit unit) => _units.Remove(unit);

        public void Attack()
        {
            System.Console.WriteLine($"=== {Name} атакует! ===");
            foreach (var unit in _units)
                unit.Attack();
        }
    }
}
