using PureCSharpAssignment1.Enums;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    /// <summary>
    /// The only unique implementation in the Barbarian class is the GetDamagingAttribute method, 
    /// which determines which attribute (in this case, Strength) is used to calculate damage 
    /// for that particular hero subclass. 
    /// </summary>
    public class Barbarian : Hero
    {
        // Constructor
        public Barbarian(string name) : base(name) { }

        protected override int GetDamagingAttribute()
        {
            // For Wizard, damage attribute is Strength
            return TotalAttributes().Strength;
        }
    }
}
