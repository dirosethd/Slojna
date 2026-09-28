using ConsoleApp1.Attack;
using ConsoleApp1.Builder;
using ConsoleApp1.Characters;
using ConsoleApp1.Composite;
using ConsoleApp1.Decorators;
using ConsoleApp1.Equipment;
using ConsoleApp1.Setting;

namespace RPGSystem
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========== ШАГ 1: Singleton (GameSettings) ==========");
            GameSettings settings = GameSettings.Instance;
            Console.WriteLine(settings.GameName);
            Console.WriteLine($"Сложность: {settings.Difficulty}");
            Console.WriteLine($"Максимальный уровень: {settings.MaxLevel}");

            var s1 = GameSettings.Instance;
            var s2 = GameSettings.Instance;
            Console.WriteLine($"settings1 == settings2: {s1 == s2}");
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 2: Factory Method ==========");
            CharacterFactory warriorFactory = new WarriorFactory();
            ICharacter warriorBase = warriorFactory.CreateCharacter("BaseWarrior");
            Console.WriteLine($"Создан персонаж: {warriorBase}");
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 3: Abstract Factory ==========");
            IEquipmentFactory equipFactory = new WarriorEquipmentFactory();
            IWeapon sword = equipFactory.CreateWeapon();
            IArmor heavyArmor = equipFactory.CreateArmor();
            Console.WriteLine($"Оружие: {sword.GetName()}");
            Console.WriteLine($"Броня: {heavyArmor.GetName()}");
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 4: Builder ==========");
            CharacterBuilder builder = new CharacterBuilder();
            Character rei = builder
                .SetClass("Warrior")
                .SetName("Кулибяка")
                .SetLevel(10)
                .SetHealth(150)
                .SetWeapon(sword)
                .SetArmor(heavyArmor)
                .SetAttack(new PhysicalAttack())
                .Build();

            Console.WriteLine($"Имя: {rei.Name}");
            Console.WriteLine($"Класс: Warrior");
            Console.WriteLine($"Уровень: {rei.Level}");
            Console.WriteLine($"HP: {rei.Health}");
            Console.WriteLine($"Оружие: {rei.Weapon.GetName()}");
            Console.WriteLine($"Броня: {rei.Armor.GetName()}");
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 5: Decorator ==========");
            IWeapon decorated = new Sword();
            Console.WriteLine($"Базовое оружие: {decorated.GetName()} (урон {decorated.GetDamage()})");

            decorated = new FireDecorator(decorated);
            Console.WriteLine($"После Fire: {decorated.GetName()} (урон {decorated.GetDamage()})");

            decorated = new PoisonDecorator(decorated);
            Console.WriteLine($"После Poison: {decorated.GetName()} (урон {decorated.GetDamage()})");

            decorated = new CriticalDecorator(decorated);
            Console.WriteLine($"После Critical: {decorated.GetName()} (урон {decorated.GetDamage()})");

            rei.Weapon = decorated;
            Console.WriteLine($"Итоговый урон: {rei.Weapon.GetDamage()}");
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 6: Bridge (типы атак) ==========");
            rei.SetAttack(new PhysicalAttack());
            rei.Attack();

            rei.SetAttack(new MagicAttack());
            rei.Attack();
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 7: Adapter (OldCombatSystem) ==========");
            var oldSystem = new OldCombatSystem();
            IAttack adaptedAttack = new OldCombatAdapter(oldSystem, 99);
            rei.SetAttack(adaptedAttack);
            rei.Attack();
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 8: Prototype (клонирование) ==========");
            Character original = new Warrior("Виспарик");
            original.Level = 10;
            original.Health = 150;
            original.Weapon = new Sword();
            original.Armor = new HeavyArmor();

            Character clone = (Character)original.Clone();
            clone.Name = "Виспарик Clone";
            clone.Level = 20;

            Console.WriteLine("Оригинал:");
            Console.WriteLine($"  Имя: {original.Name}, Уровень: {original.Level}, HP: {original.Health}");

            Console.WriteLine("Копия:");
            Console.WriteLine($"  Имя: {clone.Name}, Уровень: {clone.Level}, HP: {clone.Health}");

            Console.WriteLine($"Оригинал не изменился: {original.Name} / Level {original.Level}");
            Console.WriteLine();

            Console.WriteLine("========== ШАГ 9: Composite (Army) ==========");


            var armyWarrior = new WarriorFactory().CreateCharacter("Warrior1");
            var armyMage = new MageFactory().CreateCharacter("Mage1");
            var squadArcher = new ArcherFactory().CreateCharacter("Archer1");
            var squadWarrior = new WarriorFactory().CreateCharacter("Warrior2");
            var squadMage = new MageFactory().CreateCharacter("Mage2");
            var squad2Warrior = new WarriorFactory().CreateCharacter("Warrior3");
            var squad2Archer = new ArcherFactory().CreateCharacter("Archer2");

    
            var squad1 = new Squad("Squad 1");
            squad1.Add(squadArcher);
            squad1.Add(squadWarrior);
            squad1.Add(squadMage);

       
            var squad2 = new Squad("Squad 2");
            squad2.Add(squad2Warrior);
            squad2.Add(squad2Archer);

  
            var army = new Squad("Army");
            army.Add(armyWarrior);
            army.Add(armyMage);
            army.Add(squad1);
            army.Add(squad2);

            army.Attack();

            Console.WriteLine();
            Console.WriteLine("========== ДЕМОНСТРАЦИЯ ЗАВЕРШЕНА ==========");
        }
    }
}