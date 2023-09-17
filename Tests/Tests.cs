using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.InvalidExceptions;
using PureCSharpAssignment1.Items;
using Xunit;

namespace Tests
{
    public class HeroTests
    {

        // Creation tests written for each sub class
        [Fact]
        public void Wizard_Creation_PropertiesCorrect()
        {
            // Arrange
            var wizard = new Wizard("TestWizard");

            // Act
            var ActualName = wizard.Name;
            int ActualLevel = wizard.Level;
            int ActualStrength = wizard.TotalAttributes().Strength;
            int ActualDexterity = wizard.TotalAttributes().Dexterity;
            int ActualIntelligence = wizard.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal("TestWizard", ActualName);
            Assert.Equal(1, ActualLevel);
            Assert.Equal(1, ActualStrength);
            Assert.Equal(1, ActualDexterity);
            Assert.Equal(8, ActualIntelligence);
        }

        [Fact]
        public void Archer_Creation_PropertiesCorrect()
        {
            // Arrange
            var archer = new Archer("TestArcher");

            // Act
            var ActualName = archer.Name;
            int ActualLevel = archer.Level;
            int ActualStrength = archer.TotalAttributes().Strength;
            int ActualDexterity = archer.TotalAttributes().Dexterity;
            int ActualIntelligence = archer.TotalAttributes().Intelligence;
            
            // Assert
            Assert.Equal("TestArcher", ActualName);
            Assert.Equal(1, ActualLevel);
            Assert.Equal(1, ActualStrength);
            Assert.Equal(7, ActualDexterity);
            Assert.Equal(1, ActualIntelligence);
        }

        [Fact]
        public void Swashbuckler_Creation_PropertiesCorrect()
        {
            // Arrange
            var swashbuckler = new Swashbuckler("TestSwashbuckler");

            // Act
            var ActualName = swashbuckler.Name;
            int ActualLevel = swashbuckler.Level;
            int ActualStrength = swashbuckler.TotalAttributes().Strength;
            int ActualDexterity = swashbuckler.TotalAttributes().Dexterity;
            int ActualIntelligence = swashbuckler.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal("TestSwashbuckler", ActualName);
            Assert.Equal(1, ActualLevel);
            Assert.Equal(2, ActualStrength);
            Assert.Equal(6, ActualDexterity);
            Assert.Equal(1, ActualIntelligence);
        }

        [Fact]
        public void Barbarian_Creation_PropertiesCorrect()
        {
            // Arrange
            var barbarian = new Barbarian("TestBarbarian");

            // Act
            var ActualName = barbarian.Name;
            int ActualLevel = barbarian.Level;
            int ActualStrength = barbarian.TotalAttributes().Strength;
            int ActualDexterity = barbarian.TotalAttributes().Dexterity;
            int ActualIntelligence = barbarian.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal("TestBarbarian", ActualName);
            Assert.Equal(1, ActualLevel);
            Assert.Equal(5, ActualStrength);
            Assert.Equal(2, ActualDexterity);
            Assert.Equal(1, ActualIntelligence);
        }

        // Leveling tests written for each sub class
        [Fact]
        public void Wizard_LevelUp_IncrementsCorrectly()
        {
            // Arrange
            var wizard = new Wizard("TestWizard");
            wizard.LevelUp();

            // Act
            int ActualLevel = wizard.Level;
            int ActualStrength = wizard.TotalAttributes().Strength;
            int ActualDexterity = wizard.TotalAttributes().Dexterity;
            int ActualIntelligence = wizard.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal(2, ActualLevel);
            Assert.Equal(2, ActualStrength);
            Assert.Equal(2, ActualDexterity);
            Assert.Equal(13, ActualIntelligence);
        }

        [Fact]
        public void Archer_LevelUp_IncrementsCorrectly()
        {
            // Arrange
            var archer = new Archer("TestArcher");
            archer.LevelUp();

            // Act
            int ActualLevel = archer.Level;
            int ActualStrength = archer.TotalAttributes().Strength;
            int ActualDexterity = archer.TotalAttributes().Dexterity;
            int ActualIntelligence = archer.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal(2, ActualLevel);
            Assert.Equal(2, ActualStrength);
            Assert.Equal(12, ActualDexterity);
            Assert.Equal(2, ActualIntelligence);
        }

        [Fact]
        public void Swashbuckler_LevelUp_IncrementsCorrectly()
        {
            // Arrange
            var swashbuckler = new Swashbuckler("TestSwashbuckler");
            swashbuckler.LevelUp();

            // Act
            int ActualLevel = swashbuckler.Level;
            int ActualStrength = swashbuckler.TotalAttributes().Strength;
            int ActualDexterity = swashbuckler.TotalAttributes().Dexterity;
            int ActualIntelligence = swashbuckler.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal(2, ActualLevel);
            Assert.Equal(3, ActualStrength);
            Assert.Equal(10, ActualDexterity);
            Assert.Equal(2, ActualIntelligence);
        }

        [Fact]
        public void Barbarian_LevelUp_IncrementsCorrectly()
        {
            // Arrange
            var barbarian = new Barbarian("TestBarbarian");
            barbarian.LevelUp();

            // Act
            int ActualLevel = barbarian.Level;
            int ActualStrength = barbarian.TotalAttributes().Strength;
            int ActualDexterity = barbarian.TotalAttributes().Dexterity;
            int ActualIntelligence = barbarian.TotalAttributes().Intelligence;

            // Assert
            Assert.Equal(2, ActualLevel);
            Assert.Equal(8, ActualStrength);
            Assert.Equal(4, ActualDexterity);
            Assert.Equal(2, ActualIntelligence);
        }
    }

