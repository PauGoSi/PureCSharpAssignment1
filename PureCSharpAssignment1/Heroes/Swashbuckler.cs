using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    public class Swashbuckler : Hero
    {
        // Implementation of the abstract properties from the base class
        public override HeroAttribute BaseAttributes => new HeroAttribute(2, 6, 1);
        public override HeroAttribute LevelUpAttributes => new HeroAttribute(1, 4, 1);
        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Daggers , WeaponType.Swords };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };

        // Constructor
        public Swashbuckler(string name) : base(name) {}

        protected override int GetDamagingAttribute()
        {
            return TotalAttributes().Dexterity;  // For Swashbuckler
        }

    }
}
