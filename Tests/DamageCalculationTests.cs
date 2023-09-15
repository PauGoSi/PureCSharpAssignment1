using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;
using Xunit;

namespace PureCSharpAssignment1.Tests
{
    public class DamageCalculationTests
    {
        [Fact]
        public void BarbarianDamage_NoWeaponEquipped_ShouldBeCorrect()
        {
            // Arrange
            var barbarian = new Barbarian("Conan");

            // Art
            int expectedDamage = 1;// Expected damage = 1 * (1 + (5/100)) = 1.05 (rounded to nearest integer)
            int actualDamage = barbarian.Damage();

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void BarbarianDamage_WithWeaponEquipped_ShouldBeCorrect()
        {
            // Arrange
            var barbarian = new Barbarian("Conan");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.HATCHETS, 2);
            barbarian.EquipWeapon(hatchet);

            // Act
            int expectedDamage = 2;// Expected damage = 2 * (1 + (5/100)) = 2.1 (rounded to nearest integer)
            int actualDamage = barbarian.Damage();

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void BarbarianDamage_WithWeaponAndArmorEquipped_ShouldBeCorrect()
        {
            // Arrange
            var barbarian = new Barbarian("Conan");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.HATCHETS, 2);
            var armorAttribute = new HeroAttribute(1, 0, 0);
            var plateArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, armorAttribute);
            
            barbarian.EquipWeapon(hatchet);
            barbarian.EquipArmor(plateArmor);

            // Act
            int expectedDamage = 2;// Expected damage = 2 * (1 + ((5+1)/100)) = 2.12 (rounded to nearest integer)
            int actualDamage = barbarian.Damage();

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }
    }
}
