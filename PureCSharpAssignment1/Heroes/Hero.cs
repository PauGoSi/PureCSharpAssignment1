using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.InvalidExceptions;
using PureCSharpAssignment1.Items;

/// <summary>
/// The Hero class and its derived classes (Wizard, Archer, etc.) primarily have the responsibility of 
/// representing a hero and its core behaviors. If there's a reason to change these classes, it would 
/// be because the core behavior or characteristics of a hero or a specific type of hero changes.
/// 
/// All heroes share the same set of attributes and methods defined in the base Hero class. 
/// No derived class introduces a new attribute or method that would break the Liskov Substitution Principle.
/// </summary>

namespace PureCSharpAssignment1.Heroes
{
    public abstract class Hero
    {
        // Properties and fields
        public string Name { get; private set; }
        public int Level { get; private set; } = 1;

        // These are no longer abstract properties as they will be retrieved from HeroConfiguration
        public HeroAttribute BaseAttributes => HeroConfiguration.GetBaseAttributes(GetType().Name);
        public HeroAttribute LevelAttributes { get; set; }
        public HeroAttribute LevelUpAttributes => HeroConfiguration.GetLevelUpAttributes(GetType().Name);

        public List<WeaponType> ValidWeaponTypes => HeroConfiguration.GetValidWeaponTypes(GetType().Name);
        public List<ArmorType> ValidArmorTypes => HeroConfiguration.GetValidArmorTypes(GetType().Name);

        public Dictionary<Slot, Item> Equipment { get; private set; } = new Dictionary<Slot, Item>();

        // Constructor
        protected Hero(string name)
        {
            Name = name;
            LevelAttributes = BaseAttributes;
            InitializeEquipmentSlots();
        }

        private void InitializeEquipmentSlots()
        {
            foreach (Slot slot in Enum.GetValues(typeof(Slot)))
            {
                Equipment[slot] = null;
            }
        }

        public virtual void LevelUp()
        {
            Level++;
            LevelAttributes = LevelAttributes.Add(LevelUpAttributes);
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
            HeroAttribute totalAttributes = LevelAttributes;

            foreach (var equipment in Equipment.Values)
            {
                if (equipment is Armor armor)
                {
                    totalAttributes = totalAttributes.Add(armor.ArmorAttribute);
                }
            }

            return totalAttributes;
        }

        public double Damage()
        {
            double weaponDamage = 1.0;

            if (Equipment[Slot.Weapon] is Weapon weapon)
            {
                weaponDamage = weapon.WeaponDamage;
            }

            double damagingAttribute = GetDamagingAttribute();
            return weaponDamage * (1 + damagingAttribute / 100.0);
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

        protected abstract int GetDamagingAttribute();
    }
}
