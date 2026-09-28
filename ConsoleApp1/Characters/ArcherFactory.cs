using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public class ArcherFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter(string name)
            => new Archer(name);
    }
}
