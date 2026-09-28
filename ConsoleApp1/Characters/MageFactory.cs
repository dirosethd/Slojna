using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public class MageFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter(string name)
            => new Mage(name);
    }
}
