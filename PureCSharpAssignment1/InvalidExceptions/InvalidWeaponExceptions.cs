using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.InvalidExceptions
{
    public class InvalidWeaponExceptions : Exception
    {
        public InvalidWeaponExceptions() { }
        public InvalidWeaponExceptions(string message) : base(message) { }

    }
}
