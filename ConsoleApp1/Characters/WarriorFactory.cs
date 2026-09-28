using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public class WarriorFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter(string name)
            => new Warrior(name);
    }
}
