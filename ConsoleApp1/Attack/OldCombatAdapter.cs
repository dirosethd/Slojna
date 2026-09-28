using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Attack
{
    public class OldCombatAdapter : IAttack
    {
        private readonly OldCombatSystem _oldSystem;
        private readonly int _power;

        public OldCombatAdapter(OldCombatSystem oldSystem, int power = 42)
        {
            _oldSystem = oldSystem;
            _power = power;
        }

        public void Attack(string characterName)
        {
            _oldSystem.MakeHit(characterName, _power);
        }
    }
}
