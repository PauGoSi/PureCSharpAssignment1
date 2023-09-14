using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.InvalidExceptions
{
    public class InvalidArmorExceptions : Exception
    {
        public InvalidArmorExceptions() { }
        public InvalidArmorExceptions(string message) : base(message) { }
    }
}
