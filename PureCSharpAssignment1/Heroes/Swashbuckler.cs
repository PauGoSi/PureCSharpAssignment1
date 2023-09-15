using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Heroes
{
    public class Swashbuckler : Hero
    {
        public Swashbuckler(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(2, 6, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.DAGGERS, WeaponType.SWORDS };
            ValidArmorTypes = new List<ArmorType>{ArmorType.Leather, ArmorType.Mail};
        }

        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute levelGain = new HeroAttribute(1, 4, 1);
            LevelAttributes += levelGain;
        }
    }
}
