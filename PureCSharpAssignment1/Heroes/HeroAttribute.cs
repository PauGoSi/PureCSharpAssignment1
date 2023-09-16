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
        
        public HeroAttribute Add(HeroAttribute other)
        {
            return new HeroAttribute(this.Strength + other.Strength, this.Dexterity + other.Dexterity, this.Intelligence + other.Intelligence);
        }


    }

}