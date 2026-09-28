using ConsoleApp1.Attack;
using ConsoleApp1.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Characters
{
    public abstract class Character : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public IWeapon Weapon { get; set; }
        public IArmor Armor { get; set; }

        // Bridge: способ атаки вынесен в отдельный объект
        protected IAttack _attack;

        protected Character(string name, IAttack attack)
        {
            Name = name;
            _attack = attack;
            Level = 1;
            Health = 100;
        }

        public void SetAttack(IAttack attack) => _attack = attack;

        public virtual void Attack()
        {
            _attack.Attack(Name);
        }

        public abstract ICharacter Clone();

        protected void CopyTo(Character target)
        {
            target.Name = Name;
            target.Level = Level;
            target.Health = Health;
            target.Weapon = Weapon;
            target.Armor = Armor;
            target._attack = _attack;
        }
    }
}
