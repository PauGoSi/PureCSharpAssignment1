using System;
using PureCSharpAssignment1.Enums;
using PureCSharpAssignment1.Heroes;
using PureCSharpAssignment1.Heros;
using PureCSharpAssignment1.Items;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the type of hero you want to create: (Barbarian, Wizard, Archer, Swashbuckler)");
        string heroType = Console.ReadLine();

        Hero chosenHero;

        switch (heroType.ToLower())
        {
            case "barbarian":
                chosenHero = new Barbarian("Barbarian");
                break;
            case "wizard":
                chosenHero = new Wizard("Wizard");
                break;
            case "archer":
                chosenHero = new Archer("Archer");
                break;
            case "swashbuckler":
                chosenHero = new Swashbuckler("Swashbuckler");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("State at Level 1:");
        Console.WriteLine(chosenHero.Display());

        chosenHero.LevelUp();  // Leveling up the hero

        Console.WriteLine("\nState at Level 2:");
        Console.WriteLine(chosenHero.Display());
    }
}
