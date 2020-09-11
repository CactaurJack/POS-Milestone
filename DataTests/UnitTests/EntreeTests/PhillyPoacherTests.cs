/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            Assert.True(entree.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            Assert.True(entree.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            Assert.True(entree.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            entree.Sirloin = false;
            Assert.False(entree.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            entree.Onion = false;
            Assert.False(entree.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            entree.Roll = false;
            Assert.False(entree.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            Assert.True(entree.Price == 7.23);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            Assert.True(entree.Calories == 784);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            entree.Sirloin = includeSirloin;
            entree.Onion = includeOnion;
            entree.Roll = includeRoll;

            if (!entree.Sirloin)
            {
                Assert.Contains<string>("Hold sirloin", entree.SpecialInstructions);
            }
            if (!entree.Onion)
            {
                Assert.Contains<string>("Hold onions", entree.SpecialInstructions);
            }
            if (!entree.Roll)
            {
                Assert.Contains<string>("Hold roll", entree.SpecialInstructions);
            }
            

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.PhillyPoacher entree = new Data.Entrees.PhillyPoacher();
            Assert.Equal("Philly Poacher", entree.ToString());
        }
    }
}