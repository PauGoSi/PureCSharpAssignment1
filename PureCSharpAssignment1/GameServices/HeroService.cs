using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.GameServices
{
    /// <summary>
    /// The HeroService class has one single responsibility: 
    /// to validate all user input related to weapon and armor
    /// </summary>
    public class HeroService
    {
        public void EquipWeaponToHero(Hero hero)
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

        public void EquipArmorToHero(Hero hero)
        {
            Console.WriteLine("Every armor gives your hero added by 1 to your hero's 'Strength', 'Dexterity', and 'Intelligence' from level 1.\nValid armor types for this hero:");
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

}
