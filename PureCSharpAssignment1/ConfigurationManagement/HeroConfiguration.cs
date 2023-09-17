using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;


/// <summary>
/// The HeroConfiguration class has a single responsibility: 
/// to provide configurations for heroes (like their starting attributes and valid weapon/armor types). 
/// If there's a reason to change this class, it's because of the configurations, and not because of any 
/// functional logic or other unrelated concerns.
/// </summary>

public static class HeroConfiguration
{
    private static readonly Dictionary<string, HeroAttribute> BaseAttributeConfigurations = new Dictionary<string, HeroAttribute>
    {
        ["Wizard"] = new HeroAttribute(1, 1, 8),
        ["Archer"] = new HeroAttribute(1, 7, 1),
        ["Swashbuckler"] = new HeroAttribute(2, 6, 1),
        ["Barbarian"] = new HeroAttribute(5, 2, 1),
        // Add other hero types (in the furture) as needed...
    };

    private static readonly Dictionary<string, HeroAttribute> LevelUpAttributeConfigurations = new Dictionary<string, HeroAttribute>
    {
        ["Wizard"] = new HeroAttribute(1, 1, 5),
        ["Archer"] = new HeroAttribute(1, 5, 1),
        ["Swashbuckler"] = new HeroAttribute(1, 4, 1),
        ["Barbarian"] = new HeroAttribute(3, 2, 1),
        // Add other hero types (in the furture) as needed...
    };

    private static readonly Dictionary<string, List<WeaponType>> WeaponTypeConfigurations = new Dictionary<string, List<WeaponType>>
    {
        ["Wizard"] = new List<WeaponType> { WeaponType.Staffs, WeaponType.Wands },
        ["Archer"] = new List<WeaponType> { WeaponType.Bows },
        ["Swashbuckler"] = new List<WeaponType> { WeaponType.Daggers, WeaponType.Swords },
        ["Barbarian"] = new List<WeaponType> { WeaponType.Hatchets, WeaponType.Maces, WeaponType.Swords },
        // Add other hero types (in the furture) as needed...
    };

    private static readonly Dictionary<string, List<ArmorType>> ArmorTypeConfigurations = new Dictionary<string, List<ArmorType>>
    {
        ["Wizard"] = new List<ArmorType> { ArmorType.Cloth },
        ["Archer"] = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail },
        ["Swashbuckler"] = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail },
        ["Barbarian"] = new List<ArmorType> { ArmorType.Mail, ArmorType.Plate },
        // Add other hero types (in the furture) as needed...
    };

    // This method return the base attribute for the specific hero type
    public static HeroAttribute GetBaseAttributes(string heroType)
    {
        return BaseAttributeConfigurations[heroType];
    }

    // This method return the level-up attribute for the specific hero type
    public static HeroAttribute GetLevelUpAttributes(string heroType)
    {
        return LevelUpAttributeConfigurations[heroType];
    }

    // This method return valid weapon types for the specific heto type
    public static List<WeaponType> GetValidWeaponTypes(string heroType)
    {
        return WeaponTypeConfigurations[heroType];
    }

    // This method return valid armor types for the specific heto type
    public static List<ArmorType> GetValidArmorTypes(string heroType)
    {
        return ArmorTypeConfigurations[heroType];
    }
}
