using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWater
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            Assert.False(drink.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            Assert.True(drink.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Size test = Size.Small;
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            drink.Size = Size.Medium;
            Assert.False(test == drink.Size);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSize()
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            Assert.True(drink.Price == 0.0);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSize()
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            Assert.True(drink.Calories == 0);
        }

        [Theory]
        [InlineData(true,true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            drink.Ice = includeIce;
            drink.Lemon = includeLemon;
            if (!drink.Ice)
            {
                Assert.Contains<string>("Hold ice", drink.SpecialInstructions);
            }
            if (drink.Lemon)
            {
                Assert.Contains<string>("Add lemon", drink.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Drinks.WarriorWater drink = new Data.Drinks.WarriorWater();
            drink.Size = size;
            Assert.Equal(drink.ToString(), name);
        }
    }
}
