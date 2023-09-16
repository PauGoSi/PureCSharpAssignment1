using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;

internal class Program
{
    static void Main(string[] args)
    {
        Hero chosenHero = ChooseHero();

        Console.WriteLine($"You've chosen a {chosenHero.GetType().Name}.");

        EquipWeaponToHero(chosenHero);
        EquipArmorToHero(chosenHero);


        // Display hero details for Level 1
        Console.WriteLine("\n--- Level 1 (State 1) ---");
        Console.WriteLine(chosenHero.Display());

        // Level up the hero and display details for Level 2
        chosenHero.LevelUp();
        Console.WriteLine("\n--- Level 2 (State 2) ---");
        Console.WriteLine(chosenHero.Display());
    }

    private static Hero ChooseHero()
    {
        while (true)
        {
            Console.WriteLine("Choose a hero (Barbarian, Wizard, Archer, Swashbuckler):");
            string chosenHeroType = Console.ReadLine();

            switch (chosenHeroType.ToLower())
            {
                case "barbarian":
                    return new Barbarian("Sr. Barbarian");
                case "wizard":
                    return new Wizard("Sr. Wizard");
                case "archer":
                    return new Archer("Sr. Archer");
                case "swashbuckler":
                    return new Swashbuckler("Sr. Swashbuckler");
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private static void EquipWeaponToHero(Hero hero)
    {
        Console.WriteLine("Valid weapon types for this hero:");
        foreach (var weapon in hero.ValidWeaponTypes)
        {
            Console.WriteLine($"- {weapon}");
        }

        while (true)
        {
            Console.WriteLine("Choose a weapon type:");
            string chosenWeaponType = Console.ReadLine();

            // Case-insensitive parsing
            if (Enum.TryParse(chosenWeaponType, true, out WeaponType weaponType) && hero.ValidWeaponTypes.Contains(weaponType))
            {
                hero.EquipWeapon(new Weapon("SomeWeaponName", hero.Level, weaponType, 10));
                Console.WriteLine($"Type of equipped weapon: {hero.Equipment[Slot.Weapon]?.GetType().Name ?? "null"}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid weapon type. Try one of the valid options.");
            }
        }
    }


    private static void EquipArmorToHero(Hero hero)
    {
        Console.WriteLine("Every armor gives your hero added by 1 to your heros 'Strength', 'Dexterity', and 'Intelligence' from level 1.\nValid armor types for this hero:");
        int index = 1;
        foreach (var armor in hero.ValidArmorTypes)
        {
            Console.WriteLine($"{index}. {armor}");
            index++;
        }

        int choice;
        while (true)
        {
            Console.WriteLine("Choose an armor type (by number):");
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= hero.ValidArmorTypes.Count)
            {
                var armorType = hero.ValidArmorTypes[choice - 1];
                Armor equippedArmor = new Armor("SomeArmorName", hero.Level, Slot.Body, armorType, new HeroAttribute(1, 1, 1));
                equippedArmor.Slot = Slot.Body;
                hero.EquipArmor(equippedArmor);
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try one of the valid options.");
            }
        }

    }
}
