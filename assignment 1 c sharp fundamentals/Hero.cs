using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_1_c_sharp_fundamentals
{
    public abstract class Hero
    {

        /// <summary>
        /// Constuctor for the Hero class
        /// </summary>
        public Hero()
        {
            Level = 1;
            WeaponEquipped = false;
            ArmorEquipped = false;
            Equipment = new Equipment();
        }

        public Hero(String heroName)
        {
            Name = heroName;
            Level = 1;

            Equipment = new Equipment();
        }

        public String Name { get; set; }
        public int Level { get; set; }
        public bool WeaponEquipped { get; set; }
        public PrimaryAttributes PrimaryAttributes { get; set; }
        public bool ArmorEquipped { get; set; }
        public Equipment Equipment { get; set; }


        /// <summary>
        /// A function to see if a hero already has a weapon
        /// </summary>
        /// <returns>true if the hero already has a weapon, else false</returns>
        public bool IsWeaponEquiped()
        {
             return WeaponEquipped;
        }


        /// <summary>
        /// A function to see if a hero already has armo equiped
        /// </summary>
        /// <returns>true if the hero already has armor, else false</returns>
        public bool IsArmorEquiped()
        {
            return ArmorEquipped;
        }



    }
}