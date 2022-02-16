using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_1_c_sharp_fundamentals
{
    public abstract class Items
    {

        /// <summary>
        /// Constructor for Items class
        /// </summary>
        public Items()
        {

        }
        public Items(String itemType, int itemRequiredLevel, String itemSlot)
        {
            Type = itemType;
            RequiredLevel = itemRequiredLevel;
            Slot = itemSlot;
        }

        public String Type { get; set; }
        public int RequiredLevel { get; set; }
        public String Slot { get; set; }


        /// <summary>
        /// Function to get the name of an item
        /// </summary>
        /// <returns>name of an item</returns>
        public string GetType()
        {
            return Type;
        }

        
    }
}