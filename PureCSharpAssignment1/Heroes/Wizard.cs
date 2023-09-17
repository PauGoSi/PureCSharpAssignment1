using PureCSharpAssignment1.Enums;
using System.Collections.Generic;

namespace PureCSharpAssignment1.Heroes
{
    /// <summary>
    /// The only unique implementation in the Wizard class is the GetDamagingAttribute method, 
    /// which determines which attribute (in this case, Intelligence) is used to calculate damage 
    /// for that particular hero subclass. 
    /// </summary>

    public class Wizard : Hero
    {
        // Constructor
        public Wizard(string name) : base(name) { }

        protected override int GetDamagingAttribute()
        {
            // For Wizard, damage attribute is Intelligence
            return TotalAttributes().Intelligence;
        }
    }
}
