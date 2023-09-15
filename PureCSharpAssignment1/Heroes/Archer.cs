using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    public class Archer : Hero
    {
        // Implementation of the abstract properties from the base class
        public override HeroAttribute BaseAttributes => new HeroAttribute(1, 7, 1);
        public override HeroAttribute LevelUpAttributes => new HeroAttribute(1, 5, 1);
        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.BOWS };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };

        // Constructor
        public Archer(string name) : base(name)
        {
            LevelAttributes = BaseAttributes;
        }

        // Override the LevelUp method
        public override void LevelUp()
        {
            base.LevelUp(); // Call the base method to handle common leveling logic
            LevelAttributes = LevelAttributes?.Add(LevelUpAttributes) ?? LevelUpAttributes;
        }
    }
}
