using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;
using Xunit;

namespace PureCSharpAssignment1.Tests
{
    public class ItemTests
    {
        [Fact]
        public void Weapon_ShouldHaveCorrectState()
        {
            // Arrange
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.HATCHETS, 2);

            // Assert
            Assert.Equal("Common Hatchet", weapon.Name);
            Assert.Equal(1, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(WeaponType.HATCHETS, weapon.WeaponType);
            Assert.Equal(2, weapon.WeaponDamage);
        }

        [Fact]
        public void Armor_ShouldHaveCorrectState()
        {
            // Arrange
            var armorAttribute = new HeroAttribute(1, 0, 0);
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, armorAttribute);

            // Assert
            Assert.Equal("Common Plate Chest", armor.Name);
            Assert.Equal(1, armor.RequiredLevel);
            Assert.Equal(Slot.Body, armor.Slot);
            Assert.Equal(ArmorType.Plate, armor.ArmorType);
            Assert.Equal(armorAttribute, armor.ArmorAttribute);
        }
    }
}
