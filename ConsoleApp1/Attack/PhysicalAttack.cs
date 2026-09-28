using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Attack
{
    public class PhysicalAttack : IAttack
    {
        public void Attack(string characterName)
        {
            Console.WriteLine($"{characterName} использует физическую атаку!");
        }
    }
}
