using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public abstract class CharacterFactory
    {
        public abstract ICharacter CreateCharacter(string name);
    }
}
