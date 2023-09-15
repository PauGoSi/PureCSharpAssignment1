using PureCSharpAssignment1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpAssignment1.Items
{
    public abstract class Item
    {
        protected string Name { get; set; }
        protected int RequiredLevel { get; set; }  // All heroes start at level 1
        /*public Item(string Name, int RequiredLevel, Slot Slot) 
        {
            RequiredLevel = Level;
        }
        */
    }
}
