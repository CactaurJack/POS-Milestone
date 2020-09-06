/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            Assert.True(drink.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            bool test = false;
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Ice = true;
            Assert.False(test == drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Size test = Size.Small;
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = Size.Medium;
            Assert.False(test == drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(price == drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(cal == drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Ice = includeIce;
            if (drink.Ice)
            {
                Assert.Contains<string>("Add ice", drink.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(drink.ToString(), name);
        }
    }
}