using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_1_c_sharp_fundamentals
{
    public class Weapon : Items
    {
        /// <summary>
        /// The constructor for the weapon class
        /// </summary>
        /// <param name="itemName"></param>
        /// 
        public Weapon()
        { }
        public Weapon(String itemType)
        {
            RequiredLevel = 1;
            Type = itemType;
            Console.WriteLine("an " + itemType + " has been forged");
        }
       public Weapon(String itemType, int itemRequiredLevel, String itemSlot, int WeaponDamage, double WeaponAttackSpeed)
        {
            Type = itemType;
            RequiredLevel = itemRequiredLevel;
            Slot = itemSlot;
            Damage = WeaponDamage;
            AttackSpeed = WeaponAttackSpeed;
            Console.WriteLine("an " + itemType + " has been forged");
        }

        public String Type;
        public int RequiredLevel;
        public String Slot;
        public int Damage;
        public double AttackSpeed;


        /// <summary>
        /// a function to get the level which is required to equip the weapon
        /// </summary>
        /// <returns>RequiredLevel</returns>
        public int getRequiredLevel()
        {
            return RequiredLevel;
        }


        /// <summary>
        /// a function to get the name of the weapon
        /// </summary>
        /// <returns>Name</returns>
        public string getItemType()
        {
            return Type;
        }

        /// <summary>
        /// a function to get the weapon damage
        /// </summary>
        /// <returns>weapon damage</returns>
        public int getWeaponDamage()
        {
            return Damage;
        }


        /// <summary>
        /// a function to get the weapon attack speed
        /// </summary>
        /// <returns>weapon attack speed</returns>
        public double getWeaponAttackSpeed()
        {
            return AttackSpeed;
        }
    }

  
}