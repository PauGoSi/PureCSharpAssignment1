using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    public class Wizard : Hero
    {
        // Implementation of the abstract properties from the base class
        public override HeroAttribute BaseAttributes => new HeroAttribute(1, 1, 8);
        public override HeroAttribute LevelUpAttributes => new HeroAttribute(1, 1, 5);
        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.STAFFS, WeaponType.WANDS };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Cloth };

        // Constructor
        public Wizard(string name) : base(name)
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
