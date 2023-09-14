using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PureCSharpAssignment1.Heros
{
    public abstract class Hero
    {
        // A Name property that will store the name of the hero.
        protected string Name { get; set; }

        // 
        protected int Level { get; set; } = 1;  // All heroes start at level 1
        protected HeroAttribute LevelAttributes { get; set; }
        protected Dictionary<Slot, Item> Equipment { get; set; }
        protected List<WeaponType> ValidWeaponTypes { get; set; }
        protected List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name)
        {
            Name = name;
            Dictionary<Slot, Item> Equipment = new Dictionary<Slot, Item>
            {
                { Slot.Weapon, null },
                { Slot.HEAD, null },
                { Slot.Body, null },
                { Slot.Legs, null }
            };
        }

        public virtual void LevelUp()
        {
            Level++;
            // Logic to update LevelAttributes based on the hero type 
            // This would usually be defined in the subclass
        }



    }
}
