using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_1_c_sharp_fundamentals
{
    public class Armor : Items
    {

        /// <summary>
        /// Constructor for the Armor class
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="itemRequiredLevel"></param>
        /// <param name="itemSlot"></param>
        /// <param name="itemIncreaseAttribute"></param>
        public Armor(String itemType, int itemRequiredLevel, String itemSlot, int itemIncreaseAttribute)
        {
            Type = itemType;
            RequiredLevel = itemRequiredLevel;
            Slot = itemSlot;
            IncreaseAttribute = itemIncreaseAttribute;
            Console.WriteLine("an " + itemType + " has been made");
        }

        public String Type;
        public int RequiredLevel;
        public String Slot;
        public int IncreaseAttribute;


        /// <summary>
        /// a function to get the level which is required to equip the armor
        /// </summary>
        /// <returns>RequiredLevel</returns>
        public int getRequiredLevel()
        {
            return RequiredLevel;
        }


        /// <summary>
        /// a function to get the name of the armor
        /// </summary>
        /// <returns>Name</returns>
        public string getItemType()
        {
            return Type;
        }


        /// <summary>
        /// a function to return the increase attribute
        /// </summary>
        /// <returns>increase attribute</returns>
        public int getitemIncreaseAttribute()
        {
            return IncreaseAttribute;
        }
    }
    
}