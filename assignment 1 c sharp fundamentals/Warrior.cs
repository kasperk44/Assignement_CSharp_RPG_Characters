using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_1_c_sharp_fundamentals
{
    public class Warrior : Hero
    {
        /// <summary>
        /// Constructor for the warrior class
        /// </summary>
        /// <param name="warriorName"></param>
        public Warrior(string warriorName)
        {
            Strength = 5;
            Dexterity = 2;
            Intelligence = 1;
            Name = warriorName;
            Console.WriteLine("a warrior called " + warriorName +  " is created");
        }

        private int Strength { get; set; }
        private int Dexterity { get; set; }
        private int Intelligence { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// A function to get the strength of a warrior
        /// </summary>
        /// <returns>Strength</returns>
        public int getStrength()
        {
            return Strength;
        }

        /// <summary>
        /// A function to get the dexterity of a warrior
        /// </summary>
        /// <returns>dexterity</returns>
        public int getDexterity()
        {
            return Dexterity;
        }

        /// <summary>
        /// A function to get the Intelligence of a warrior
        /// </summary>
        /// <returns>Intelligence</returns>
        public int getIntelligence()
        {
            return Intelligence;
        }

        /// <summary>
        /// Function the get the hero level
        /// </summary>
        /// <returns>hero's level</returns>
        public int getLevel()
        {
            return Level;
        }

        /// <summary>
        /// A function to set the new attributes when a warrior has leveled up
        /// </summary>
        /// <param name="Level"></param>
        public void LevelUp(int getLevel)
        {
            Level = Level + 1;
            Strength = ((Level - 1) * 3) + 5;
            Dexterity = ((Level - 1) * 2) + 2;
            Intelligence = ((Level - 1) * 1) + 1;
        }



        /// <summary>
        /// Function to equip a weapon
        /// </summary>
        /// <param name="getRequiredLevel"></param>
        /// <param name="getLevel"></param>
        /// <param name="ItemType"></param>
        /// <param name="compartment"></param>
        /// <param name="items"></param>
        /// <exception cref="InvalidWeaponException"></exception>
        public string EquipWeapon(int getRequiredLevel, int getLevel, string ItemType, EquipmentCompartments compartment, Items items)
        {
            bool CorrectLevel = TestItemLevel(getRequiredLevel, getLevel);
            bool CorrectItemName = TestWeaponType(ItemType);


            if (CorrectLevel && CorrectItemName && compartment == EquipmentCompartments.WEAPON)
            {
                if (WeaponEquipped == true)
                {
                    Equipment.Contents.Remove(compartment);
                    Console.WriteLine("Weapon changed");
                }
                Equipment.Contents.Add(compartment, items);
                WeaponEquipped = true;
                return "New weapon equipped";
                
            }
            else
            //{
            //    if (Equipment.Contents.ContainsKey(compartment)
            //}
            {
                throw new InvalidWeaponException("weapon can't be equiped");
            }
            return "Error";
        }


        /// <summary>
        /// Function to equip armor
        /// </summary>
        /// <param name="getRequiredLevel"></param>
        /// <param name="getLevel"></param>
        /// <param name="ItemType"></param>
        /// <param name="compartment"></param>
        /// <param name="items"></param>
        /// <exception cref="InvalidArmorException"></exception>
        public string EquipArmor(int getRequiredLevel, int getLevel, string ItemType, EquipmentCompartments compartment, Items items)
        {
            bool CorrectLevel = TestItemLevel(getRequiredLevel, getLevel);
            bool CorrectItemName = TestArmorType(ItemType);
            if (CorrectLevel && CorrectItemName && compartment != EquipmentCompartments.WEAPON)
            {

                Equipment.Contents.Add(compartment, items);
                ArmorEquipped = true;
                return "New armor equipped";
                
            }
            else
            {
                throw new InvalidArmorException("Armor can't be equiped");
            }
            return "Error";

        }

        /// <summary>
        /// Function to calculate the attack damage of a hero
        /// </summary>
        /// <param name="getlevel"></param>
        /// <param name="WeaponDamage"></param>
        /// <param name="WeaponAttackSpeed"></param>
        /// <param name="IncreaseAttribute"></param>
        /// <param name="getStrength"></param>
        /// <returns>attack damage</returns>
        public double CalculateDamageHero(int getlevel, int WeaponDamage,double WeaponAttackSpeed, int IncreaseAttribute, int getStrength)
        {
            if (WeaponEquipped == false && ArmorEquipped == false)
            {
                return 1 * (1 + (getStrength / 100));
            }

            else if (WeaponEquipped == true && ArmorEquipped == false)
            {
                return (WeaponDamage * WeaponAttackSpeed) * (1 + (getStrength / 100));
            }

            else if (WeaponEquipped == false && ArmorEquipped == true)
            {
                return 1 * ( 1 + ((getStrength + IncreaseAttribute / 100)));
            }

            else
                return (WeaponDamage * WeaponAttackSpeed) * (1 + ((getStrength + IncreaseAttribute) / 100));

        }

        /// <summary>
        /// Function to see if the hero level is high enough to equip the item 
        /// </summary>
        /// <param name="getRequiredLevel"></param>
        /// <param name="getLevel"></param>
        /// <returns>true if level is high enough, else false</returns>
        public bool TestItemLevel(int getRequiredLevel, int getLevel)
        {
            if (getRequiredLevel <= getLevel)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Function to see if the hero can equip the weapon type
        /// </summary>
        /// <param name="ItemType"></param>
        /// <returns>true if the hero can equip the weapon, else false</returns>
        public bool TestWeaponType(String ItemType)
        {
            var AllowedItems = "Axe,Hammer,Sword";
            if (AllowedItems.Contains(ItemType))
                return true;
            else
                return false;
        }


        /// <summary>
        /// Function to see if the hero can equip the armor type 
        /// </summary>
        /// <param name="ItemType"></param>
        /// <returns>true if the hero can equip the armor, else false</returns>
        public bool TestArmorType(String ItemType)
        {
            var AllowedItems = "Mail,Plate";
            if (AllowedItems.Contains(ItemType))
                return true;
            else
                return false;
        }



    }
}