using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.InvalidExceptions
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string message) : base(message) { }

    }
}
