using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Items
{
    public class Armor : Item
    {
        //A ArmorType property that will store the type of the armor.
        public ArmorType ArmorType { get; set; }

        //A HeroAttribute property that will store the type of the HeroAttribute
        public HeroAttribute HeroAttribute { get; private set; }
        public Slot Slot { get; internal set; }

        //A constructor that initializes these properties.
        public Armor(ArmorType armorType, HeroAttribute armorAttribute)
        {
            ArmorType = armorType;
            HeroAttribute = armorAttribute;
        }
    }
}
