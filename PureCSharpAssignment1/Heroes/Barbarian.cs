using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    public class Barbarian : Hero
    {
        // Implementation of the abstract properties from the base class
        public override HeroAttribute BaseAttributes => new HeroAttribute(5, 2, 1);
        public override HeroAttribute LevelUpAttributes => new HeroAttribute(3, 2, 1);
        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Hatchets , WeaponType.Maces , WeaponType.Swords };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Mail, ArmorType.Plate };

        // Constructor
        public Barbarian(string name) : base(name) {}

        protected override int GetDamagingAttribute()
        {
            return TotalAttributes().Strength;  // For Barbarian
        }

    }
}
