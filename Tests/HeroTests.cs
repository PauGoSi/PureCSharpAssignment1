using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;
using Xunit;

namespace Tests
{
    public class HeroTests
    {
        [Fact]
        public void Archer_ShouldHaveCorrectBaseAttributes()
        {
            // Arrange
            Archer archer = new Archer("TestArcher");

            // Act
            var baseAttributes = archer.BaseAttributes;

            // Assert
            Assert.Equal(1, baseAttributes.Strength);
            Assert.Equal(7, baseAttributes.Dexterity);
            Assert.Equal(1, baseAttributes.Intelligence);
        }
    }

    public class DamageCalculationTests
    {
        private Weapon commonHatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchets, 2);
        private Armor commonPlateChest = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));

        [Fact]
        public void DamageWithoutWeapon_ShouldReturnCorrectValue()
        {
            // Arrange
            Barbarian barbarian = new Barbarian("TestBarbarian");
            double expectedDamage = 1 * (1 + (5 / 100.0));

            // Act
            double actualDamage = barbarian.Damage();

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void DamageWithValidWeapon_ShouldReturnCorrectValue()
        {
            // Arrange
            Barbarian barbarian = new Barbarian("TestBarbarian");
            barbarian.EquipWeapon(commonHatchet);
            double expectedDamage = 2 * (1 + (5 / 100.0));

            // Act
            double actualDamage = barbarian.Damage();

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void DamageWithValidWeaponAndArmor_ShouldReturnCorrectValue()
        {
            // Arrange
            Barbarian barbarian = new Barbarian("TestBarbarian");
            barbarian.EquipWeapon(commonHatchet);
            barbarian.EquipArmor(commonPlateChest);
            double expectedDamage = 2 * (1 + ((5 + 1) / 100.0));

            // Act
            double actualDamage = barbarian.Damage();

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }
    }
}