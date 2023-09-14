using PureCSharpAssignment1.Enums;

namespace PureCSharpAssignment1.Items
{
    public class Weapon : Item
    {
        //A WeaponType property that will store the type of the weapon.
        public WeaponType WeaponType { get; set; }

        //A Damage property that will store the damage value of the weapon.
        public int WeaponDamage { get; set; } // Weapons will have a damage value

        //A constructor that initializes these properties.
        public Weapon(WeaponType weaponType, int weaponDamage)
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }
}
