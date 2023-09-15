﻿using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using PureCSharpAssignment1.InvalidExceptions;
using PureCSharpAssignment1.Items;
using PureCSharpAssignment1.Items.PureCSharpAssignment1.Items;
using System;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    public abstract class Hero
    {
        // Properties and fields
        public string Name { get; private set; }
        public int Level { get; private set; } = 1;
        public abstract HeroAttribute BaseAttributes { get; }
        public HeroAttribute LevelAttributes { get; set; }

        public abstract HeroAttribute LevelUpAttributes { get; }
        public Dictionary<Slot, Item> Equipment { get; private set; } = new Dictionary<Slot, Item>();
        public abstract List<WeaponType> ValidWeaponTypes { get; }
        public abstract List<ArmorType> ValidArmorTypes { get; }

        // Constructor
        protected Hero(string name)
        {
            Name = name;
            InitializeEquipmentSlots();
        }

        private void InitializeEquipmentSlots()
        {
            foreach (Slot slot in Enum.GetValues(typeof(Slot)))
            {
                Equipment[slot] = null;
            }
        }

        // Methods
        public virtual void LevelUp()
        {
            Level++;
            // Increase attributes logic based on the derived hero's LevelUpAttributes.
        }

        public virtual void EquipWeapon(Weapon weapon)
        {
            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                throw new InvalidWeaponException("Invalid weapon type for this hero.");
            }
            if (weapon.RequiredLevel > this.Level)
            {
                throw new InvalidWeaponException("Your level is too low to equip this weapon.");
            }
            Equipment[Slot.Weapon] = weapon;
        }

        public virtual void EquipArmor(Armor armor)
        {
            if (!ValidArmorTypes.Contains(armor.ArmorType))
            {
                throw new InvalidArmorException("Invalid armor type for this hero.");
            }
            if (armor.RequiredLevel > this.Level)
            {
                throw new InvalidArmorException("Your level is too low to equip this armor.");
            }
            Equipment[armor.Slot] = armor;
        }

        public HeroAttribute TotalAttributes()
        {
            // Start with LevelAttributes. If it's null, initialize with zeros.
            HeroAttribute totalAttributes = LevelAttributes ?? new HeroAttribute(0, 0, 0);

            foreach (var equipment in Equipment.Values)
            {
                if (equipment is Armor armor)
                {
                    totalAttributes = totalAttributes.Add(armor.ArmorAttribute);
                }
            }

            return totalAttributes;
        }


        public int Damage()
        {
            int weaponDamage = 1;  // default weapon damage if no weapon is equipped

            if (Equipment[Slot.Weapon] is Weapon weapon)
            {
                weaponDamage = weapon.WeaponDamage;
            }

            // Assuming you have a method to determine the damaging attribute:
            int damagingAttribute = GetDamagingAttribute();

            return (int)Math.Round(weaponDamage * (1 + damagingAttribute / 100.0));
        }

        public string Display()
        {
            HeroAttribute totalAttr = TotalAttributes();

            return $"Name: {Name}\n" +
                   $"Class: {GetType().Name}\n" +
                   $"Level: {Level}\n" +
                   $"Total Strength: {totalAttr.Strength}\n" +
                   $"Total Dexterity: {totalAttr.Dexterity}\n" +
                   $"Total Intelligence: {totalAttr.Intelligence}\n" +
                   $"Damage: {Damage()}";
        }


        private int GetDamagingAttribute()
        {
            HeroAttribute totalAttributes = TotalAttributes();
            switch (this)
            {
                case Barbarian _:
                    return totalAttributes.Strength;
                case Wizard _:
                    return totalAttributes.Intelligence;
                case Archer _:
                case Swashbuckler _:
                    return totalAttributes.Dexterity;
                default:
                    throw new InvalidOperationException("Unknown hero type.");
            }
        }

    }
}
