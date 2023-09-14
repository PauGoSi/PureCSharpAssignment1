using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.InvalidExceptions;
using PureCSharpAssignment1.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using PureCSharpAssignment1.Exceptions;


namespace PureCSharpAssignment1.Heros
{
    public abstract class Hero
    {
        // A Name property that will store the name of the hero.
        protected string Name { get; set; }

        // Using protected below makes sense for properties like Name, Level, and others because
        // we might want subclasses (Wizard, Archer, etc.) to have direct access to these fields or properties.
        // This facilitates easier manipulation and checking of these fields directly in the subclass methods without
        // the need for additional public getter or setter methods.
        protected int Level { get; set; } = 1;  // All heroes start at level 1
        protected HeroAttribute LevelAttributes { get; set; }
        protected Dictionary<Slot, Item> Equipment { get; set; }
        protected List<WeaponType> ValidWeaponTypes { get; set; }
        protected List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name)
        {
            Name = name;
            Dictionary<Slot, Item> Equipment = new Dictionary<Slot, Item>
            {
                { Slot.Weapon, null },
                { Slot.HEAD, null },
                { Slot.Body, null },
                { Slot.Legs, null }
            };
        }

        public virtual void LevelUp()
        {
            Level++;
            // Logic to update LevelAttributes based on the hero type 
            // This would usually be defined in the subclass
        }

        public void EquipWeapon(Weapon weapon)
        {
            // Check if the weapon type is valid for this hero
            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
                throw new InvalidWeaponExceptions("This hero cannot equip this weapon type!");

            // Equip the weapon
            Equipment[Slot.Weapon] = weapon;
        }

        
        public void EquipArmor(Armor armor)
        {
            // Check if the armor type is valid for this hero
            if (!ValidArmorTypes.Contains(armor.ArmorType))
                throw new InvalidArmorExceptions("This hero cannot equip this armor type!");

            // Equip the armor to the respective slot
            Equipment[armor.Slot] = armor;
        }
        /*
        public abstract int Damage();  // To be implemented by subclasses
        public abstract HeroAttribute TotalAttributes();  // To be implemented by subclasses
        */
    }
}
