using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Heroes
{
    public class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(5, 2, 1);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.HATCHETS, WeaponType.MACES, WeaponType.SWORDS };
            ValidArmorTypes = new List<ArmorType>{ArmorType.Mail, ArmorType.Plate};
        }

        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute levelGain = new HeroAttribute(3, 2, 1);
            LevelAttributes += levelGain;
        }

    }
}
