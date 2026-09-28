using ConsoleApp1.Attack;
using ConsoleApp1.Characters;
using ConsoleApp1.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Builder
{
    public class CharacterBuilder
    {
        private string _name = "Unnamed";
        private int _level = 1;
        private int _health = 100;
        private IWeapon? _weapon;
        private IArmor? _armor;
        private IAttack? _attack;
        private string _classType = "Warrior";

        public CharacterBuilder SetClass(string classType)
        {
            _classType = classType;
            return this;
        }

        public CharacterBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public CharacterBuilder SetLevel(int level)
        {
            _level = level;
            return this;
        }

        public CharacterBuilder SetHealth(int health)
        {
            _health = health;
            return this;
        }

        public CharacterBuilder SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
            return this;
        }

        public CharacterBuilder SetArmor(IArmor armor)
        {
            _armor = armor;
            return this;
        }

        public CharacterBuilder SetAttack(IAttack attack)
        {
            _attack = attack;
            return this;
        }

        public Character Build()
        {
            Character character = _classType switch
            {
                "Mage" => new Mage(_name, _attack),
                "Archer" => new Archer(_name, _attack),
                _ => new Warrior(_name, _attack)
            };

            character.Level = _level;
            character.Health = _health;
            if (_weapon != null) character.Weapon = _weapon;
            if (_armor != null) character.Armor = _armor;

            return character;
        }
    }
}