    public class ItemTests
    {
        // When Weapon is created, it needs to have the correct name, required level, slot, weapon type, and damage
        [Fact]
        public void Weapon_Creation_PropertiesCorrect()
        {
            // Arrange
            var weapon = new Weapon("TestWeapon", 1, WeaponType.Bows, 10);

            // Act
            var ActualWeaponName = weapon.Name;
            var ActualRequiredLevel = weapon.RequiredLevel;
            var ActualSlot = weapon.Slot;
            var ActualWeaponType = weapon.WeaponType;
            var ActualWeaponDamage = weapon.WeaponDamage;

            // Assert
            Assert.Equal("TestWeapon", ActualWeaponName);
            Assert.Equal(1, ActualRequiredLevel);
            Assert.Equal(Slot.Weapon, ActualSlot);
            Assert.Equal(WeaponType.Bows, ActualWeaponType);
            Assert.Equal(10, ActualWeaponDamage);
        }

        // When Armor is created, it needs to have the correct name, required level, slot, armor type, and armor attributes
        [Fact]
        public void Armor_Creation_PropertiesCorrect()
        {
            // Arrange
            var armor = new Armor("TestArmor", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 1, 1));

            // Act
            var ActualArmorName = armor.Name;
            var ActualRequiredLevel = armor.RequiredLevel;
            var ActualSlot = armor.Slot;
            var ActualArmorType = armor.ArmorType;

            // Assert
            Assert.Equal("TestArmor", ActualArmorName);
            Assert.Equal(1, ActualRequiredLevel);
            Assert.Equal(Slot.Body, ActualSlot);
            Assert.Equal(ArmorType.Leather, ActualArmorType);
            Assert.Equal(1, armor.ArmorAttribute.Strength);
            Assert.Equal(1, armor.ArmorAttribute.Dexterity);
            Assert.Equal(1, armor.ArmorAttribute.Intelligence);
        }
    }

    public class InvalidExceptionTests
    {
        [Fact]
        public void Archer_EquipWeapon_ShouldThrowForInvalidType()
        {
            // Arrange
            var archer = new Archer("TestArcher");

            // Act
            var invalidWeapon = new Weapon("InvalidWeapon", 1, WeaponType.Maces, 10);

            // Assert
            Assert.Throws<InvalidWeaponException>(() => archer.EquipWeapon(invalidWeapon));
        }

        [Fact]
        public void Archer_EquipArmor_ShouldThrowForInvalidType()
        {
            // Arrange
            var archer = new Archer("TestArcher");

            // Act
            var invalidArmor = new Armor("InvalidArmor", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 1, 1));

            // Assert
            Assert.Throws<InvalidArmorException>(() => archer.EquipArmor(invalidArmor));
        }
    }

    public class TotalAttributeTests
    {
        [Fact]
        public void Archer_TotalAttributes_NoEquipment()
        {
            var archer = new Archer("TestArcher");

            Assert.Equal(1, archer.TotalAttributes().Strength);
            Assert.Equal(7, archer.TotalAttributes().Dexterity);
            Assert.Equal(1, archer.TotalAttributes().Intelligence);
        }

        [Fact]
        public void Archer_TotalAttributes_OnePieceOfArmor()
        {
            var archer = new Archer("TestArcher");
            var leatherArmor = new Armor("LeatherArmor", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 2, 1));

            archer.EquipArmor(leatherArmor);

            Assert.Equal(2, archer.TotalAttributes().Strength);
            Assert.Equal(9, archer.TotalAttributes().Dexterity);
            Assert.Equal(2, archer.TotalAttributes().Intelligence);
        }

        [Fact]
        public void Archer_TotalAttributes_TwoPiecesOfArmor()
        {
            var archer = new Archer("TestArcher");
            var leatherArmorBody = new Armor("LeatherArmorBody", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 2, 1));
            var leatherArmorHead = new Armor("LeatherArmorHead", 1, Slot.Head, ArmorType.Leather, new HeroAttribute(1, 1, 1));

            archer.EquipArmor(leatherArmorBody);
            archer.EquipArmor(leatherArmorHead);

            Assert.Equal(3, archer.TotalAttributes().Strength);
            Assert.Equal(10, archer.TotalAttributes().Dexterity);
            Assert.Equal(3, archer.TotalAttributes().Intelligence);
        }

        [Fact]
        public void Archer_TotalAttributes_ReplacedArmor()
        {
            var archer = new Archer("TestArcher");
            var oldLeatherArmor = new Armor("OldLeatherArmor", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 2, 1));
            var newLeatherArmor = new Armor("NewLeatherArmor", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 3, 2));

            archer.EquipArmor(oldLeatherArmor);
            archer.EquipArmor(newLeatherArmor); // This should replace the old armor

            Assert.Equal(3, archer.TotalAttributes().Strength);
            Assert.Equal(10, archer.TotalAttributes().Dexterity);
            Assert.Equal(3, archer.TotalAttributes().Intelligence);
        }

        // Maybe if time, similar tests for other heroes, like Wizard, Barbarian, and Swashbuckler.
    }

    public class DamageCalculationTests
    {
        private Weapon commonHatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchets, 2);
        private Armor commonPlateChest = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));

        [Fact]
        public void Barbarian_DamageWithoutWeapon_ShouldReturnCorrectValue()
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
        public void Barbarian_DamageWithValidWeapon_ShouldReturnCorrectValue()
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
        public void Barbarian_DamageWithValidWeaponAndArmor_ShouldReturnCorrectValue()
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
        // Maybe if time, similar tests for other heroes, like Wizard, Barbarian, and Swashbuckler.
    }
}