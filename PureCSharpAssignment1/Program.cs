using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.GameServices;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Items;
using System;

internal class Program
{
    private static HeroService _heroService = new HeroService();
    static void Main(string[] args)
    {
        Hero chosenHero = ChooseHero();

        Console.WriteLine($"You've chosen a {chosenHero.GetType().Name}.");

        _heroService.EquipWeaponToHero(chosenHero);
        _heroService.EquipArmorToHero(chosenHero);


        // Display hero details for Level 1
        Console.WriteLine("\n--- Level 1 (State 1) ---");
        Console.WriteLine(chosenHero.Display());

        // Level up the hero and display details for Level 2
        chosenHero.LevelUp();
        Console.WriteLine("\n--- Level 2 (State 2) ---");
        Console.WriteLine(chosenHero.Display());
    }

    private static Hero ChooseHero()
    {
        while (true)
        {
            Console.WriteLine("Choose a hero (Barbarian, Wizard, Archer, Swashbuckler):");
            string chosenHeroType = Console.ReadLine();

            // A switch statement that takes care of the chosen hero the user has selected.
            switch (chosenHeroType.ToLower())
            {
                case "barbarian":
                    return new Barbarian("Sr. Barbarian");
                case "wizard":
                    return new Wizard("Sr. Wizard");
                case "archer":
                    return new Archer("Sr. Archer");
                case "swashbuckler":
                    return new Swashbuckler("Sr. Swashbuckler");
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    
}
