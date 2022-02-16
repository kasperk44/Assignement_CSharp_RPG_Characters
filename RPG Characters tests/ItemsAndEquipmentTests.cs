using assignment_1_c_sharp_fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPG_Characters_tests
{
    public class ItemsAndEquipmentTests
    {

        [Fact]
        public void EquipWeapon_EquipToHighWeapon_ShouldReturnInvalidWeaponException()
        {
            // Arrange
            Weapon testAxe = new Weapon("Axe", 2, "WEAPON", 5, 0.5);
            Warrior warriorobj1 = new Warrior("Test Warrior");

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => warriorobj1.EquipWeapon(testAxe.getRequiredLevel(), warriorobj1.getLevel(), testAxe.getItemType(), EquipmentCompartments.WEAPON, testAxe));
        }

        [Fact]
        public void EquipArmor_EquipToHighArmor_ShouldReturnInvalidArmorException()
        {
            // Arrange
            Armor testPlate = new Armor("Plate", 2, "BODY", 5);
            Warrior warriorobj2 = new Warrior("Test Warrior1");

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => warriorobj2.EquipArmor(testPlate.getRequiredLevel(), warriorobj2.getLevel(), testPlate.getItemType(), EquipmentCompartments.BODY, testPlate));
        }

        [Fact]
        public void EquipWeapon_EquipWrongWeaponType_ShouldReturnInvalidWeaponException()
        {
            // Arrange
            Weapon testBow = new Weapon("Bow", 1, "WEAPON", 5, 0.5);
            Warrior warriorobj3 = new Warrior("Test Warrior2");

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => warriorobj3.EquipWeapon(testBow.getRequiredLevel(), warriorobj3.getLevel(), testBow.getItemType(), EquipmentCompartments.WEAPON, testBow));
        }

        [Fact]
        public void EquipArmor_EquipWrongArmorType_ShouldReturnInvalidArmorException()
        {
            // Arrange
            Armor testCloth = new Armor("Cloth", 2, "BODY", 5);
            Warrior warriorobj4 = new Warrior("Test Warrior3");

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => warriorobj4.EquipArmor(testCloth.getRequiredLevel(), warriorobj4.getLevel(), testCloth.getItemType(), EquipmentCompartments.BODY, testCloth));
        }


        [Fact]
        public void EquipWeapon_EquipCorrectWeapon_ShouldReturnNewWeaponEquipped()
        {
            // Arrange
            string expected = "New weapon equipped";

            Warrior warriorobj5 = new Warrior("Test Warrior4");

            Weapon testAxe = new Weapon("Axe", 1, "WEAPON", 7, 1.1);


            // Act
            string actual = warriorobj5.EquipWeapon(testAxe.getRequiredLevel(), warriorobj5.getLevel(), testAxe.getItemType(), EquipmentCompartments.WEAPON, testAxe);


            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void EquipArmor_EquipCorrectArmor_ShouldReturnNewArmorEquipped()
        {
            // Arrange
            string expected = "New armor equipped";

            Warrior warriorobj6 = new Warrior("Test Warrior5");

            Armor testCloth = new Armor("Plate", 1, "BODY", 5);


            // Act
            string actual = warriorobj6.EquipArmor(testCloth.getRequiredLevel(), warriorobj6.getLevel(), testCloth.getItemType(), EquipmentCompartments.BODY, testCloth);


            // Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void CalculateDamage_NoWeaponEquipped_ShouldReturnCorrectInt()
        {
            // Arrange
            double expected = 1 * (1 + (5 / 100));
            Warrior warriorobj7 = new Warrior("Test Warrior6");
            Weapon testAxe = new Weapon("Axe", 1, "WEAPON", 7, 1.1);
            Armor testCloth = new Armor("Plate", 1, "BODY", 1);



            // Act
            double actual = warriorobj7.CalculateDamageHero(warriorobj7.getLevel(), testAxe.getWeaponDamage(), testAxe.getWeaponAttackSpeed(), testCloth.getitemIncreaseAttribute(), warriorobj7.getStrength());

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_WeaponEquipped_ShouldReturnCorrectDouble()
        {
            // Arrange
            double expected = (7 * 1.1) * (1 + (5 / 100));
            Warrior warriorobj8 = new Warrior("Test Warrior7");
            Weapon testAxe = new Weapon("Axe", 1, "WEAPON", 7, 1.1);
            Armor testCloth = new Armor("Plate", 1, "BODY", 1);




            // Act
            warriorobj8.EquipWeapon(testAxe.getRequiredLevel(), warriorobj8.getLevel(), testAxe.getItemType(), EquipmentCompartments.WEAPON, testAxe);
            double actual = warriorobj8.CalculateDamageHero(warriorobj8.getLevel(), testAxe.getWeaponDamage(), testAxe.getWeaponAttackSpeed(), testCloth.getitemIncreaseAttribute(), warriorobj8.getStrength());

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_WeaponAndArmorEquipped_ShouldReturnCorrectDouble()
        {
            // Arrange
            double expected = (7 * 1.1) * (1 + ((5 + 1) / 100));
            Warrior warriorobj8 = new Warrior("Test Warrior7");
            Weapon testAxe = new Weapon("Axe", 1, "WEAPON", 7, 1.1);
            Armor testCloth = new Armor("Plate", 1, "BODY", 1);


            // Act
            warriorobj8.EquipWeapon(testAxe.getRequiredLevel(), warriorobj8.getLevel(), testAxe.getItemType(), EquipmentCompartments.WEAPON, testAxe);
            warriorobj8.EquipArmor(testCloth.getRequiredLevel(), warriorobj8.getLevel(), testCloth.getItemType(), EquipmentCompartments.BODY, testCloth);
            double actual = warriorobj8.CalculateDamageHero(warriorobj8.getLevel(), testAxe.getWeaponDamage(), testAxe.getWeaponAttackSpeed(), testCloth.getitemIncreaseAttribute(), warriorobj8.getStrength());

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
