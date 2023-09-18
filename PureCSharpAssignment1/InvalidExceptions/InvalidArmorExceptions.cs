using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.InvalidExceptions
{
    /// <summary>
    /// The InvalidArmorException class has one single responsibility:
    /// to handle all the error message related to once the user has selected an invalid Armor type,
    /// the appropriate exceptions should be thrown if invalid (level requirement and type)
    /// </summary>
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string message) : base(message) { }

    }
}
