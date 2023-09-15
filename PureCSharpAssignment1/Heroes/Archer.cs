using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Heroes
{
    public class Archer : Hero
    {
        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 7, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.BOWS };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        }

        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute levelGain = new HeroAttribute(1, 5, 1);
            LevelAttributes += levelGain;
        }
    }
}
