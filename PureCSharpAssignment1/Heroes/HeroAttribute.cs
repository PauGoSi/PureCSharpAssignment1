namespace PureCSharpAssignment1.Heroes
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
        /*
        public static HeroAttribute operator +(HeroAttribute a, HeroAttribute b)
        {
            return new HeroAttribute(a.Strength + b.Strength, a.Dexterity + b.Dexterity, a.Intelligence + b.Intelligence);
        }
        */
        public HeroAttribute Add(HeroAttribute other)
        {
            return new HeroAttribute(this.Strength + other.Strength, this.Dexterity + other.Dexterity, this.Intelligence + other.Intelligence);
        }


    }

}