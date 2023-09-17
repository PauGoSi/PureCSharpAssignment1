using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    public class Archer : Hero
    {
        // Implementation of the abstract properties from the base class
        public override HeroAttribute BaseAttributes => new HeroAttribute(1, 7, 1);
        public override HeroAttribute LevelUpAttributes => new HeroAttribute(1, 5, 1);
        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Bows };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };

        // Constructor
        public Archer(string name) : base(name) {}

        protected override int GetDamagingAttribute()
        {
            return TotalAttributes().Dexterity;  // For Archer
        }

    }
}
