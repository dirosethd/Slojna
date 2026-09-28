using ConsoleApp1.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public interface ICharacter : IUnit
    {
        string Name { get; set; }
        int Level { get; set; }
        int Health { get; set; }
        ICharacter Clone();
    }
}
