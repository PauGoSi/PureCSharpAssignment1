using PureCSharpAssignment1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Items
{
    //using PureCSharpAssignment1.Enums;
    using System;

    namespace PureCSharpAssignment1.Items
    {
        public abstract class Item
        {
            public string Name { get; protected set; }  // Because we might want to retrieve the Name elsewhere.
            public int RequiredLevel { get; protected set; }
            public Slot Slot { get; protected set; }

            protected Item(string name, int requiredLevel, Slot slot)
            {
                Name = name;
                RequiredLevel = requiredLevel;
                Slot = slot;
            }
        }
    }

}
