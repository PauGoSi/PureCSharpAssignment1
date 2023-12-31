﻿using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Items
{
    public class Armor : Item
    {
        public Slot Slot { get; set; }

        public ArmorType ArmorType { get; private set; }
        public HeroAttribute ArmorAttribute { get; private set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType, HeroAttribute armorAttribute)
    :   base(name, requiredLevel, slot)  // Calling the base constructor with the name, requiredLevel and slot parameter
        {
            //Console.WriteLine($"Inside Armor Constructor: {slot}");  // Debugging line
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }

    }

}
