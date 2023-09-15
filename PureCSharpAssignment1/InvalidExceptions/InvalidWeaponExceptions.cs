using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.InvalidExceptions
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() : base() { }

        public InvalidWeaponException(string message) : base(message) { }

        public InvalidWeaponException(string message, Exception inner) : base(message, inner) { }
    }
}
