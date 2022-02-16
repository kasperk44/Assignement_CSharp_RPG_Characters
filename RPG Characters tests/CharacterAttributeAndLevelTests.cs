using assignment_1_c_sharp_fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPG_Characters_tests
{
    public class CharacterAttributeAndLevelTests
    {
        [Fact]
        public void Mage_CheckLevelWhenCreated_ShouldReturnOne()
        {
            // Arrange
            int expectedLevel = 1;
            Mage mageobj1 = new Mage("Kasper");

            // Act
            int ActualLevel = new Mage("").Level;

            // Assert
            Assert.Equal(expectedLevel, ActualLevel);
        }

        [Fact]
        public void Mage_WhenGainedALevel_ShouldReturnTwo()
        {
            // Arrange
            int expectedLevel = 2;
            Mage mageobj2 = new Mage("Wizzard");
            mageobj2.LevelUp(mageobj2.getLevel());

            // Act
            int ActualLevel = mageobj2.getLevel();

            // Assert
            Assert.Equal(expectedLevel, ActualLevel);
        }

        [Fact]
        public void Mage_DefaultAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;
            Mage mageobj3 = new Mage("Gandalf");

            // Act
            int actualStrength = mageobj3.getStrength();
            int actualDexterity = mageobj3.getDexterity();
            int actualIntelligence = mageobj3.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Warrior_DefaultAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 5;
            int expectedDexterity = 2;
            int expectedIntelligence = 1;
            Warrior Warriorobj1 = new Warrior("Dark Knight");

            // Act
            int actualStrength = Warriorobj1.getStrength();
            int actualDexterity = Warriorobj1.getDexterity();
            int actualIntelligence = Warriorobj1.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Ranger_DefaultAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;
            Ranger rangerobj1 = new Ranger("Robin Hood");

            // Act
            int actualStrength = rangerobj1.getStrength();
            int actualDexterity = rangerobj1.getDexterity();
            int actualIntelligence = rangerobj1.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Roque_DefaultAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;
            Roque roqueobj1 = new Roque("Demon Slayer");

            // Act
            int actualStrength = roqueobj1.getStrength();
            int actualDexterity = roqueobj1.getDexterity();
            int actualIntelligence = roqueobj1.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Mage_LeveledUpAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 2;
            int expectedDexterity = 2;
            int expectedIntelligence = 13;
            Mage mageobj4 = new Mage("Gandalf The Grey");
            mageobj4.LevelUp(mageobj4.getLevel());

            // Act
            int actualStrength = mageobj4.getStrength();
            int actualDexterity = mageobj4.getDexterity();
            int actualIntelligence = mageobj4.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Warrior_LevelUpAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 8;
            int expectedDexterity = 4;
            int expectedIntelligence = 2;
            Warrior Warriorobj2 = new Warrior("White Knight");
            Warriorobj2.LevelUp(Warriorobj2.getLevel());

            // Act
            int actualStrength = Warriorobj2.getStrength();
            int actualDexterity = Warriorobj2.getDexterity();
            int actualIntelligence = Warriorobj2.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Ranger_LevelUpAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;
            Ranger rangerobj2 = new Ranger("The Bow Man");
            rangerobj2.LevelUp(rangerobj2.getLevel());

            // Act
            int actualStrength = rangerobj2.getStrength();
            int actualDexterity = rangerobj2.getDexterity();
            int actualIntelligence = rangerobj2.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void Roque_LevelUpAttributes_ShouldReturnTheSame()
        {
            // Arrange
            int expectedStrength = 3;
            int expectedDexterity = 10;
            int expectedIntelligence = 2;
            Roque roqueobj2 = new Roque("Dragon Slayer");
            roqueobj2.LevelUp(roqueobj2.getLevel());

            // Act
            int actualStrength = roqueobj2.getStrength();
            int actualDexterity = roqueobj2.getDexterity();
            int actualIntelligence = roqueobj2.getIntelligence();

            //  Assers
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }





    }
}
