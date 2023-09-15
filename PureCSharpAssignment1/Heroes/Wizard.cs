using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using PureCSharpAssignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Heroes
{
    public class Wizard : Hero
    {

        public Wizard(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 1, 8);
            ValidWeaponTypes = new List<WeaponType> { WeaponType.STAFFS, WeaponType.WANDS };
            ValidArmorTypes = new List<ArmorType>{ ArmorType.Cloth };

            }

        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute levelGain = new HeroAttribute(1, 1, 5);
            LevelAttributes += levelGain;
        }


        

    }

}
