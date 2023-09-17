using PureCSharpAssignment1.Enums;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    /// <summary>
    /// The only unique implementation in the Swashbuckler class is the GetDamagingAttribute method, 
    /// which determines which attribute (in this case, Dexterity) is used to calculate damage 
    /// for that particular hero subclass. 
    /// </summary>
    public class Swashbuckler : Hero
    {
        // Constructor
        public Swashbuckler(string name) : base(name) { }

        protected override int GetDamagingAttribute()
        {
            // For Swashbuckler, damage attribute is Dexterity
            return TotalAttributes().Dexterity;
        }
    }
}
