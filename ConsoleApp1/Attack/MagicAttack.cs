using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Attack
{
    public class MagicAttack : IAttack
    {
        public void Attack(string characterName)
        {
            Console.WriteLine($"{characterName} использует магическую атаку!");
        }
    }
}
