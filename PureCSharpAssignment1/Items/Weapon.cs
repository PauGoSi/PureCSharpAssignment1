using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Items.PureCSharpAssignment1.Items;

namespace PureCSharpAssignment1.Items
{
    public class Weapon : Item
    {
        public Slot Slot { get; set; }

        public WeaponType WeaponType { get; private set; }
        public int WeaponDamage { get; private set; }

        public Weapon(string name, int requiredLevel, WeaponType weaponType, int weaponDamage)
            : base(name, requiredLevel, Slot.Weapon)  // Calling the base constructor
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }

}
